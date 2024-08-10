using C968.Classes;

// Modify Part Form Per Section C of Rubric

namespace C968
{
    public partial class ModifyPartForm : Form
    {
        Inv inventory;
        public ModifyPartForm(Inv inventory, Part part)
        {
            this.inventory = inventory;
            InitializeComponent();
            idTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceTextBox.Text = part.Price.ToString();
            maxTextBox.Text = part.Max.ToString();
            minTextBox.Text = part.Min.ToString();
            if (part is InPart)
            {
                
                setupInhouse(part as InPart);
            }
            else

            {
                setupOutsourced(part as OutPart);
            }
        }

        // Behavior for inhouse radio button in form

        private void setupInhouse(InPart part) 
        {
            inhouseButton.Checked = true;
            outsourcedButton.Checked = false;
            dynamicTextBox.Text = part.MachineID.ToString();
        }

        // Behavior for outsourced radio button in form

        private void setupOutsourced(OutPart part)
        {
            outsourcedButton.Checked = true;
            inhouseButton.Checked = false;
            dynamicTextBox.Text = part.CompanyName;
        }

        // Listener for inhouse button in form

        private void inhouse_Checked(object sender, EventArgs e)
        {
            dynamicLabel.Text = "Machine ID";
            dynamicLabel.Location = new Point(40, 245);
        }

        // Listener for Outsourced button in form

        private void outsourced_Checked(object sender, EventArgs e)
        {
            dynamicLabel.Text = "Company Name";
            dynamicLabel.Location = new Point(5, 245);
        }

        // Listener for Cancel button in form

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Checks which radio button is checked when clicking save button in form
        private void save_Click(object sender, EventArgs e)
        {
            Action saveAction = inhouseButton.Checked ? (Action)saveInhouse : saveOutsourced;
            saveAction();
        }


        // Method for saving inhouse

        private void saveInhouse()
        {
            var validator = new PartValidation();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                dynamicTextBox.Text,
                true
                );

            if (!valid) { validator.Show(); return; }

            inventory.updatePart(int.Parse(idTextBox.Text),
                new InPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(dynamicTextBox.Text)
                    )
            );

            this.Close();
        }

        // Method for saving outsourced in form

        private void saveOutsourced()
        {
            var validator = new PartValidation();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                dynamicTextBox.Text,
                false
                );

            if (!valid) { validator.Show(); return; }

            inventory.updatePart(int.Parse(idTextBox.Text),
                new OutPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    dynamicTextBox.Text
                    )
            );

            this.Close();
        }

        public static bool IsInt(string input)
        {
            return int.TryParse(input, out int _);
        }
        public static bool IsDecimal(string input)
        {
            return decimal.TryParse(input, out decimal _);
        }

    }
}
