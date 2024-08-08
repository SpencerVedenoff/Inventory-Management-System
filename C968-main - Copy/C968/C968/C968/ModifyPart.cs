namespace C968
{
    public partial class ModifyPart : Form
    {
        Inv inventory;
        public ModifyPart(Inv inventory, Part part)
        {
            this.inventory = inventory;
            InitializeComponent();
            idTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceTextBox.Text = part.Price.ToString();
            maxTextBox.Text = part.Max.ToString();
            minTextBox.Text = part.Min.ToString();
            if (part is InhousePart)
            {
                
                setupInhouse(part as InhousePart);
            }
            else

            {
                setupOutsourced(part as OutsourcedPart);
            }
        }
        private void setupInhouse(InhousePart part) 
        {
            inhouseButton.Checked = true;
            outsourcedButton.Checked = false;
            changingTextBox.Text = part.MachineID.ToString();
        }
        private void setupOutsourced(OutsourcedPart part)
        {
            outsourcedButton.Checked = true;
            inhouseButton.Checked = false;
            changingTextBox.Text = part.CompanyName;
        }
        private void inhouseButton_Checked(object sender, EventArgs e)
        {
            changingLabel.Text = "Machine ID";
            changingLabel.Location = new Point(40, 246);
        }

        private void outsourcedButton_Checked(object sender, EventArgs e)
        {
            changingLabel.Text = "Company Name";
            changingLabel.Location = new Point(6, 246);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Checks if inhouse/outsourced radio button clicked
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (inhouseButton.Checked)
            {
                saveInhouse();

            }
            else
            {
                saveOutsourced();
            }
            
        }
        private void saveInhouse()
        {
            var validator = new PartValidator();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                changingTextBox.Text,
                true
                );
            if (!valid) { validator.Show(); return; }
            inventory.updatePart(int.Parse(idTextBox.Text),
                new InhousePart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(changingTextBox.Text)
                    )
            );
            this.Close();
        }

        private void saveOutsourced()
        {
            var validator = new PartValidator();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                changingTextBox.Text,
                false
                );
            if (!valid) { validator.Show(); return; }
            inventory.updatePart(int.Parse(idTextBox.Text),
                new OutsourcedPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    changingTextBox.Text
                    )
            );
            this.Close();
        }

        public static bool IsInt(string s)
        {
            return int.TryParse(s, out int i);
        }
        public static bool IsDecimal(string s)
        {
            return decimal.TryParse(s, out decimal i);
        }

    }
}
