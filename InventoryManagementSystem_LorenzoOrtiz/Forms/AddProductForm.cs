using InventoryManagementSystem_LorenzoOrtiz.Parts;
using InventoryManagementSystem_LorenzoOrtiz.Products;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    public partial class AddProductForm : Form
    {
        private MainScreenForm mainScreenForm;
        private BindingList<Part> associatedPartsList = new BindingList<Part>();


        public AddProductForm(MainScreenForm form)
        {
            InitializeComponent();
            mainScreenForm = form;
            addProductIDTextbox.Text = (Product.ProductCount + 1).ToString();
            InitializeAddProductPartDGVSettings();
            InitializeAddProductAssociatedPartDGVSettings();

        }

        private void InitializeAddProductPartDGVSettings()
        {
            // Add Products All canidate Parts DGV Settings
            addProductDataGridViewAllCanidateParts.DataSource = Inventory.AllParts;
            addProductDataGridViewAllCanidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductDataGridViewAllCanidateParts.ReadOnly = true;
            addProductDataGridViewAllCanidateParts.MultiSelect = false;
            addProductDataGridViewAllCanidateParts.AllowUserToAddRows = false;
            addProductDataGridViewAllCanidateParts.RowHeadersVisible = false;
            addProductDataGridViewAllCanidateParts.AllowUserToResizeColumns = false;
            addProductDataGridViewAllCanidateParts.AllowUserToResizeRows = false;


        }
        private void InitializeAddProductAssociatedPartDGVSettings()
        {
            // Add Products Associated Parts DGV Settings
            addProductDataGridViewPartsAssociatedWithThisProduct.DataSource = associatedPartsList;
            addProductDataGridViewPartsAssociatedWithThisProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductDataGridViewPartsAssociatedWithThisProduct.ReadOnly = true;
            addProductDataGridViewPartsAssociatedWithThisProduct.MultiSelect = false;
            addProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToAddRows = false;
            addProductDataGridViewPartsAssociatedWithThisProduct.RowHeadersVisible = false;
            addProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToResizeColumns = false;
            addProductDataGridViewPartsAssociatedWithThisProduct.AllowUserToResizeRows = false;

        }

        private void clearInitialSelectedRow(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductDataGridViewAllCanidateParts.ClearSelection();
            addProductDataGridViewPartsAssociatedWithThisProduct.ClearSelection();
        }
        private void addProductAddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            var selectedPart = (Part)addProductDataGridViewAllCanidateParts.CurrentRow.DataBoundItem;
            associatedPartsList.Add(selectedPart);
        }


        private void addProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {

            if (addProductDataGridViewPartsAssociatedWithThisProduct.Rows.Count > 0)
            {
                var selectedPart = (Part)addProductDataGridViewAllCanidateParts.CurrentRow.DataBoundItem;
                if (selectedPart != null)
                {
                    if (ConfirmDelete("Associated Part"))
                        associatedPartsList.Remove(selectedPart);
                }
                else
                {
                    MessageBox.Show("Please select an associated part to delete.");
                }
            }
            else
            {
                MessageBox.Show("Select a associated part to delete.");
            }



        }
        private bool ConfirmDelete(string itemType)
        {
            string message = $"Are you sure you want to delete this {itemType}?";
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Product.ProductCount;
                string name = addProductNameTextbox.Text;
                bool inStockBool = int.TryParse(addProductInventoryTextbox.Text, out int inStock);
                bool priceBool = decimal.TryParse(addProductPriceCostTextBox.Text, out decimal price);
                bool maxBool = int.TryParse(addProductMaxTextbox.Text, out int max);
                bool minBool = int.TryParse(addProductMinTextbox.Text, out int min);
                var associatedParts = associatedPartsList;

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

                Product newProduct = new Product(name, inStock, price, max, min, associatedParts);
                Inventory.AddProduct(newProduct);

                this.Close();
                mainScreenForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


        }
        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreenForm.Show();
        }

        // Visual validation checks
        private void addProductIDTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductIDTextbox.Text, out _))
            {
                addProductIDTextbox.BackColor = Color.Red;
            }
            else
            {
                addProductIDTextbox.BackColor = Color.White;
            }
        }

        private void addProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (string.IsNullOrEmpty(addProductNameTextbox.Text) || int.TryParse(addProductNameTextbox.Text, out number))
            {
                addProductNameTextbox.BackColor = Color.Red;
            }
            else
            {
                addProductNameTextbox.BackColor = Color.White;
            }
        }

        private void addProductInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductInventoryTextbox.Text, out _))
            {
                addProductInventoryTextbox.BackColor = Color.Red;
            }
            else
            {
                addProductInventoryTextbox.BackColor = Color.White;
            }
        }

        private void addProductPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(addProductPriceCostTextBox.Text, out _))
            {
                addProductPriceCostTextBox.BackColor = Color.Red;
            }
            else
            {
                addProductPriceCostTextBox.BackColor = Color.White;
            }
        }

        private void addProductMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductMaxTextbox.Text, out _))
            {
                addProductMaxTextbox.BackColor = Color.Red;
            }
            else
            {
                addProductMaxTextbox.BackColor = Color.White;
            }
        }

        private void addProductMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductMinTextbox.Text, out _))
            {
                addProductMinTextbox.BackColor = Color.Red;
            }
            else
            {
                addProductMinTextbox.BackColor = Color.White;
            }
        }

        private void addProductPartsSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (addProductPartsSearchTextbox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(addProductPartsSearchTextbox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    addProductDataGridViewAllCanidateParts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Part not found.");
                addProductDataGridViewAllCanidateParts.DataSource = Inventory.AllParts;
            }
        }
    }
}
