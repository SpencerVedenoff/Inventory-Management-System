namespace C968
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            partGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            partName = new DataGridViewTextBoxColumn();
            partInventory = new DataGridViewTextBoxColumn();
            partPrice = new DataGridViewTextBoxColumn();
            partMin = new DataGridViewTextBoxColumn();
            partMax = new DataGridViewTextBoxColumn();
            productGrid = new DataGridView();
            productID = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productInventory = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productMin = new DataGridViewTextBoxColumn();
            productMax = new DataGridViewTextBoxColumn();
            imsLabel = new Label();
            partsLabel = new Label();
            productsLabel = new Label();
            partsSearchButton = new Button();
            productsSearchButton = new Button();
            partsDeleteButton = new Button();
            partsModifyButton = new Button();
            partsAddButton = new Button();
            productsAddButton = new Button();
            productsModifyButton = new Button();
            productsDeleteButton = new Button();
            exitButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            partSearchTextBox = new TextBox();
            productsSearchBox = new TextBox();
            form1BindingSource = new BindingSource(components);
            PartID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)partGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // partGrid
            // 
            partGrid.AllowUserToAddRows = false;
            partGrid.AllowUserToDeleteRows = false;
            partGrid.AllowUserToResizeColumns = false;
            partGrid.AllowUserToResizeRows = false;
            partGrid.BackgroundColor = SystemColors.ActiveCaption;
            partGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, partName, partInventory, partPrice, partMin, partMax });
            partGrid.Location = new Point(24, 56);
            partGrid.MultiSelect = false;
            partGrid.Name = "partGrid";
            partGrid.RowHeadersVisible = false;
            partGrid.RowTemplate.Height = 25;
            partGrid.ScrollBars = ScrollBars.Vertical;
            partGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partGrid.Size = new Size(428, 239);
            partGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // partName
            // 
            partName.DataPropertyName = "Name";
            partName.HeaderText = "Name";
            partName.Name = "partName";
            partName.ReadOnly = true;
            // 
            // partInventory
            // 
            partInventory.DataPropertyName = "InStock";
            partInventory.HeaderText = "Inventory";
            partInventory.Name = "partInventory";
            partInventory.ReadOnly = true;
            partInventory.Width = 75;
            // 
            // partPrice
            // 
            partPrice.DataPropertyName = "Price";
            partPrice.HeaderText = "Price";
            partPrice.Name = "partPrice";
            partPrice.ReadOnly = true;
            partPrice.Width = 50;
            // 
            // partMin
            // 
            partMin.DataPropertyName = "Min";
            partMin.HeaderText = "Min";
            partMin.Name = "partMin";
            partMin.ReadOnly = true;
            partMin.Width = 50;
            // 
            // partMax
            // 
            partMax.DataPropertyName = "Max";
            partMax.HeaderText = "Max";
            partMax.Name = "partMax";
            partMax.ReadOnly = true;
            partMax.Width = 50;
            // 
            // productGrid
            // 
            productGrid.AllowUserToAddRows = false;
            productGrid.AllowUserToDeleteRows = false;
            productGrid.AllowUserToResizeColumns = false;
            productGrid.AllowUserToResizeRows = false;
            productGrid.BackgroundColor = SystemColors.ActiveCaption;
            productGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGrid.Columns.AddRange(new DataGridViewColumn[] { productID, productName, productInventory, productPrice, productMin, productMax });
            productGrid.Location = new Point(476, 56);
            productGrid.MultiSelect = false;
            productGrid.Name = "productGrid";
            productGrid.RowHeadersVisible = false;
            productGrid.RowTemplate.Height = 25;
            productGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productGrid.Size = new Size(428, 239);
            productGrid.TabIndex = 0;
            // 
            // productID
            // 
            productID.DataPropertyName = "ProductID";
            productID.HeaderText = "Product ID";
            productID.Name = "productID";
            productID.ReadOnly = true;
            // 
            // productName
            // 
            productName.DataPropertyName = "Name";
            productName.HeaderText = "Name";
            productName.Name = "productName";
            productName.ReadOnly = true;
            // 
            // productInventory
            // 
            productInventory.DataPropertyName = "InStock";
            productInventory.HeaderText = "Inventory";
            productInventory.Name = "productInventory";
            productInventory.ReadOnly = true;
            productInventory.Width = 75;
            // 
            // productPrice
            // 
            productPrice.DataPropertyName = "Price";
            productPrice.HeaderText = "Price";
            productPrice.Name = "productPrice";
            productPrice.ReadOnly = true;
            productPrice.Width = 50;
            // 
            // productMin
            // 
            productMin.DataPropertyName = "Min";
            productMin.HeaderText = "Min";
            productMin.Name = "productMin";
            productMin.ReadOnly = true;
            productMin.Width = 50;
            // 
            // productMax
            // 
            productMax.DataPropertyName = "Max";
            productMax.HeaderText = "Max";
            productMax.Name = "productMax";
            productMax.ReadOnly = true;
            productMax.Width = 50;
            // 
            // imsLabel
            // 
            imsLabel.AutoSize = true;
            imsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imsLabel.Location = new Point(340, 9);
            imsLabel.Name = "imsLabel";
            imsLabel.Size = new Size(250, 21);
            imsLabel.TabIndex = 2;
            imsLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            partsLabel.Location = new Point(204, 32);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(40, 19);
            partsLabel.TabIndex = 3;
            partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.BackColor = SystemColors.Control;
            productsLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productsLabel.Location = new Point(643, 32);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(63, 19);
            productsLabel.TabIndex = 4;
            productsLabel.Text = "Products";
            // 
            // partsSearchButton
            // 
            partsSearchButton.Location = new Point(24, 330);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(75, 23);
            partsSearchButton.TabIndex = 5;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = true;
            partsSearchButton.Click += partsSearch_Click;
            // 
            // productsSearchButton
            // 
            productsSearchButton.Location = new Point(476, 331);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(75, 23);
            productsSearchButton.TabIndex = 6;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = true;
            productsSearchButton.Click += productsSearch_Click;
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.Location = new Point(105, 360);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(75, 23);
            partsDeleteButton.TabIndex = 7;
            partsDeleteButton.Text = "Delete";
            partsDeleteButton.UseVisualStyleBackColor = true;
            partsDeleteButton.Click += partsDelete_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.Location = new Point(105, 331);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(75, 23);
            partsModifyButton.TabIndex = 8;
            partsModifyButton.Text = "Modify";
            partsModifyButton.UseVisualStyleBackColor = true;
            partsModifyButton.Click += partsModify_Click;
            // 
            // partsAddButton
            // 
            partsAddButton.Location = new Point(24, 359);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(75, 23);
            partsAddButton.TabIndex = 9;
            partsAddButton.Text = "Add";
            partsAddButton.UseVisualStyleBackColor = true;
            partsAddButton.Click += partsAdd_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.Location = new Point(476, 360);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(75, 23);
            productsAddButton.TabIndex = 12;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = true;
            productsAddButton.Click += productsAdd_Click;
            // 
            // productsModifyButton
            // 
            productsModifyButton.Location = new Point(557, 331);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(75, 23);
            productsModifyButton.TabIndex = 11;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = true;
            productsModifyButton.Click += productsModify_Click;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.Location = new Point(557, 360);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(75, 23);
            productsDeleteButton.TabIndex = 10;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = true;
            productsDeleteButton.Click += productsDelete_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(829, 377);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exit_Click;
            // 
            // partSearchTextBox
            // 
            partSearchTextBox.Location = new Point(24, 302);
            partSearchTextBox.Name = "partSearchTextBox";
            partSearchTextBox.Size = new Size(428, 23);
            partSearchTextBox.TabIndex = 14;
            // 
            // productsSearchBox
            // 
            productsSearchBox.Location = new Point(476, 302);
            productsSearchBox.Name = "productsSearchBox";
            productsSearchBox.Size = new Size(428, 23);
            productsSearchBox.TabIndex = 15;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(MainForm);
            // 
            // PartID
            // 
            PartID.DataPropertyName = "PartID";
            PartID.HeaderText = "Part ID";
            PartID.Name = "PartID";
            PartID.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 412);
            Controls.Add(productsSearchBox);
            Controls.Add(partSearchTextBox);
            Controls.Add(exitButton);
            Controls.Add(productsAddButton);
            Controls.Add(productsModifyButton);
            Controls.Add(productsDeleteButton);
            Controls.Add(partsAddButton);
            Controls.Add(partsModifyButton);
            Controls.Add(partsDeleteButton);
            Controls.Add(productsSearchButton);
            Controls.Add(partsSearchButton);
            Controls.Add(productsLabel);
            Controls.Add(partsLabel);
            Controls.Add(imsLabel);
            Controls.Add(productGrid);
            Controls.Add(partGrid);
            Name = "MainForm";
            Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)partGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partGrid;
        private DataGridView productGrid;
        private Label imsLabel;
        private Label partsLabel;
        private Label productsLabel;
        private Button partsSearchButton;
        private Button productsSearchButton;
        private Button partsDeleteButton;
        private Button partsModifyButton;
        private Button partsAddButton;
        private Button productsAddButton;
        private Button productsModifyButton;
        private Button productsDeleteButton;
        private Button exitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox partSearchTextBox;
        private TextBox productsSearchBox;
        private BindingSource form1BindingSource;
        private DataGridViewTextBoxColumn PartID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn partName;
        private DataGridViewTextBoxColumn partInventory;
        private DataGridViewTextBoxColumn partPrice;
        private DataGridViewTextBoxColumn partMin;
        private DataGridViewTextBoxColumn partMax;
        private DataGridViewTextBoxColumn productID;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productInventory;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productMin;
        private DataGridViewTextBoxColumn productMax;
    }
}