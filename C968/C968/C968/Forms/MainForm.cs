using System.ComponentModel;
using C968.Classes;

namespace C968

// Main Form per Part A of Rubric
{
    public partial class MainForm : Form
    {
        private Inv inventory;
        public MainForm()
        {
            inventory = MakeInventory();
            InitializeComponent();
            productGrid.DataSource = inventory.TotalProducts;
            partGrid.DataSource = inventory.TotalParts;
            
        }

        // Lists for Parts & Produts per Part A bullet point 2 of Rubric
        // Note: This is dummy data used to populate the list in Form
        private static Inv MakeInventory()
        {
            // Initialize and populate BindingList for Parts
            var totalParts = new BindingList<Part>
            {
                new OutPart(1, "CPU", 409.9m, 5, 1, 11, "AMD"),
                new OutPart(2, "RAM", 140.9m, 7, 2, 10, "Crucial"),
                new OutPart(3, "HDD", 95.9m, 6, 1, 13, "Western Digital"),
                new InPart(4, "AMD GPU", 215.5m, 10, 1, 5, 1),
                new InPart(5, "Nvidia GPU", 818.5m, 9, 1, 6, 2),
                new InPart(6, "Intel GPU", 311.5m, 12, 1, 7, 3)
            };

            // Initialize and populate BindingList for Products
            var totalProducts = new BindingList<Product>
            {
                CreateProduct(totalParts, 1, "F Tier PC", 599.99m, 3, 1, 100),
                CreateProduct(totalParts, 2, "D Tier PC", 999.99m, 5, 1, 80),
                CreateProduct(totalParts, 3, "C Tier PC", 1499.99m, 3, 1, 65),
                CreateProduct(totalParts, 4, "B Tier PC", 1999.99m, 5, 1, 55),
                CreateProduct(totalParts, 5, "A Tier PC", 2499.99m, 3, 1, 45),
                CreateProduct(totalParts, 6, "S Tier PC", 2999.99m, 5, 1, 25)
            };

            return new Inv(totalProducts, totalParts);
        }

        private static Product CreateProduct(BindingList<Part> parts, int id, string name, decimal price, int stock, int min, int max)
        {
            return new Product(CreateParts(parts), id, name, price, stock, min, max);
        }


        // Create Parts Method

        private static BindingList<Part> CreateParts(BindingList<Part> totalParts)
        {
            var parts = new BindingList<Part>();
            var random = new Random();

            var selectedIndices = new[] { random.Next(0, 2), random.Next(3, 6) };

            foreach (var index in selectedIndices)
            {
                parts.Add(totalParts[index]);
            }

            return parts;
        }


        // Buttons for Add, Modify, Delete, and Exit per part A bullet point 1 of rubric
        // Functionality for Buttons as per Part F/G of Rubric

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Listener for Add Button regarding parts list in Form

        private void partsAdd_Click(object sender, EventArgs e)
        {
            var addPartForm = new AddPartForm(inventory);
            addPartForm.ShowDialog();
        }

        // Listener for Delete Button regarding parts list in Form

        private void partsDelete_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem is Part part)
            {
                var confirmation = MessageBox.Show($"Confirm Selection {part.Name} (ID:{part.PartID})", "Delete Part?", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    inventory.deletePart(part);
                }
            }
            else
            {
                MessageBox.Show("No Row Selected", "Error");
            }
        }

        // Listener for Modify Button regarding Parts list in Form

        private void partsModify_Click(object sender, EventArgs e)
        {
            var selectedPart = partGrid.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Part;

            if (selectedPart != null)
            {
                using (var modifyPartForm = new ModifyPartForm(inventory, selectedPart))
                {
                    modifyPartForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select Row to Modify", "Error");
            }
        }

        // Listener for Search Button regarding Parts list in Form

        private void partsSearch_Click(object sender, EventArgs e)
        {
            string searchText = partSearchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Enter an ID");
                return;
            }

            if (!int.TryParse(searchText, out int id))
            {
                MessageBox.Show("Enter a valid numeric ID");
                return;
            }

            var matchingRow = partGrid.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.DataBoundItem is Part part && part.PartID == id);

            if (matchingRow != null)
            {
                partGrid.ClearSelection();
                matchingRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Matching Part Not Found");
            }
        }


        // Listener for Add Button for Products List for Form

        private void productsAdd_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(inventory);
            addProductForm.ShowDialog();
        }

        // Listener for Modify Button for Products List for Form

        private void productsModify_Click(object sender, EventArgs e)
        {
            // If user has not selected a row to modify, prompts user to select a row
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Select a Product to Modify"); return; }
            // Upon user selection, redirects to a new modify product form
            var modifyProductForm = new ModifyProductForm(inventory, (Product)productGrid.SelectedRows[0].DataBoundItem);
            modifyProductForm.ShowDialog();
        }

        // Listener for Delete Button regarding Products List for Form

        private void productsDelete_Click(object sender, EventArgs e)
        {   
            // Checks if row is selected when delete button is clicked, and prompts user if needed
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Select a Row to Delete"); return; }
            var product = (Product)productGrid.SelectedRows[0].DataBoundItem;
            // Error handling if a part is tied to a product selected for deletion
            if (product.AssocParts.Count != 0) { MessageBox.Show("Unable to Delete Product, a Part is still linked with it"); return; }
            // Message box to confirm if user wants to delete selected item, and execute removal from list if input is yes
            if (MessageBox.Show($"Please Confirm Selection {product.Name}(ID:{product.ProductID})", "Delete Product?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.removeProduct(product.ProductID);
            }
        }

        // Listener for Search Button regarding Products List for Form

        private void productsSearch_Click(object sender, EventArgs e)
        {
            string input = productsSearchBox.Text.Trim();

            // Check if the input is empty or invalid, and show an appropriate message
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Enter an ID");
                return;
            }

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("Enter a valid numeric ID");
                return;
            }

            // Search for the product in the data grid by ID
            var matchingRow = productGrid.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.DataBoundItem is Product product && product.ProductID == id);

            if (matchingRow != null)
            {
                productGrid.ClearSelection();
                matchingRow.Selected = true;
            }
            else
            {
                MessageBox.Show("Matching Product Not Found");
            }
        }

    }
}