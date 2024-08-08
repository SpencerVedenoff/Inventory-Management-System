namespace C968
{
    public partial class AddProduct : Form
    {
        Inv inventory;
        Product product;
        public AddProduct(Inv inventory)
        {
            this.inventory = inventory;
            this.product = new Product();
            InitializeComponent();
            idTextBox.Text = GetNextID().ToString();
            allPartsGrid.DataSource = this.inventory.AllParts;
            associatedPartsGrid.DataSource = product.AssociatedParts;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (allPartsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected!", "Error");
            }
            
            else
            {
                Part part = (Part)allPartsGrid.SelectedRows[0].DataBoundItem;
                product.addAssocPart(part);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
         
            if (associatedPartsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected! Please select a part to delete.", "Error");
            }
            
            else
            {
                Part part = (Part)associatedPartsGrid.SelectedRows[0].DataBoundItem;
                product.removeAssocPart(part.PartID);
            }
        }
        private int GetNextID()
        {
            var map = new Dictionary<int, int>();
            foreach (Product part in inventory.Products)
            {
                map.Add(part.ProductID, part.ProductID);
            }
            for (int i = 1; i <= inventory.Products.Count; i++)
            {
                bool inUse = map.TryGetValue(i, out int _);
                if (!inUse) return i;
            }
            return inventory.Products.Count + 1;

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            var validator = new ProductValidator();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "") { MessageBox.Show("Enter an ID", "Error"); return; }
            if (!int.TryParse(searchBox.Text, out int id)) { MessageBox.Show("Enter an ID", "Error"); return; }
            foreach (DataGridViewRow row in allPartsGrid.Rows)
            {
                if (row.DataBoundItem is Part part)
                {
                    if (part.PartID == id)
                    {
                        allPartsGrid.ClearSelection();
                        row.Selected = true;
                        return;
                    }
                }
            }
            MessageBox.Show("No Matching Parts Found", "Error");
        }
    }
}
