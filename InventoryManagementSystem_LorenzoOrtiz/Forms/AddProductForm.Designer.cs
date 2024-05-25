namespace InventoryManagementSystem_LorenzoOrtiz
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.addProductMinTextbox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextbox = new System.Windows.Forms.TextBox();
            this.addProductPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextbox = new System.Windows.Forms.TextBox();
            this.addProductNameTextbox = new System.Windows.Forms.TextBox();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductIDTextbox = new System.Windows.Forms.TextBox();
            this.addProductMinLabel = new System.Windows.Forms.Label();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductPriceCostLabel = new System.Windows.Forms.Label();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductIDLabel = new System.Windows.Forms.Label();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.addProductDeleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.addProductDataGridViewAllCanidateParts = new System.Windows.Forms.DataGridView();
            this.addProductDataGridViewPartsAssociatedWithThisProduct = new System.Windows.Forms.DataGridView();
            this.addProductAddAssociatedPartButton = new System.Windows.Forms.Button();
            this.addProductAllCanidatePartsLabel = new System.Windows.Forms.Label();
            this.addProductPartsAssociatedWithThisProductLabel = new System.Windows.Forms.Label();
            this.addProductPartsSearchTextbox = new System.Windows.Forms.TextBox();
            this.addProductPartsSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProductDataGridViewAllCanidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductDataGridViewPartsAssociatedWithThisProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductMinTextbox
            // 
            this.addProductMinTextbox.Location = new System.Drawing.Point(298, 383);
            this.addProductMinTextbox.Multiline = true;
            this.addProductMinTextbox.Name = "addProductMinTextbox";
            this.addProductMinTextbox.Size = new System.Drawing.Size(77, 29);
            this.addProductMinTextbox.TabIndex = 5;
            this.addProductMinTextbox.TextChanged += new System.EventHandler(this.addProductMinTextbox_TextChanged);
            // 
            // addProductMaxTextbox
            // 
            this.addProductMaxTextbox.Location = new System.Drawing.Point(171, 383);
            this.addProductMaxTextbox.Multiline = true;
            this.addProductMaxTextbox.Name = "addProductMaxTextbox";
            this.addProductMaxTextbox.Size = new System.Drawing.Size(77, 29);
            this.addProductMaxTextbox.TabIndex = 4;
            this.addProductMaxTextbox.TextChanged += new System.EventHandler(this.addProductMaxTextbox_TextChanged);
            // 
            // addProductPriceCostTextBox
            // 
            this.addProductPriceCostTextBox.Location = new System.Drawing.Point(171, 340);
            this.addProductPriceCostTextBox.Multiline = true;
            this.addProductPriceCostTextBox.Name = "addProductPriceCostTextBox";
            this.addProductPriceCostTextBox.Size = new System.Drawing.Size(146, 29);
            this.addProductPriceCostTextBox.TabIndex = 3;
            this.addProductPriceCostTextBox.TextChanged += new System.EventHandler(this.addProductPriceCostTextBox_TextChanged);
            // 
            // addProductInventoryTextbox
            // 
            this.addProductInventoryTextbox.Location = new System.Drawing.Point(171, 290);
            this.addProductInventoryTextbox.Multiline = true;
            this.addProductInventoryTextbox.Name = "addProductInventoryTextbox";
            this.addProductInventoryTextbox.Size = new System.Drawing.Size(146, 29);
            this.addProductInventoryTextbox.TabIndex = 2;
            this.addProductInventoryTextbox.TextChanged += new System.EventHandler(this.addProductInventoryTextbox_TextChanged);
            // 
            // addProductNameTextbox
            // 
            this.addProductNameTextbox.Location = new System.Drawing.Point(171, 241);
            this.addProductNameTextbox.Multiline = true;
            this.addProductNameTextbox.Name = "addProductNameTextbox";
            this.addProductNameTextbox.Size = new System.Drawing.Size(146, 29);
            this.addProductNameTextbox.TabIndex = 1;
            this.addProductNameTextbox.TextChanged += new System.EventHandler(this.addProductNameTextbox_TextChanged);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Location = new System.Drawing.Point(936, 577);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(75, 23);
            this.addProductCancelButton.TabIndex = 33;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Location = new System.Drawing.Point(841, 577);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProductSaveButton.TabIndex = 32;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductIDTextbox
            // 
            this.addProductIDTextbox.Enabled = false;
            this.addProductIDTextbox.Location = new System.Drawing.Point(171, 190);
            this.addProductIDTextbox.Multiline = true;
            this.addProductIDTextbox.Name = "addProductIDTextbox";
            this.addProductIDTextbox.Size = new System.Drawing.Size(146, 29);
            this.addProductIDTextbox.TabIndex = 0;
            this.addProductIDTextbox.TextChanged += new System.EventHandler(this.addProductIDTextbox_TextChanged);
            // 
            // addProductMinLabel
            // 
            this.addProductMinLabel.AutoSize = true;
            this.addProductMinLabel.Location = new System.Drawing.Point(260, 389);
            this.addProductMinLabel.Name = "addProductMinLabel";
            this.addProductMinLabel.Size = new System.Drawing.Size(24, 13);
            this.addProductMinLabel.TabIndex = 30;
            this.addProductMinLabel.Text = "Min";
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Location = new System.Drawing.Point(111, 389);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.addProductMaxLabel.TabIndex = 29;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductPriceCostLabel
            // 
            this.addProductPriceCostLabel.AutoSize = true;
            this.addProductPriceCostLabel.Location = new System.Drawing.Point(81, 343);
            this.addProductPriceCostLabel.Name = "addProductPriceCostLabel";
            this.addProductPriceCostLabel.Size = new System.Drawing.Size(57, 13);
            this.addProductPriceCostLabel.TabIndex = 28;
            this.addProductPriceCostLabel.Text = "Price/Cost";
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Location = new System.Drawing.Point(87, 293);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.addProductInventoryLabel.TabIndex = 27;
            this.addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Location = new System.Drawing.Point(103, 244);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addProductNameLabel.TabIndex = 26;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductIDLabel
            // 
            this.addProductIDLabel.AutoSize = true;
            this.addProductIDLabel.Location = new System.Drawing.Point(120, 193);
            this.addProductIDLabel.Name = "addProductIDLabel";
            this.addProductIDLabel.Size = new System.Drawing.Size(18, 13);
            this.addProductIDLabel.TabIndex = 25;
            this.addProductIDLabel.Text = "ID";
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabel.Location = new System.Drawing.Point(21, 20);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(81, 16);
            this.addProductLabel.TabIndex = 24;
            this.addProductLabel.Text = "Add Product";
            // 
            // addProductDeleteAssociatedPartButton
            // 
            this.addProductDeleteAssociatedPartButton.Location = new System.Drawing.Point(936, 529);
            this.addProductDeleteAssociatedPartButton.Name = "addProductDeleteAssociatedPartButton";
            this.addProductDeleteAssociatedPartButton.Size = new System.Drawing.Size(75, 23);
            this.addProductDeleteAssociatedPartButton.TabIndex = 39;
            this.addProductDeleteAssociatedPartButton.Text = "Delete";
            this.addProductDeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.addProductDeleteAssociatedPartButton.Click += new System.EventHandler(this.addProductDeleteAssociatedPartButton_Click);
            // 
            // addProductDataGridViewAllCanidateParts
            // 
            this.addProductDataGridViewAllCanidateParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductDataGridViewAllCanidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductDataGridViewAllCanidateParts.EnableHeadersVisualStyles = false;
            this.addProductDataGridViewAllCanidateParts.Location = new System.Drawing.Point(445, 90);
            this.addProductDataGridViewAllCanidateParts.Name = "addProductDataGridViewAllCanidateParts";
            this.addProductDataGridViewAllCanidateParts.Size = new System.Drawing.Size(575, 191);
            this.addProductDataGridViewAllCanidateParts.TabIndex = 40;
            this.addProductDataGridViewAllCanidateParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearInitialSelectedRow);
            // 
            // addProductDataGridViewPartsAssociatedWithThisProduct
            // 
            this.addProductDataGridViewPartsAssociatedWithThisProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductDataGridViewPartsAssociatedWithThisProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductDataGridViewPartsAssociatedWithThisProduct.EnableHeadersVisualStyles = false;
            this.addProductDataGridViewPartsAssociatedWithThisProduct.Location = new System.Drawing.Point(445, 332);
            this.addProductDataGridViewPartsAssociatedWithThisProduct.Name = "addProductDataGridViewPartsAssociatedWithThisProduct";
            this.addProductDataGridViewPartsAssociatedWithThisProduct.Size = new System.Drawing.Size(575, 191);
            this.addProductDataGridViewPartsAssociatedWithThisProduct.TabIndex = 41;
            this.addProductDataGridViewPartsAssociatedWithThisProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearInitialSelectedRow);
            // 
            // addProductAddAssociatedPartButton
            // 
            this.addProductAddAssociatedPartButton.Location = new System.Drawing.Point(936, 296);
            this.addProductAddAssociatedPartButton.Name = "addProductAddAssociatedPartButton";
            this.addProductAddAssociatedPartButton.Size = new System.Drawing.Size(75, 23);
            this.addProductAddAssociatedPartButton.TabIndex = 42;
            this.addProductAddAssociatedPartButton.Text = "Add";
            this.addProductAddAssociatedPartButton.UseVisualStyleBackColor = true;
            this.addProductAddAssociatedPartButton.Click += new System.EventHandler(this.addProductAddAssociatedPartButton_Click);
            // 
            // addProductAllCanidatePartsLabel
            // 
            this.addProductAllCanidatePartsLabel.AutoSize = true;
            this.addProductAllCanidatePartsLabel.Location = new System.Drawing.Point(442, 63);
            this.addProductAllCanidatePartsLabel.Name = "addProductAllCanidatePartsLabel";
            this.addProductAllCanidatePartsLabel.Size = new System.Drawing.Size(89, 13);
            this.addProductAllCanidatePartsLabel.TabIndex = 43;
            this.addProductAllCanidatePartsLabel.Text = "All canidate Parts";
            // 
            // addProductPartsAssociatedWithThisProductLabel
            // 
            this.addProductPartsAssociatedWithThisProductLabel.AutoSize = true;
            this.addProductPartsAssociatedWithThisProductLabel.Location = new System.Drawing.Point(442, 306);
            this.addProductPartsAssociatedWithThisProductLabel.Name = "addProductPartsAssociatedWithThisProductLabel";
            this.addProductPartsAssociatedWithThisProductLabel.Size = new System.Drawing.Size(167, 13);
            this.addProductPartsAssociatedWithThisProductLabel.TabIndex = 44;
            this.addProductPartsAssociatedWithThisProductLabel.Text = "Parts Associated with this Product";
            // 
            // addProductPartsSearchTextbox
            // 
            this.addProductPartsSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPartsSearchTextbox.Location = new System.Drawing.Point(811, 48);
            this.addProductPartsSearchTextbox.Multiline = true;
            this.addProductPartsSearchTextbox.Name = "addProductPartsSearchTextbox";
            this.addProductPartsSearchTextbox.Size = new System.Drawing.Size(209, 36);
            this.addProductPartsSearchTextbox.TabIndex = 46;
            // 
            // addProductPartsSearchButton
            // 
            this.addProductPartsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addProductPartsSearchButton.Location = new System.Drawing.Point(732, 48);
            this.addProductPartsSearchButton.Name = "addProductPartsSearchButton";
            this.addProductPartsSearchButton.Size = new System.Drawing.Size(73, 28);
            this.addProductPartsSearchButton.TabIndex = 45;
            this.addProductPartsSearchButton.Text = "Search";
            this.addProductPartsSearchButton.UseVisualStyleBackColor = true;
            this.addProductPartsSearchButton.Click += new System.EventHandler(this.addProductPartsSearchButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 617);
            this.Controls.Add(this.addProductPartsSearchTextbox);
            this.Controls.Add(this.addProductPartsSearchButton);
            this.Controls.Add(this.addProductPartsAssociatedWithThisProductLabel);
            this.Controls.Add(this.addProductAllCanidatePartsLabel);
            this.Controls.Add(this.addProductAddAssociatedPartButton);
            this.Controls.Add(this.addProductDataGridViewPartsAssociatedWithThisProduct);
            this.Controls.Add(this.addProductDataGridViewAllCanidateParts);
            this.Controls.Add(this.addProductDeleteAssociatedPartButton);
            this.Controls.Add(this.addProductMinTextbox);
            this.Controls.Add(this.addProductMaxTextbox);
            this.Controls.Add(this.addProductPriceCostTextBox);
            this.Controls.Add(this.addProductInventoryTextbox);
            this.Controls.Add(this.addProductNameTextbox);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.addProductIDTextbox);
            this.Controls.Add(this.addProductMinLabel);
            this.Controls.Add(this.addProductMaxLabel);
            this.Controls.Add(this.addProductPriceCostLabel);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductIDLabel);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProductForm";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.addProductDataGridViewAllCanidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductDataGridViewPartsAssociatedWithThisProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProductMinTextbox;
        private System.Windows.Forms.TextBox addProductMaxTextbox;
        private System.Windows.Forms.TextBox addProductPriceCostTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextbox;
        private System.Windows.Forms.TextBox addProductNameTextbox;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.TextBox addProductIDTextbox;
        private System.Windows.Forms.Label addProductMinLabel;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.Label addProductPriceCostLabel;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Label addProductIDLabel;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button addProductDeleteAssociatedPartButton;
        private System.Windows.Forms.DataGridView addProductDataGridViewAllCanidateParts;
        private System.Windows.Forms.DataGridView addProductDataGridViewPartsAssociatedWithThisProduct;
        private System.Windows.Forms.Button addProductAddAssociatedPartButton;
        private System.Windows.Forms.Label addProductAllCanidatePartsLabel;
        private System.Windows.Forms.Label addProductPartsAssociatedWithThisProductLabel;
        private System.Windows.Forms.TextBox addProductPartsSearchTextbox;
        private System.Windows.Forms.Button addProductPartsSearchButton;
    }
}