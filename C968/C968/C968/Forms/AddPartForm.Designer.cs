namespace C968
{
    partial class AddPartForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addPartLabel = new Label();
            inhouseButton = new RadioButton();
            outsourcedButton = new RadioButton();
            idLabel = new Label();
            idTextBox = new TextBox();
            dynamicTextbox = new TextBox();
            dynamicLabel = new Label();
            minTextBox = new TextBox();
            minLabel = new Label();
            maxTextBox = new TextBox();
            maxLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            inventoryTextBox = new TextBox();
            inventoryLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // addPartLabel
            // 
            addPartLabel.AutoSize = true;
            addPartLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addPartLabel.Location = new Point(123, 15);
            addPartLabel.Name = "addPartLabel";
            addPartLabel.Size = new Size(76, 21);
            addPartLabel.TabIndex = 0;
            addPartLabel.Text = "Add Part";
            // 
            // inhouseButton
            // 
            inhouseButton.AutoSize = true;
            inhouseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inhouseButton.Location = new Point(53, 39);
            inhouseButton.Name = "inhouseButton";
            inhouseButton.Size = new Size(91, 25);
            inhouseButton.TabIndex = 0;
            inhouseButton.TabStop = true;
            inhouseButton.Text = "In-House";
            inhouseButton.UseVisualStyleBackColor = true;
            inhouseButton.CheckedChanged += inhouse_Checked;
            // 
            // outsourcedButton
            // 
            outsourcedButton.AutoSize = true;
            outsourcedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            outsourcedButton.Location = new Point(182, 39);
            outsourcedButton.Name = "outsourcedButton";
            outsourcedButton.Size = new Size(109, 25);
            outsourcedButton.TabIndex = 1;
            outsourcedButton.TabStop = true;
            outsourcedButton.Text = "Outsourced";
            outsourcedButton.UseVisualStyleBackColor = true;
            outsourcedButton.CheckedChanged += outsourced_Checked;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(104, 72);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 21);
            idLabel.TabIndex = 3;
            idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(135, 70);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 2;
            // 
            // changingTextBox
            // 
            dynamicTextbox.Location = new Point(135, 244);
            dynamicTextbox.Name = "changingTextBox";
            dynamicTextbox.Size = new Size(100, 23);
            dynamicTextbox.TabIndex = 8;
            // 
            // changingLabel
            // 
            dynamicLabel.AutoSize = true;
            dynamicLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dynamicLabel.Location = new Point(40, 246);
            dynamicLabel.Name = "changingLabel";
            dynamicLabel.Size = new Size(88, 21);
            dynamicLabel.TabIndex = 5;
            dynamicLabel.Text = "Machine ID";
            dynamicLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(135, 215);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(100, 23);
            minTextBox.TabIndex = 7;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(92, 217);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 21);
            minLabel.TabIndex = 7;
            minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(135, 186);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(100, 23);
            maxTextBox.TabIndex = 6;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(90, 188);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(39, 21);
            maxLabel.TabIndex = 9;
            maxLabel.Text = "Max";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(135, 157);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(77, 159);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 21);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price";
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(135, 128);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(100, 23);
            inventoryTextBox.TabIndex = 4;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(53, 130);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(76, 21);
            inventoryLabel.TabIndex = 13;
            inventoryLabel.Text = "Inventory";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(135, 99);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(77, 101);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 21);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "Name";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(135, 294);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += save_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(216, 294);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancel_Click;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 338);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(inventoryTextBox);
            Controls.Add(inventoryLabel);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(maxTextBox);
            Controls.Add(maxLabel);
            Controls.Add(minTextBox);
            Controls.Add(minLabel);
            Controls.Add(dynamicTextbox);
            Controls.Add(dynamicLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(outsourcedButton);
            Controls.Add(inhouseButton);
            Controls.Add(addPartLabel);
            Name = "AddPartForm";
            Text = "AddPart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartLabel;
        private RadioButton inhouseButton;
        private RadioButton outsourcedButton;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox dynamicTextbox;
        private Label dynamicLabel;
        private TextBox minTextBox;
        private Label minLabel;
        private TextBox maxTextBox;
        private Label maxLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox inventoryTextBox;
        private Label inventoryLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button saveButton;
        private Button cancelButton;
    }
}