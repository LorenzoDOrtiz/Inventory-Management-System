namespace InventoryManagementSystem_LorenzoOrtiz
{
    partial class MainScreenForm
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
            this.components = new System.ComponentModel.Container();
            this.mainScreenPartsAddButton = new System.Windows.Forms.Button();
            this.mainScreenPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainScreenPartsModifyButton = new System.Windows.Forms.Button();
            this.mainScreenPartsDeleteButton = new System.Windows.Forms.Button();
            this.mainScreenPartsSearchButton = new System.Windows.Forms.Button();
            this.mainScreenPartsSearchTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainScreenPartsLabel = new System.Windows.Forms.Label();
            this.mainScreenLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainScreenProductsDeleteButton = new System.Windows.Forms.Button();
            this.mainScreenProductsModifyButton = new System.Windows.Forms.Button();
            this.mainScreenProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainScreenProductsAddButton = new System.Windows.Forms.Button();
            this.mainScreenExitButton = new System.Windows.Forms.Button();
            this.mainScreenProductsSearchTextbox = new System.Windows.Forms.TextBox();
            this.mainScreenProductsSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreenPartsAddButton
            // 
            this.mainScreenPartsAddButton.Location = new System.Drawing.Point(365, 384);
            this.mainScreenPartsAddButton.Name = "mainScreenPartsAddButton";
            this.mainScreenPartsAddButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenPartsAddButton.TabIndex = 0;
            this.mainScreenPartsAddButton.Text = "Add";
            this.mainScreenPartsAddButton.UseVisualStyleBackColor = true;
            this.mainScreenPartsAddButton.Click += new System.EventHandler(this.mainScreenPartsAddButton_Click);
            // 
            // mainScreenPartsDataGridView
            // 
            this.mainScreenPartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainScreenPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainScreenPartsDataGridView.EnableHeadersVisualStyles = false;
            this.mainScreenPartsDataGridView.Location = new System.Drawing.Point(25, 104);
            this.mainScreenPartsDataGridView.Name = "mainScreenPartsDataGridView";
            this.mainScreenPartsDataGridView.Size = new System.Drawing.Size(571, 274);
            this.mainScreenPartsDataGridView.TabIndex = 1;
            this.mainScreenPartsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearInitialSelectedRow);
            // 
            // mainScreenPartsModifyButton
            // 
            this.mainScreenPartsModifyButton.Location = new System.Drawing.Point(444, 384);
            this.mainScreenPartsModifyButton.Name = "mainScreenPartsModifyButton";
            this.mainScreenPartsModifyButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenPartsModifyButton.TabIndex = 3;
            this.mainScreenPartsModifyButton.Text = "Modify";
            this.mainScreenPartsModifyButton.UseVisualStyleBackColor = true;
            this.mainScreenPartsModifyButton.Click += new System.EventHandler(this.mainScreenPartsModifyButton_Click);
            // 
            // mainScreenPartsDeleteButton
            // 
            this.mainScreenPartsDeleteButton.Location = new System.Drawing.Point(523, 384);
            this.mainScreenPartsDeleteButton.Name = "mainScreenPartsDeleteButton";
            this.mainScreenPartsDeleteButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenPartsDeleteButton.TabIndex = 4;
            this.mainScreenPartsDeleteButton.Text = "Delete";
            this.mainScreenPartsDeleteButton.UseVisualStyleBackColor = true;
            this.mainScreenPartsDeleteButton.Click += new System.EventHandler(this.mainScreenPartsDeleteButton_Click);
            // 
            // mainScreenPartsSearchButton
            // 
            this.mainScreenPartsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainScreenPartsSearchButton.Location = new System.Drawing.Point(300, 62);
            this.mainScreenPartsSearchButton.Name = "mainScreenPartsSearchButton";
            this.mainScreenPartsSearchButton.Size = new System.Drawing.Size(73, 28);
            this.mainScreenPartsSearchButton.TabIndex = 5;
            this.mainScreenPartsSearchButton.Text = "Search";
            this.mainScreenPartsSearchButton.UseVisualStyleBackColor = true;
            this.mainScreenPartsSearchButton.Click += new System.EventHandler(this.mainScreenPartsSearchButton_Click);
            // 
            // mainScreenPartsSearchTextbox
            // 
            this.mainScreenPartsSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenPartsSearchTextbox.Location = new System.Drawing.Point(379, 62);
            this.mainScreenPartsSearchTextbox.Multiline = true;
            this.mainScreenPartsSearchTextbox.Name = "mainScreenPartsSearchTextbox";
            this.mainScreenPartsSearchTextbox.Size = new System.Drawing.Size(209, 36);
            this.mainScreenPartsSearchTextbox.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainScreenPartsLabel
            // 
            this.mainScreenPartsLabel.AutoSize = true;
            this.mainScreenPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenPartsLabel.Location = new System.Drawing.Point(21, 77);
            this.mainScreenPartsLabel.Name = "mainScreenPartsLabel";
            this.mainScreenPartsLabel.Size = new System.Drawing.Size(51, 24);
            this.mainScreenPartsLabel.TabIndex = 12;
            this.mainScreenPartsLabel.Text = "Parts";
            // 
            // mainScreenLabel
            // 
            this.mainScreenLabel.AutoSize = true;
            this.mainScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenLabel.Location = new System.Drawing.Point(1, 6);
            this.mainScreenLabel.Name = "mainScreenLabel";
            this.mainScreenLabel.Size = new System.Drawing.Size(308, 25);
            this.mainScreenLabel.TabIndex = 13;
            this.mainScreenLabel.Text = "Inventory Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Products";
            // 
            // mainScreenProductsDeleteButton
            // 
            this.mainScreenProductsDeleteButton.Location = new System.Drawing.Point(1141, 384);
            this.mainScreenProductsDeleteButton.Name = "mainScreenProductsDeleteButton";
            this.mainScreenProductsDeleteButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenProductsDeleteButton.TabIndex = 17;
            this.mainScreenProductsDeleteButton.Text = "Delete";
            this.mainScreenProductsDeleteButton.UseVisualStyleBackColor = true;
            this.mainScreenProductsDeleteButton.Click += new System.EventHandler(this.mainScreenProductsDeleteButton_Click);
            // 
            // mainScreenProductsModifyButton
            // 
            this.mainScreenProductsModifyButton.Location = new System.Drawing.Point(1046, 384);
            this.mainScreenProductsModifyButton.Name = "mainScreenProductsModifyButton";
            this.mainScreenProductsModifyButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenProductsModifyButton.TabIndex = 16;
            this.mainScreenProductsModifyButton.Text = "Modify";
            this.mainScreenProductsModifyButton.UseVisualStyleBackColor = true;
            this.mainScreenProductsModifyButton.Click += new System.EventHandler(this.mainScreenProductsModifyButton_Click);
            // 
            // mainScreenProductsDataGridView
            // 
            this.mainScreenProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainScreenProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainScreenProductsDataGridView.EnableHeadersVisualStyles = false;
            this.mainScreenProductsDataGridView.Location = new System.Drawing.Point(643, 105);
            this.mainScreenProductsDataGridView.Name = "mainScreenProductsDataGridView";
            this.mainScreenProductsDataGridView.Size = new System.Drawing.Size(571, 274);
            this.mainScreenProductsDataGridView.TabIndex = 15;
            this.mainScreenProductsDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.clearInitialSelectedRow);
            // 
            // mainScreenProductsAddButton
            // 
            this.mainScreenProductsAddButton.Location = new System.Drawing.Point(954, 384);
            this.mainScreenProductsAddButton.Name = "mainScreenProductsAddButton";
            this.mainScreenProductsAddButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenProductsAddButton.TabIndex = 14;
            this.mainScreenProductsAddButton.Text = "Add";
            this.mainScreenProductsAddButton.UseVisualStyleBackColor = true;
            this.mainScreenProductsAddButton.Click += new System.EventHandler(this.mainScreenProductsAddButton_Click);
            // 
            // mainScreenExitButton
            // 
            this.mainScreenExitButton.Location = new System.Drawing.Point(1141, 443);
            this.mainScreenExitButton.Name = "mainScreenExitButton";
            this.mainScreenExitButton.Size = new System.Drawing.Size(73, 40);
            this.mainScreenExitButton.TabIndex = 21;
            this.mainScreenExitButton.Text = "Exit";
            this.mainScreenExitButton.UseVisualStyleBackColor = true;
            this.mainScreenExitButton.Click += new System.EventHandler(this.mainScreenExitButton_Click);
            // 
            // mainScreenProductsSearchTextbox
            // 
            this.mainScreenProductsSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenProductsSearchTextbox.Location = new System.Drawing.Point(1005, 63);
            this.mainScreenProductsSearchTextbox.Multiline = true;
            this.mainScreenProductsSearchTextbox.Name = "mainScreenProductsSearchTextbox";
            this.mainScreenProductsSearchTextbox.Size = new System.Drawing.Size(209, 36);
            this.mainScreenProductsSearchTextbox.TabIndex = 23;
            // 
            // mainScreenProductsSearchButton
            // 
            this.mainScreenProductsSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainScreenProductsSearchButton.Location = new System.Drawing.Point(926, 62);
            this.mainScreenProductsSearchButton.Name = "mainScreenProductsSearchButton";
            this.mainScreenProductsSearchButton.Size = new System.Drawing.Size(73, 28);
            this.mainScreenProductsSearchButton.TabIndex = 22;
            this.mainScreenProductsSearchButton.Text = "Search";
            this.mainScreenProductsSearchButton.UseVisualStyleBackColor = true;
            this.mainScreenProductsSearchButton.Click += new System.EventHandler(this.mainScreenProductsSearchButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 514);
            this.Controls.Add(this.mainScreenProductsSearchTextbox);
            this.Controls.Add(this.mainScreenProductsSearchButton);
            this.Controls.Add(this.mainScreenExitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainScreenProductsDeleteButton);
            this.Controls.Add(this.mainScreenProductsModifyButton);
            this.Controls.Add(this.mainScreenProductsDataGridView);
            this.Controls.Add(this.mainScreenProductsAddButton);
            this.Controls.Add(this.mainScreenLabel);
            this.Controls.Add(this.mainScreenPartsLabel);
            this.Controls.Add(this.mainScreenPartsSearchTextbox);
            this.Controls.Add(this.mainScreenPartsSearchButton);
            this.Controls.Add(this.mainScreenPartsDeleteButton);
            this.Controls.Add(this.mainScreenPartsModifyButton);
            this.Controls.Add(this.mainScreenPartsDataGridView);
            this.Controls.Add(this.mainScreenPartsAddButton);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreenProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainScreenPartsAddButton;
        private System.Windows.Forms.DataGridView mainScreenPartsDataGridView;
        private System.Windows.Forms.Button mainScreenPartsModifyButton;
        private System.Windows.Forms.Button mainScreenPartsDeleteButton;
        private System.Windows.Forms.Button mainScreenPartsSearchButton;
        private System.Windows.Forms.TextBox mainScreenPartsSearchTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label mainScreenPartsLabel;
        private System.Windows.Forms.Label mainScreenLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mainScreenProductsDeleteButton;
        private System.Windows.Forms.Button mainScreenProductsModifyButton;
        private System.Windows.Forms.DataGridView mainScreenProductsDataGridView;
        private System.Windows.Forms.Button mainScreenProductsAddButton;
        private System.Windows.Forms.Button mainScreenExitButton;
        private System.Windows.Forms.TextBox mainScreenProductsSearchTextbox;
        private System.Windows.Forms.Button mainScreenProductsSearchButton;
    }
}

