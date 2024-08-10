using C968.Classes;

// Add Part Form per Section B of Rubric

namespace C968
 
{
    public partial class AddPartForm : Form
    {
        Inv inventory;
        public AddPartForm(Inv inventory)
        {
            this.inventory = inventory;
            InitializeComponent();
            idTextBox.Text = GetID().ToString();
        }
        private int GetID()
        {
            var usedIDs = new HashSet<int>();
            foreach (Part part in inventory.TotalParts)
            {
                usedIDs.Add(part.PartID);
            }

            for (int i = 1; i <= inventory.TotalParts.Count; i++)
            {
                if (!usedIDs.Contains(i))
                {
                    return i;
                }
            }

            return inventory.TotalParts.Count + 1;
        }


        // Listenter for inhouse button change
        private void inhouse_Checked(object sender, EventArgs e)
        {
            dynamicLabel.Text = "Machine ID";
            dynamicLabel.Location = new Point(40, 245);
        }
        // Listener for outsourced button change
        private void outsourced_Checked(object sender, EventArgs e)
        {
            dynamicLabel.Text = "Company Name";
            dynamicLabel.Location = new Point(5, 245);
        }

        // Cancel Button Behavior for Form
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save Button behavior for inhouse/outsourced radio buttons
        private void save_Click(object sender, EventArgs e)
        {
            var saveAction = inhouseButton.Checked ? (Action)saveInhouse : saveOutsourced;
            saveAction();
        }

        // Method for Saving Inhouse Part
        private void saveInhouse()
        {
            var validator = new PartValidation();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                dynamicTextbox.Text,
                true
                );

            if (!valid) { validator.Show(); return; }

            inventory.addPart(
                new InPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    int.Parse(dynamicTextbox.Text)
                    )
            );
            this.Close();
        }

        // Method for Saving Outsourced Part
        private void saveOutsourced()
        {
            var validator = new PartValidation();
            bool valid = validator.Validate(
                nameTextBox.Text,
                priceTextBox.Text,
                inventoryTextBox.Text,
                minTextBox.Text,
                maxTextBox.Text,
                dynamicTextbox.Text,
                false
                );

            if (!valid) { validator.Show(); return; }
            inventory.addPart(
                new OutPart(
                    int.Parse(idTextBox.Text),
                    nameTextBox.Text,
                    decimal.Parse(priceTextBox.Text),
                    int.Parse(inventoryTextBox.Text),
                    int.Parse(minTextBox.Text),
                    int.Parse(maxTextBox.Text),
                    dynamicTextbox.Text
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
