using InventoryManagementSystem_LorenzoOrtiz.Parts;
using InventoryManagementSystem_LorenzoOrtiz.Products;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace InventoryManagementSystem_LorenzoOrtiz
{
    public partial class MainScreenForm : Form
    {

        public MainScreenForm()
        {
            InitializeComponent();
            InitializePartsDGV();
            InitializeProductsDGV();

        }

        private void InitializePartsDGV()
        {
            // Main Screen Parts DGV Settings

            mainScreenPartsDataGridView.DataSource = Inventory.AllParts;
            mainScreenPartsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainScreenPartsDataGridView.ReadOnly = true;
            mainScreenPartsDataGridView.MultiSelect = false;
            mainScreenPartsDataGridView.AllowUserToAddRows = false;
            mainScreenPartsDataGridView.RowHeadersVisible = false;
            mainScreenPartsDataGridView.AllowUserToResizeColumns = false;
            mainScreenPartsDataGridView.AllowUserToResizeRows = false;
        }

        private void InitializeProductsDGV()
        {
            // Main Screen Products DGV Settings

            mainScreenProductsDataGridView.DataSource = Inventory.Products;
            mainScreenProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mainScreenProductsDataGridView.ReadOnly = true;
            mainScreenProductsDataGridView.MultiSelect = false;
            mainScreenProductsDataGridView.AllowUserToAddRows = false;
            mainScreenProductsDataGridView.RowHeadersVisible = false;
            mainScreenProductsDataGridView.AllowUserToResizeColumns = false;
            mainScreenProductsDataGridView.AllowUserToResizeRows = false;
        }

        // Clear initial selection of row
        private void clearInitialSelectedRow(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            mainScreenProductsDataGridView.ClearSelection();
            mainScreenPartsDataGridView.ClearSelection();
        }

        // Add part buttion functionality
        private void mainScreenPartsAddButton_Click(object sender, EventArgs e)
        {
            var partsAddForm = new AddPartForm(this);
            this.Hide();
            partsAddForm.Show();
        }

        private void mainScreenPartsModifyButton_Click(object sender, EventArgs e)
        {
            var partsModifyForm = new ModifyPartForm(this);
            this.Hide();

            var partToModify = mainScreenPartsDataGridView.CurrentRow.DataBoundItem as Part;

            partsModifyForm.ModifyPartIDTextbox.Text = partToModify.PartID.ToString();
            partsModifyForm.ModifyPartNameTextbox.Text = partToModify.Name.ToString();
            partsModifyForm.ModifyPartInventoryTextbox.Text = partToModify.InStock.ToString();
            partsModifyForm.ModifyPartPriceCostTextBox.Text = partToModify.Price.ToString();
            partsModifyForm.ModifyPartMaxTextbox.Text = partToModify.Max.ToString();
            partsModifyForm.ModifyPartMinTextbox.Text = partToModify.Min.ToString();

            if (partToModify is InhousePart)
            {

                InhousePart inhousePart = (InhousePart)partToModify;
                partsModifyForm.ModifyPartInHouseTextbox.Text = inhousePart.MachineID.ToString();
                partsModifyForm.ModifyPartInHouseRadioButton.Checked = true; // Check the in-house radio button
            }
            else
            {
                OutsourcedPart outsourcedPart = (OutsourcedPart)partToModify;
                partsModifyForm.ModifyPartOutSourcedTextbox.Text = outsourcedPart.CompanyName;
                partsModifyForm.ModifyPartOutsourcedRadioButton.Checked = true; // Check the outsourced radio button

            }

            partsModifyForm.Show();
        }
        private void mainScreenPartsDeleteButton_Click(object sender, EventArgs e)
        {
            if (mainScreenPartsDataGridView.Rows.Count > 0)
            {
                var partToDelete = mainScreenPartsDataGridView.CurrentRow.DataBoundItem as Part;
                if (partToDelete != null)
                {
                    if (IsPartAssociatedWithProduct(partToDelete))
                    {
                        MessageBox.Show("Cannot delete a part that is associated with a product.");
                    }
                    else
                    {
                        if (ConfirmDelete("part"))
                        {
                            Inventory.DeletePart(partToDelete);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part to delete.");
                }
            }
            else
            {
                MessageBox.Show("Nothing to delete.");
            }
        }

        private void mainScreenProductsAddButton_Click(object sender, EventArgs e)
        {
            var productAddForm = new AddProductForm(this);
            this.Hide();
            productAddForm.Show();
        }

        private void mainScreenProductsModifyButton_Click(object sender, EventArgs e)
        {
            if (mainScreenProductsDataGridView.CurrentRow != null)
            {
                var productToModify = mainScreenProductsDataGridView.CurrentRow.DataBoundItem as Product;
                if (productToModify != null)
                {
                    var productModifyForm = new ModifyProductForm(this, productToModify);
                    this.Hide();
                    productModifyForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a product to modify.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }


        private void mainScreenProductsDeleteButton_Click(object sender, EventArgs e)
        {
            if (mainScreenProductsDataGridView.Rows.Count > 0)
            {
                var productToDelete = mainScreenProductsDataGridView.CurrentRow.DataBoundItem as Product;
                if (productToDelete != null)
                {
                    if (ConfirmDelete("product"))
                    {
                        Inventory.RemoveProduct(productToDelete.ProductID);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
            else
            {
                MessageBox.Show("Select a product to delete.");
            }
        }

        // Parts search functionality by creating a new list for the search and displaying that list on the datagrid view
        private void mainScreenPartsSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (mainScreenPartsSearchTextbox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(mainScreenPartsSearchTextbox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    mainScreenPartsDataGridView.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Part not found..");
                mainScreenPartsDataGridView.DataSource = Inventory.AllParts;
            }
        }

        // Products search functionality
        private void mainScreenProductsSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;
            if (mainScreenProductsSearchTextbox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(mainScreenProductsSearchTextbox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    mainScreenProductsDataGridView.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Product not found.");
                mainScreenProductsDataGridView.DataSource = Inventory.Products;
            }
        }

        private void mainScreenExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ConfirmDelete(string itemType)
        {
            string message = $"Are you sure you want to delete this {itemType}?";
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private bool IsPartAssociatedWithProduct(Part part)
        {
            foreach (var product in Inventory.Products)
            {
                if (product.AssociatedParts.Contains(part))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
