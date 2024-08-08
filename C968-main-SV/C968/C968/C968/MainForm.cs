using System.ComponentModel;

namespace C968

    // Creates Inventory data Per Section C of Rubric
{
    public partial class MainForm : Form
    {
        private Inv inventory;
        public MainForm()
        {
            inventory = CreateInventory();
            InitializeComponent();
            partGrid.DataSource = inventory.AllParts;
            productGrid.DataSource = inventory.Products;


        }

        // Lists for Parts & Produts per Part A bullet point 2 of Rubric
        private static Inv CreateInventory()
        {
            BindingList<Part> totalParts = new();
            totalParts.Add(new OutsourcedPart(1, "CPU", 20.9m, 5, 1, 5, "AMD"));
            totalParts.Add(new OutsourcedPart(2, "RAM", 14.9m, 7, 2, 10, "Crucial"));
            totalParts.Add(new OutsourcedPart(3, "HDD", 9.9m, 6, 1, 13, "Western Digital"));
            totalParts.Add(new InhousePart(4, "AMD GPU", 21.5m, 10, 1, 5, 1));
            totalParts.Add(new InhousePart(5, "Nvidia GPU", 18.5m, 9, 1, 6, 2));
            totalParts.Add(new InhousePart(6, "Intel GPU", 11.5m, 12, 1, 7, 3));
            BindingList<Product> products = new()
            {
                new Product(GenerateParts(totalParts), 1, "Computer1", 599.99m, 3, 1, 5),
                new Product(GenerateParts(totalParts), 2, "Computer2", 999.99m, 5, 1, 5),
                new Product(GenerateParts(totalParts), 3, "Computer3", 1499.99m, 3, 1, 5),
                new Product(GenerateParts(totalParts), 4, "Computer4", 1999.99m, 5, 1, 5),
                new Product(GenerateParts(totalParts), 5, "Computer5", 2499.99m, 3, 1, 5),
                new Product(GenerateParts(totalParts), 6, "Computer6", 2999.99m, 5, 1, 5)
            };
            return new Inv(products, totalParts);
        }
        private static BindingList<Part> GenerateParts(BindingList<Part> totalParts)
        {
            BindingList<Part> parts = new();
            Random random = new();
            int partOne = random.Next(0, 2);
            int partTwo = random.Next(3, 5);
            parts.Add(totalParts[partOne]);
            parts.Add(totalParts[partTwo]);
            return parts;
        }

        // Buttons for Add, Modify, Delete, and Exit per part A bullet point 1 of rubric
        // Functionality for Buttosn as per Part F/G of Rubric
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void partsAddButton_Click(object sender, EventArgs e)
        {
            var addPartForm = new AddPart(inventory);
            addPartForm.ShowDialog();
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count == 0) { MessageBox.Show("No Row Selected", "Error"); return; }
            var part = (Part)partGrid.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show($"Confirm Selection {part.Name}(ID:{part.PartID})", "Delete Part?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.deletePart(part);
            }

        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count > 0)
            {
                var modifyPartForm = new ModifyPart(inventory, (Part)partGrid.SelectedRows[0].DataBoundItem);
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select Row to Modify", "Error");
            }

        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            if (partSearchTextBox.Text == "") { MessageBox.Show("Enter an ID", "Error"); return; }
            if (!int.TryParse(partSearchTextBox.Text, out int id)) { MessageBox.Show("Enter an ID", "Error"); return; }
            foreach (DataGridViewRow row in partGrid.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.PartID == id)
                    {
                        partGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("Matching Part Not Found", "Error");

        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProduct(inventory);
            addProductForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            // if Product not found throws an error message prompting to re-search
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Select a Product to Modify", "Error"); return; }
            var modifyProductForm = new ModifyProduct(inventory, (Product)productGrid.SelectedRows[0].DataBoundItem);
            modifyProductForm.ShowDialog();
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (productGrid.SelectedRows.Count == 0) { MessageBox.Show("Select a Row to Delete", "Error"); return; }
            var product = (Product)productGrid.SelectedRows[0].DataBoundItem;
            if (product.AssociatedParts.Count != 0) { MessageBox.Show("Unable to Delete Product, a Part is still linked with it", "Error"); return; }
            
            if (MessageBox.Show($"Please Confirm Selection {product.Name}(ID:{product.ProductID})", "Delete Product?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                inventory.removeProduct(product.ProductID);
            }
        }
        // Checks if textbox is empty and prompts user
        // Checks if input is numerical and throws error
        // Retruns ProductID if inputs matches inventory
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            if (productsSearchBox.Text == "") { MessageBox.Show("Enter an ID", "Error"); return; }
            if (!int.TryParse(productsSearchBox.Text, out int id)) { MessageBox.Show("Enter an ID", "Error"); return; }
            foreach (DataGridViewRow row in productGrid.Rows)
            {
                if (row.DataBoundItem is Product product)
                {
                    if (product.ProductID == id)
                    {
                        productGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("Matching Product Not Found", "Error");
        }
    }
}