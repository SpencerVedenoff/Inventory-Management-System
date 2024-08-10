using C968.Classes;

// Add Product Form per Section D of Rubric

namespace C968
{
    public partial class AddProductForm : Form
    {
        Inv inventory;
        Product product;
        public AddProductForm(Inv inventory)
        {
            this.inventory = inventory;
            this.product = new Product();
            InitializeComponent();
            idTextBox.Text = GetID().ToString();
            allPartsGrid.DataSource = this.inventory.TotalParts;
            associatedPartsGrid.DataSource = product.AssocParts;
        }

        // Listener for Cancel Button for Form

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Listener for Add Button for Form

        private void add_Click(object sender, EventArgs e)
        {
            var selectedPart = allPartsGrid.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("No part selected");
            }
            else
            {
                product.addAssocPart(selectedPart);
            }
        }

        // Listener for Delete Button for Form

        private void delete_Click(object sender, EventArgs e)
        {
            var selectedPart = associatedPartsGrid.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("No part selected");
            }
            else
            {
                product.removeAssocPart(selectedPart.PartID);
            }
        }

        // Method for defining next Id when adding a new item in Products

        private int GetID()
        {
            var usedIDs = new HashSet<int>(inventory.TotalProducts.Select(p => p.ProductID));

            for (int i = 1; i <= inventory.TotalProducts.Count; i++)
            {
                if (!usedIDs.Contains(i))
                {
                    return i;
                }
            }

            return inventory.TotalProducts.Count + 1;
        }


        // Listener for Save button for Form

        private void save_Click(object sender, EventArgs e)
        {
            var validator = new ProductValidation();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text
                );

            if (!valid) { validator.Show(); return; }
            this.product.ProductID = int.Parse(idTextBox.Text);
            this.product.Name = nameTextBox.Text;
            this.product.Price = decimal.Parse(priceTextBox.Text);
            this.product.InStock = int.Parse(inventoryTextBox.Text);
            this.product.Min = int.Parse(minTextBox.Text);
            this.product.Max = int.Parse(maxTextBox.Text);
            this.inventory.addProduct(this.product);
            this.Close();
        }

        // Listener for Search Button for Form

        private void search_Click(object sender, EventArgs e)
        {
            string input = searchBox.Text.Trim();

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

            // Search for the part in the data grid by ID
            var matchingRow = allPartsGrid.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.DataBoundItem is Part part && part.PartID == id);

            if (matchingRow != null)
            {
                allPartsGrid.ClearSelection();
                matchingRow.Selected = true;
            }
            else
            {
                MessageBox.Show("No Matching Parts Found");
            }
        }

    }
}
