using InventoryManagementSystem_LorenzoOrtiz.Parts;
using InventoryManagementSystem_LorenzoOrtiz.Products;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    public partial class ModifyProductForm : Form
    {
        private MainScreenForm mainScreenForm;
        private Product ProductBeingModified;

        public ModifyProductForm(MainScreenForm form, Product productBeingModified)
        {
            InitializeComponent();
            mainScreenForm = form;
            ProductBeingModified = productBeingModified;
            InitializeModifyProductPartDGVSettings();
            InitializeModifyProductAssociatedPartDGVSettings();
            InitializeFormFields();
        }

        private void InitializeModifyProductPartDGVSettings()
        {
            // Modify Products All candidate Parts DGV Settings
            modifyProductDataGridViewAllCanidateParts.DataSource = Inventory.AllParts;
            modifyProductDataGridViewAllCanidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductDataGridViewAllCanidateParts.ReadOnly = true;
            modifyProductDataGridViewAllCanidateParts.MultiSelect = false;
            modifyProductDataGridViewAllCanidateParts.AllowUserToAddRows = false;
            modifyProductDataGridViewAllCanidateParts.RowHeadersVisible = false;
            modifyProductDataGridViewAllCanidateParts.AllowUserToResizeColumns = false;
            modifyProductDataGridViewAllCanidateParts.AllowUserToResizeRows = false;
        }

        private void InitializeModifyProductAssociatedPartDGVSettings()
        {
            // Modify Products Associated Parts DGV Settings
            modifyProductDataGridViewPartsAssociatedWithThisProduct.DataSource = ProductBeingModified.AssociatedParts;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.ReadOnly = true;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.MultiSelect = false;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToAddRows = false;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.RowHeadersVisible = false;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToResizeColumns = false;
            modifyProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToResizeRows = false;
        }

        private void InitializeFormFields()
        {
            // Initialize form fields with product values
            ModifyProductIDTextbox.Text = ProductBeingModified.ProductID.ToString();
            ModifyProductNameTextbox.Text = ProductBeingModified.Name;
            ModifyProductInventoryTextbox.Text = ProductBeingModified.InStock.ToString();
            ModifyProductPriceCostTextBox.Text = ProductBeingModified.Price.ToString();
            ModifyProductMaxTextbox.Text = ProductBeingModified.Max.ToString();
            ModifyProductMinTextbox.Text = ProductBeingModified.Min.ToString();
        }

        private void clearInitialSelectedRow(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyProductDataGridViewAllCanidateParts.ClearSelection();
            modifyProductDataGridViewPartsAssociatedWithThisProduct.ClearSelection();
        }

        private void modifyProductAddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)modifyProductDataGridViewAllCanidateParts.CurrentRow.DataBoundItem;

            // Add the selected part to the AssociatedParts of the existing Product instance
            ProductBeingModified.AddAssociatedPart(selectedPart);

            modifyProductDataGridViewPartsAssociatedWithThisProduct.Refresh();

        }


        private void modifyProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {

            if (modifyProductDataGridViewPartsAssociatedWithThisProduct.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = modifyProductDataGridViewPartsAssociatedWithThisProduct.SelectedRows[0];


                int partIDToRemove = (int)selectedRow.Cells["PartID"].Value;

                if (ConfirmDelete("Associated Part"))
                {
                    bool removed = ProductBeingModified.RemoveAssociatedPart(partIDToRemove);
                    if (removed)
                    {
                        MessageBox.Show($"Part with ID {partIDToRemove} removed successfully.");

                        modifyProductDataGridViewPartsAssociatedWithThisProduct.Refresh();
                    }
                    else
                    {

                        MessageBox.Show($"Part with ID {partIDToRemove} not found.");
                    }
                }
            }
            else
            {
                // Notify the user to select a row
                MessageBox.Show("Please select a associated part to delete.");
            }
        }

        private bool ConfirmDelete(string itemType)
        {
            string message = $"Are you sure you want to delete this {itemType}?";
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(modifyProductIDTextbox.Text);
                string name = ModifyProductNameTextbox.Text;
                bool inStockBool = int.TryParse(ModifyProductInventoryTextbox.Text, out int inStock);
                bool priceBool = decimal.TryParse(ModifyProductPriceCostTextBox.Text, out decimal price);
                bool maxBool = int.TryParse(ModifyProductMaxTextbox.Text, out int max);
                bool minBool = int.TryParse(ModifyProductMinTextbox.Text, out int min);

                if (string.IsNullOrEmpty(name) || int.TryParse(name, out _))
                {
                    MessageBox.Show("Please enter a valid name.");
                    return;
                }

                if (!inStockBool)
                {
                    MessageBox.Show("Please enter a valid inventory.");
                    return;
                }

                if (!priceBool)
                {
                    MessageBox.Show("Please enter a valid price.");
                    return;
                }

                if (!maxBool)
                {
                    MessageBox.Show("Please enter a valid max.");
                    return;
                }

                if (!minBool)
                {
                    MessageBox.Show("Please enter a valid min.");
                    return;
                }

                if (min > max)
                {
                    MessageBox.Show("Min cannot be greater than max.");
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory must be between minimum and maximum values.");
                    return;
                }

                Product updatedProduct = new Product(name, inStock, price, max, min, new BindingList<Part>(ProductBeingModified.AssociatedParts), productID);

                Inventory.UpdateProduct(ProductBeingModified.ProductID, updatedProduct);

                this.Close();
                mainScreenForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreenForm.Show();
        }

        private void modifyProductIDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyProductIDTextbox.Text, out _))
            {
                modifyProductIDTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyProductIDTextbox.BackColor = Color.White;
            }
        }

        private void modifyProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrEmpty(modifyProductNameTextbox.Text) || int.TryParse(modifyProductNameTextbox.Text, out number))
            {
                modifyProductNameTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyProductNameTextbox.BackColor = Color.White;
            }
        }

        private void modifyProductInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyProductInventoryTextbox.Text, out _))
            {
                modifyProductInventoryTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyProductInventoryTextbox.BackColor = Color.White;
            }
        }

        private void modifyProductPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(modifyProductPriceCostTextBox.Text, out _))
            {
                modifyProductPriceCostTextBox.BackColor = Color.Red;
            }
            else
            {
                modifyProductPriceCostTextBox.BackColor = Color.White;
            }
        }

        private void modifyProductMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyProductMaxTextbox.Text, out _))
            {
                modifyProductMaxTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyProductMaxTextbox.BackColor = Color.White;
            }
        }

        private void modifyProductMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyProductMinTextbox.Text, out _))
            {
                modifyProductMinTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyProductMinTextbox.BackColor = Color.White;
            }
        }
        private bool ConfirmDelete()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void modifyProductPartSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (modifyProductPartSearchTextbox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(modifyProductPartSearchTextbox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    modifyProductDataGridViewAllCanidateParts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Part not found.");
                modifyProductDataGridViewAllCanidateParts.DataSource = Inventory.AllParts;
            }
        }


    }
}
