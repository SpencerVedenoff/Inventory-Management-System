﻿namespace C968
{
    partial class ModifyProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            allPartsGrid = new DataGridView();
            partIDAllParts = new DataGridViewTextBoxColumn();
            nameAllParts = new DataGridViewTextBoxColumn();
            inventoryAllParts = new DataGridViewTextBoxColumn();
            priceAllParts = new DataGridViewTextBoxColumn();
            minAllParts = new DataGridViewTextBoxColumn();
            maxAllParts = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            addProductLabel = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            inventoryTextBox = new TextBox();
            inventoryLabel = new Label();
            priceTextBox = new TextBox();
            priceLabel = new Label();
            minTextBox = new TextBox();
            minLabel = new Label();
            maxTextBox = new TextBox();
            maxLabel = new Label();
            addButton = new Button();
            saveButton = new Button();
            cancelButton = new Button();
            allPartsLabel = new Label();
            associatedPartsLabel = new Label();
            associatedPartsGrid = new DataGridView();
            partIDAssociatedParts = new DataGridViewTextBoxColumn();
            nameAssociatedParts = new DataGridViewTextBoxColumn();
            inventoryAssociatedParts = new DataGridViewTextBoxColumn();
            priceAssociatedParts = new DataGridViewTextBoxColumn();
            minAssociatedParts = new DataGridViewTextBoxColumn();
            maxAssociatedParts = new DataGridViewTextBoxColumn();
            searchBox = new TextBox();
            searchButton = new Button();
            ((System.ComponentModel.ISupportInitialize)allPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // allPartsGrid
            // 
            allPartsGrid.AllowUserToAddRows = false;
            allPartsGrid.AllowUserToDeleteRows = false;
            allPartsGrid.AllowUserToResizeColumns = false;
            allPartsGrid.AllowUserToResizeRows = false;
            allPartsGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            allPartsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            allPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPartsGrid.Columns.AddRange(new DataGridViewColumn[] { partIDAllParts, nameAllParts, inventoryAllParts, priceAllParts, minAllParts, maxAllParts });
            allPartsGrid.Location = new Point(12, 107);
            allPartsGrid.MultiSelect = false;
            allPartsGrid.Name = "allPartsGrid";
            allPartsGrid.RowHeadersVisible = false;
            allPartsGrid.RowTemplate.Height = 25;
            allPartsGrid.ScrollBars = ScrollBars.Vertical;
            allPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allPartsGrid.Size = new Size(378, 193);
            allPartsGrid.TabIndex = 1;
            allPartsGrid.TabStop = false;
            // 
            // partIDAllParts
            // 
            partIDAllParts.DataPropertyName = "PartID";
            partIDAllParts.HeaderText = "Part ID";
            partIDAllParts.Name = "partIDAllParts";
            partIDAllParts.ReadOnly = true;
            partIDAllParts.Width = 50;
            // 
            // nameAllParts
            // 
            nameAllParts.DataPropertyName = "Name";
            nameAllParts.HeaderText = "Name";
            nameAllParts.Name = "nameAllParts";
            nameAllParts.ReadOnly = true;
            // 
            // inventoryAllParts
            // 
            inventoryAllParts.DataPropertyName = "InStock";
            inventoryAllParts.HeaderText = "Inventory";
            inventoryAllParts.Name = "inventoryAllParts";
            inventoryAllParts.ReadOnly = true;
            inventoryAllParts.Width = 75;
            // 
            // priceAllParts
            // 
            priceAllParts.DataPropertyName = "Price";
            priceAllParts.HeaderText = "Price";
            priceAllParts.Name = "priceAllParts";
            priceAllParts.ReadOnly = true;
            priceAllParts.Width = 50;
            // 
            // minAllParts
            // 
            minAllParts.DataPropertyName = "Min";
            minAllParts.HeaderText = "Min";
            minAllParts.Name = "minAllParts";
            minAllParts.ReadOnly = true;
            minAllParts.Width = 50;
            // 
            // maxAllParts
            // 
            maxAllParts.DataPropertyName = "Max";
            maxAllParts.HeaderText = "Max";
            maxAllParts.Name = "maxAllParts";
            maxAllParts.ReadOnly = true;
            maxAllParts.Width = 50;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(550, 306);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 999;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += delete_Click;
            // 
            // addProductLabel
            // 
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProductLabel.Location = new Point(11, 1);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(172, 21);
            addProductLabel.TabIndex = 4;
            addProductLabel.Text = "Modify Product Form";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.Location = new Point(312, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 21);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            idLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(343, 14);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(98, 23);
            idTextBox.TabIndex = 0;
            idTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(343, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(98, 23);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(285, 45);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 21);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(543, 14);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(82, 23);
            inventoryTextBox.TabIndex = 2;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inventoryLabel.Location = new Point(461, 14);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(76, 21);
            inventoryLabel.TabIndex = 9;
            inventoryLabel.Text = "Inventory";
            inventoryLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(543, 43);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(82, 23);
            priceTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(493, 41);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 21);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(677, 12);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(71, 23);
            minTextBox.TabIndex = 4;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            minLabel.Location = new Point(636, 12);
            minLabel.Name = "minLabel";
            minLabel.Size = new Size(37, 21);
            minLabel.TabIndex = 13;
            minLabel.Text = "Min";
            minLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(677, 45);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(71, 23);
            maxTextBox.TabIndex = 5;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(634, 45);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(39, 21);
            maxLabel.TabIndex = 15;
            maxLabel.Text = "Max";
            maxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // addButton
            // 
            addButton.Location = new Point(312, 300);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 16;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += add_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(745, 306);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += save_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(745, 330);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancel_Click;
            // 
            // allPartsLabel
            // 
            allPartsLabel.AutoSize = true;
            allPartsLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            allPartsLabel.Location = new Point(12, 83);
            allPartsLabel.Name = "allPartsLabel";
            allPartsLabel.Size = new Size(106, 19);
            allPartsLabel.TabIndex = 19;
            allPartsLabel.Text = "Candidate Parts";
            allPartsLabel.Click += totalPartsLabel_Click;
            // 
            // associatedPartsLabel
            // 
            associatedPartsLabel.AutoSize = true;
            associatedPartsLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            associatedPartsLabel.Location = new Point(428, 83);
            associatedPartsLabel.Name = "associatedPartsLabel";
            associatedPartsLabel.Size = new Size(194, 19);
            associatedPartsLabel.TabIndex = 20;
            associatedPartsLabel.Text = "Parts Associated With Product";
            // 
            // associatedPartsGrid
            // 
            associatedPartsGrid.AllowUserToAddRows = false;
            associatedPartsGrid.AllowUserToDeleteRows = false;
            associatedPartsGrid.AllowUserToResizeColumns = false;
            associatedPartsGrid.AllowUserToResizeRows = false;
            associatedPartsGrid.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            associatedPartsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            associatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsGrid.Columns.AddRange(new DataGridViewColumn[] { partIDAssociatedParts, nameAssociatedParts, inventoryAssociatedParts, priceAssociatedParts, minAssociatedParts, maxAssociatedParts });
            associatedPartsGrid.Location = new Point(428, 107);
            associatedPartsGrid.MultiSelect = false;
            associatedPartsGrid.Name = "associatedPartsGrid";
            associatedPartsGrid.RowHeadersVisible = false;
            associatedPartsGrid.RowTemplate.Height = 25;
            associatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            associatedPartsGrid.Size = new Size(369, 193);
            associatedPartsGrid.TabIndex = 21;
            associatedPartsGrid.TabStop = false;
            // 
            // partIDAssociatedParts
            // 
            partIDAssociatedParts.DataPropertyName = "PartID";
            partIDAssociatedParts.HeaderText = "Part ID";
            partIDAssociatedParts.Name = "partIDAssociatedParts";
            partIDAssociatedParts.ReadOnly = true;
            partIDAssociatedParts.Width = 50;
            // 
            // nameAssociatedParts
            // 
            nameAssociatedParts.DataPropertyName = "Name";
            nameAssociatedParts.HeaderText = "Name";
            nameAssociatedParts.Name = "nameAssociatedParts";
            nameAssociatedParts.ReadOnly = true;
            // 
            // inventoryAssociatedParts
            // 
            inventoryAssociatedParts.DataPropertyName = "InStock";
            inventoryAssociatedParts.HeaderText = "Inventory";
            inventoryAssociatedParts.Name = "inventoryAssociatedParts";
            inventoryAssociatedParts.ReadOnly = true;
            inventoryAssociatedParts.Width = 75;
            // 
            // priceAssociatedParts
            // 
            priceAssociatedParts.DataPropertyName = "Price";
            priceAssociatedParts.HeaderText = "Price";
            priceAssociatedParts.Name = "priceAssociatedParts";
            priceAssociatedParts.ReadOnly = true;
            priceAssociatedParts.Width = 50;
            // 
            // minAssociatedParts
            // 
            minAssociatedParts.DataPropertyName = "Min";
            minAssociatedParts.HeaderText = "Min";
            minAssociatedParts.Name = "minAssociatedParts";
            minAssociatedParts.ReadOnly = true;
            minAssociatedParts.Width = 50;
            // 
            // maxAssociatedParts
            // 
            maxAssociatedParts.DataPropertyName = "Max";
            maxAssociatedParts.HeaderText = "Max";
            maxAssociatedParts.Name = "maxAssociatedParts";
            maxAssociatedParts.ReadOnly = true;
            maxAssociatedParts.Width = 50;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(12, 301);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(223, 23);
            searchBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(234, 300);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 26;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += search_Click;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 360);
            Controls.Add(searchBox);
            Controls.Add(searchButton);
            Controls.Add(associatedPartsGrid);
            Controls.Add(associatedPartsLabel);
            Controls.Add(allPartsLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(maxTextBox);
            Controls.Add(maxLabel);
            Controls.Add(minTextBox);
            Controls.Add(minLabel);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(inventoryTextBox);
            Controls.Add(inventoryLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(addProductLabel);
            Controls.Add(deleteButton);
            Controls.Add(allPartsGrid);
            Name = "ModifyProductForm";
            Text = "Modify Product Form";
            ((System.ComponentModel.ISupportInitialize)allPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView allPartsGrid;
        private Button deleteButton;
        private Label addProductLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox inventoryTextBox;
        private Label inventoryLabel;
        private TextBox priceTextBox;
        private Label priceLabel;
        private TextBox minTextBox;
        private Label minLabel;
        private TextBox maxTextBox;
        private Label maxLabel;
        private Button addButton;
        private Button saveButton;
        private Button cancelButton;
        private Label allPartsLabel;
        private Label associatedPartsLabel;
        private DataGridView associatedPartsGrid;
        private DataGridViewTextBoxColumn partIDAllParts;
        private DataGridViewTextBoxColumn nameAllParts;
        private DataGridViewTextBoxColumn inventoryAllParts;
        private DataGridViewTextBoxColumn priceAllParts;
        private DataGridViewTextBoxColumn minAllParts;
        private DataGridViewTextBoxColumn maxAllParts;
        private DataGridViewTextBoxColumn partIDAssociatedParts;
        private DataGridViewTextBoxColumn nameAssociatedParts;
        private DataGridViewTextBoxColumn inventoryAssociatedParts;
        private DataGridViewTextBoxColumn priceAssociatedParts;
        private DataGridViewTextBoxColumn minAssociatedParts;
        private DataGridViewTextBoxColumn maxAssociatedParts;
        private TextBox searchBox;
        private Button searchButton;
    }
}