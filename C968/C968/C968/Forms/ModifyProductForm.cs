using System.ComponentModel;
using C968.Classes;

// Modify Product Form per Rubric Section E

namespace C968
{
    public partial class ModifyProductForm : Form
    {
        Inv inventory;
        Product product;
        BindingList<Part> parts;
        public ModifyProductForm(Inv inventory, Product product)

        {
            this.inventory = inventory;
            this.product = product;
            InitializeComponent();
            idTextBox.Text = this.product.ProductID.ToString();
            nameTextBox.Text = this.product.Name;
            priceTextBox.Text = this.product.Price.ToString();
            inventoryTextBox.Text = this.product.InStock.ToString();
            minTextBox.Text = this.product.Min.ToString();
            maxTextBox.Text = this.product.Max.ToString();
            allPartsGrid.DataSource = this.inventory.TotalParts;
            parts = new();
            foreach (Part part in this.product.AssocParts)
            {
                parts.Add(part);
            }
            associatedPartsGrid.DataSource = parts;

        }

        // Listener for Cancel button in Form

        private void cancel_Click(object sender, EventArgs e)

        {
            this.Close();
        }

        // Listener for Add button in form

        private void add_Click(object sender, EventArgs e)
        {
            var selectedPart = allPartsGrid.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault()?.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("None Selected, Please Add Part");
            }
            else
            {
                parts.Add(selectedPart);
            }
        }


        // Listener for Delete button in form

        private void delete_Click(object sender, EventArgs e)
        {
            // Checks if user has selected a row
            if (associatedPartsGrid.SelectedRows.Count == 0) { MessageBox.Show("None Selected, Please Add Part"); return; }
            Part part = (Part)associatedPartsGrid.SelectedRows[0].DataBoundItem;
            // Confirms if user wanted to delete sected row and executes the remove method if yes
            if (MessageBox.Show($"Please confirm deletion of part {part.Name}(ID:{part.PartID})", "Delete Part?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                parts.Remove(part);
            }

        }

        // Listener for save button in Form

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
            this.product.AssocParts = parts;
            this.product.ProductID = int.Parse(idTextBox.Text);
            this.product.Name = nameTextBox.Text;
            this.product.Price = decimal.Parse(priceTextBox.Text);
            this.product.InStock = int.Parse(inventoryTextBox.Text);
            this.product.Min = int.Parse(minTextBox.Text);
            this.product.Max = int.Parse(maxTextBox.Text);
            this.inventory.updateProduct(this.product.ProductID, this.product);
            this.Close();
        }

        // Listener for Search button in form

        private void search_Click(object sender, EventArgs e)
        {
            string input = searchBox.Text.Trim();

            // Check if the input is empty or invalid, and show an appropriate message
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please Enter an ID");
                return;
            }

            if (!int.TryParse(input, out int id))
            {
                MessageBox.Show("Please Enter a valid numeric ID");
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


        private void totalPartsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
