using InventoryManagementSystem_LorenzoOrtiz.Products;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    partial class ModifyPartForm
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
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.modifyPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.modifyPartIDLabel = new System.Windows.Forms.Label();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPartPriceCostLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartMachineIDLabel = new System.Windows.Forms.Label();
            this.modifyPartIDTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartSaveButton = new System.Windows.Forms.Button();
            this.modifyPartCancelButton = new System.Windows.Forms.Button();
            this.modifyPartNameTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartInventoryTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMaxTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartMinTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartInHouseTextbox = new System.Windows.Forms.TextBox();
            this.modifyPartOutSourcedTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 13);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(60, 13);
            this.modifyPartLabel.TabIndex = 0;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // modifyPartInHouseRadioButton
            // 
            this.modifyPartInHouseRadioButton.AutoSize = true;
            this.modifyPartInHouseRadioButton.Location = new System.Drawing.Point(91, 13);
            this.modifyPartInHouseRadioButton.Name = "modifyPartInHouseRadioButton";
            this.modifyPartInHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.modifyPartInHouseRadioButton.TabIndex = 1;
            this.modifyPartInHouseRadioButton.Text = "In-House";
            this.modifyPartInHouseRadioButton.UseVisualStyleBackColor = true;
            this.modifyPartInHouseRadioButton.CheckedChanged += new System.EventHandler(this.ModifyPartInHouseRadioButton_CheckedChanged);
            // 
            // modifyPartOutsourcedRadioButton
            // 
            this.modifyPartOutsourcedRadioButton.AutoSize = true;
            this.modifyPartOutsourcedRadioButton.Location = new System.Drawing.Point(177, 13);
            this.modifyPartOutsourcedRadioButton.Name = "modifyPartOutsourcedRadioButton";
            this.modifyPartOutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.modifyPartOutsourcedRadioButton.TabIndex = 2;
            this.modifyPartOutsourcedRadioButton.Text = "Outsourced";
            this.modifyPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.modifyPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.ModifyPartOutsourcedRadioButton_CheckedChanged);
            // 
            // modifyPartIDLabel
            // 
            this.modifyPartIDLabel.AutoSize = true;
            this.modifyPartIDLabel.Location = new System.Drawing.Point(88, 65);
            this.modifyPartIDLabel.Name = "modifyPartIDLabel";
            this.modifyPartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.modifyPartIDLabel.TabIndex = 3;
            this.modifyPartIDLabel.Text = "ID";
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.Location = new System.Drawing.Point(71, 116);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modifyPartNameLabel.TabIndex = 4;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartInventoryLabel
            // 
            this.modifyPartInventoryLabel.AutoSize = true;
            this.modifyPartInventoryLabel.Location = new System.Drawing.Point(55, 165);
            this.modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            this.modifyPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.modifyPartInventoryLabel.TabIndex = 5;
            this.modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartPriceCostLabel
            // 
            this.modifyPartPriceCostLabel.AutoSize = true;
            this.modifyPartPriceCostLabel.Location = new System.Drawing.Point(49, 215);
            this.modifyPartPriceCostLabel.Name = "modifyPartPriceCostLabel";
            this.modifyPartPriceCostLabel.Size = new System.Drawing.Size(57, 13);
            this.modifyPartPriceCostLabel.TabIndex = 6;
            this.modifyPartPriceCostLabel.Text = "Price/Cost";
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(79, 261);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modifyPartMaxLabel.TabIndex = 7;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.Location = new System.Drawing.Point(228, 261);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modifyPartMinLabel.TabIndex = 8;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMachineIDLabel
            // 
            this.modifyPartMachineIDLabel.AutoSize = true;
            this.modifyPartMachineIDLabel.Location = new System.Drawing.Point(49, 310);
            this.modifyPartMachineIDLabel.Name = "modifyPartMachineIDLabel";
            this.modifyPartMachineIDLabel.Size = new System.Drawing.Size(62, 13);
            this.modifyPartMachineIDLabel.TabIndex = 9;
            this.modifyPartMachineIDLabel.Text = "Machine ID";
            // 
            // modifyPartIDTextbox
            // 
            this.modifyPartIDTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.modifyPartIDTextbox.Enabled = false;
            this.modifyPartIDTextbox.Location = new System.Drawing.Point(139, 62);
            this.modifyPartIDTextbox.Multiline = true;
            this.modifyPartIDTextbox.Name = "modifyPartIDTextbox";
            this.modifyPartIDTextbox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartIDTextbox.TabIndex = 0;
            // 
            // modifyPartSaveButton
            // 
            this.modifyPartSaveButton.Location = new System.Drawing.Point(177, 361);
            this.modifyPartSaveButton.Name = "modifyPartSaveButton";
            this.modifyPartSaveButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartSaveButton.TabIndex = 17;
            this.modifyPartSaveButton.Text = "Save";
            this.modifyPartSaveButton.UseVisualStyleBackColor = true;
            this.modifyPartSaveButton.Click += new System.EventHandler(this.ModifyPartSaveButton_Click);
            // 
            // modifyPartCancelButton
            // 
            this.modifyPartCancelButton.Location = new System.Drawing.Point(268, 361);
            this.modifyPartCancelButton.Name = "modifyPartCancelButton";
            this.modifyPartCancelButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartCancelButton.TabIndex = 18;
            this.modifyPartCancelButton.Text = "Cancel";
            this.modifyPartCancelButton.UseVisualStyleBackColor = true;
            this.modifyPartCancelButton.Click += new System.EventHandler(this.ModifyPartCancelButton_Click);
            // 
            // modifyPartNameTextbox
            // 
            this.modifyPartNameTextbox.Location = new System.Drawing.Point(139, 113);
            this.modifyPartNameTextbox.Multiline = true;
            this.modifyPartNameTextbox.Name = "modifyPartNameTextbox";
            this.modifyPartNameTextbox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartNameTextbox.TabIndex = 1;
            this.modifyPartNameTextbox.TextChanged += new System.EventHandler(this.modifyPartNameTextbox_TextChanged);
            // 
            // modifyPartInventoryTextbox
            // 
            this.modifyPartInventoryTextbox.Location = new System.Drawing.Point(139, 162);
            this.modifyPartInventoryTextbox.Multiline = true;
            this.modifyPartInventoryTextbox.Name = "modifyPartInventoryTextbox";
            this.modifyPartInventoryTextbox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartInventoryTextbox.TabIndex = 2;
            this.modifyPartInventoryTextbox.TextChanged += new System.EventHandler(this.modifyPartInventoryTextbox_TextChanged);
            // 
            // modifyPartPriceCostTextBox
            // 
            this.modifyPartPriceCostTextBox.Location = new System.Drawing.Point(139, 212);
            this.modifyPartPriceCostTextBox.Multiline = true;
            this.modifyPartPriceCostTextBox.Name = "modifyPartPriceCostTextBox";
            this.modifyPartPriceCostTextBox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartPriceCostTextBox.TabIndex = 3;
            this.modifyPartPriceCostTextBox.TextChanged += new System.EventHandler(this.modifyPartPriceCostTextBox_TextChanged);
            // 
            // modifyPartMaxTextbox
            // 
            this.modifyPartMaxTextbox.Location = new System.Drawing.Point(139, 255);
            this.modifyPartMaxTextbox.Multiline = true;
            this.modifyPartMaxTextbox.Name = "modifyPartMaxTextbox";
            this.modifyPartMaxTextbox.Size = new System.Drawing.Size(77, 29);
            this.modifyPartMaxTextbox.TabIndex = 4;
            this.modifyPartMaxTextbox.TextChanged += new System.EventHandler(this.modifyPartMaxTextbox_TextChanged);
            // 
            // modifyPartMinTextbox
            // 
            this.modifyPartMinTextbox.Location = new System.Drawing.Point(266, 255);
            this.modifyPartMinTextbox.Multiline = true;
            this.modifyPartMinTextbox.Name = "modifyPartMinTextbox";
            this.modifyPartMinTextbox.Size = new System.Drawing.Size(77, 29);
            this.modifyPartMinTextbox.TabIndex = 5;
            this.modifyPartMinTextbox.TextChanged += new System.EventHandler(this.modifyPartMinTextbox_TextChanged);
            // 
            // modifyPartInHouseTextbox
            // 
            this.modifyPartInHouseTextbox.Location = new System.Drawing.Point(139, 310);
            this.modifyPartInHouseTextbox.Multiline = true;
            this.modifyPartInHouseTextbox.Name = "modifyPartInHouseTextbox";
            this.modifyPartInHouseTextbox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartInHouseTextbox.TabIndex = 7;
            this.modifyPartInHouseTextbox.TextChanged += new System.EventHandler(this.modifyPartInHouseTextbox_TextChanged);
            // 
            // modifyPartOutSourcedTextbox
            // 
            this.modifyPartOutSourcedTextbox.Location = new System.Drawing.Point(139, 310);
            this.modifyPartOutSourcedTextbox.Multiline = true;
            this.modifyPartOutSourcedTextbox.Name = "modifyPartOutSourcedTextbox";
            this.modifyPartOutSourcedTextbox.Size = new System.Drawing.Size(146, 29);
            this.modifyPartOutSourcedTextbox.TabIndex = 6;
            this.modifyPartOutSourcedTextbox.TextChanged += new System.EventHandler(this.modifyPartOutSourcedTextbox_TextChanged);
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 424);
            this.Controls.Add(this.modifyPartOutSourcedTextbox);
            this.Controls.Add(this.modifyPartInHouseRadioButton);
            this.Controls.Add(this.modifyPartOutsourcedRadioButton);
            this.Controls.Add(this.modifyPartInHouseTextbox);
            this.Controls.Add(this.modifyPartMinTextbox);
            this.Controls.Add(this.modifyPartMaxTextbox);
            this.Controls.Add(this.modifyPartPriceCostTextBox);
            this.Controls.Add(this.modifyPartInventoryTextbox);
            this.Controls.Add(this.modifyPartNameTextbox);
            this.Controls.Add(this.modifyPartCancelButton);
            this.Controls.Add(this.modifyPartSaveButton);
            this.Controls.Add(this.modifyPartIDTextbox);
            this.Controls.Add(this.modifyPartMachineIDLabel);
            this.Controls.Add(this.modifyPartMinLabel);
            this.Controls.Add(this.modifyPartMaxLabel);
            this.Controls.Add(this.modifyPartPriceCostLabel);
            this.Controls.Add(this.modifyPartInventoryLabel);
            this.Controls.Add(this.modifyPartNameLabel);
            this.Controls.Add(this.modifyPartIDLabel);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "ModifyPartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // public property so I can access these for modify form without changing their access levels. Auto property wasn't getting the instance
        // of the form for some reason, not sure why. 
        public System.Windows.Forms.TextBox ModifyPartIDTextbox
        {
            get { return modifyPartIDTextbox; }
            set { modifyPartIDTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartNameTextbox
        {
            get { return modifyPartNameTextbox; }
            set { modifyPartNameTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartInventoryTextbox
        {
            get { return modifyPartInventoryTextbox; }
            set { modifyPartInventoryTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartPriceCostTextBox
        {
            get { return modifyPartPriceCostTextBox; }
            set { modifyPartPriceCostTextBox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartMaxTextbox
        {
            get { return modifyPartMaxTextbox; }
            set { modifyPartMaxTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartMinTextbox
        {
            get { return modifyPartMinTextbox; }
            set { modifyPartMinTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartInHouseTextbox
        {
            get { return modifyPartInHouseTextbox; }
            set { modifyPartInHouseTextbox = value; }
        }
        public System.Windows.Forms.TextBox ModifyPartOutSourcedTextbox
        {
            get { return modifyPartOutSourcedTextbox; }
            set { modifyPartOutSourcedTextbox = value; }
        }
        public System.Windows.Forms.RadioButton ModifyPartInHouseRadioButton
        {
            get { return modifyPartInHouseRadioButton; }
            set { modifyPartInHouseRadioButton = value; }
        }
        public System.Windows.Forms.RadioButton ModifyPartOutsourcedRadioButton
        {
            get { return modifyPartOutsourcedRadioButton; }
            set { modifyPartOutsourcedRadioButton = value; }
        }
        


        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.RadioButton modifyPartOutsourcedRadioButton;
        private System.Windows.Forms.Label modifyPartIDLabel;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.Label modifyPartInventoryLabel;
        private System.Windows.Forms.Label modifyPartPriceCostLabel;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.Label modifyPartMachineIDLabel;
        private System.Windows.Forms.TextBox modifyPartIDTextbox;
        private System.Windows.Forms.Button modifyPartSaveButton;
        private System.Windows.Forms.Button modifyPartCancelButton;
        private System.Windows.Forms.TextBox modifyPartNameTextbox;
        private System.Windows.Forms.TextBox modifyPartInventoryTextbox;
        private System.Windows.Forms.TextBox modifyPartPriceCostTextBox;
        private System.Windows.Forms.TextBox modifyPartMaxTextbox;
        private System.Windows.Forms.TextBox modifyPartMinTextbox;
        private System.Windows.Forms.TextBox modifyPartInHouseTextbox;
        private System.Windows.Forms.RadioButton modifyPartInHouseRadioButton;
        private System.Windows.Forms.TextBox modifyPartOutSourcedTextbox;
    }
}