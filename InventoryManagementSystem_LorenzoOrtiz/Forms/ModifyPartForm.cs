using InventoryManagementSystem_LorenzoOrtiz.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    public partial class ModifyPartForm : Form
    {
        private MainScreenForm mainScreenForm;

        public ModifyPartForm(MainScreenForm form)
        {
            InitializeComponent();
            mainScreenForm = form;
        }

        private void ModifyPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartInHouseRadioButton.Checked)
            {
                modifyPartMachineIDLabel.Text = "Machine ID";
                modifyPartOutSourcedTextbox.Hide();
                modifyPartInHouseTextbox.Show();
            }
        }

        private void ModifyPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ModifyPartOutsourcedRadioButton.Checked)
            {
                modifyPartMachineIDLabel.Text = "Company Name";
                modifyPartInHouseTextbox.Hide();
                modifyPartOutSourcedTextbox.Show();
            }
        }

        private void ModifyPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool partIDBool = int.TryParse(modifyPartIDTextbox.Text, out int partID);
                string name = ModifyPartNameTextbox.Text;
                bool inStockBool = int.TryParse(modifyPartInventoryTextbox.Text, out int inStock);
                bool priceBool = decimal.TryParse(ModifyPartPriceCostTextBox.Text, out decimal price);
                bool maxBool = int.TryParse(ModifyPartMaxTextbox.Text, out int max);
                bool minBool = int.TryParse(ModifyPartMinTextbox.Text, out int min);

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

                if (ModifyPartInHouseRadioButton.Checked)
                {
                    if (int.TryParse(ModifyPartInHouseTextbox.Text, out int machineID))
                    {
                        InhousePart inHousePart = new InhousePart(name, inStock, price, max, min, machineID, partID);
                        Inventory.UpdatePart(partID, inHousePart);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid machine ID.");
                        return;
                    }
                }
                else if (ModifyPartOutsourcedRadioButton.Checked)
                {
                    string companyName = ModifyPartOutSourcedTextbox.Text;
                    if (string.IsNullOrEmpty(companyName) || int.TryParse(companyName, out _))
                    {
                        MessageBox.Show("Please enter a valid company name.");
                        return;
                    }
                    OutsourcedPart outSourcedPart = new OutsourcedPart(name, inStock, price, max, min, companyName, partID);
                    Inventory.UpdatePart(partID, outSourcedPart);
                }

                this.Close();
                mainScreenForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreenForm.Show();
        }

        // This section below changes the textbox colors if the checks fail and changes them back to white if they are valid.

        private void modifyPartNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartNameTextbox.Text) || int.TryParse(modifyPartNameTextbox.Text, out _))
            {
                modifyPartNameTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartNameTextbox.BackColor = Color.White;
            }
        }

        private void modifyPartInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyPartInventoryTextbox.Text, out _))
            {
                modifyPartInventoryTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartInventoryTextbox.BackColor = Color.White;
            }
        }

        private void modifyPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(modifyPartPriceCostTextBox.Text, out _))
            {
                modifyPartPriceCostTextBox.BackColor = Color.Red;
            }
            else
            {
                modifyPartPriceCostTextBox.BackColor = Color.White;
            }
        }

        private void modifyPartMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyPartMaxTextbox.Text, out _))
            {
                modifyPartMaxTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartMaxTextbox.BackColor = Color.White;
            }
        }

        private void modifyPartMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyPartMinTextbox.Text, out _))
            {
                modifyPartMinTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartMinTextbox.BackColor = Color.White;
            }
        }

        private void modifyPartInHouseTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(modifyPartInHouseTextbox.Text, out _))
            {
                modifyPartInHouseTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartInHouseTextbox.BackColor = Color.White;
            }
        }

        private void modifyPartOutSourcedTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modifyPartOutSourcedTextbox.Text) || int.TryParse(modifyPartOutSourcedTextbox.Text, out _))
            {
                modifyPartOutSourcedTextbox.BackColor = Color.Red;
            }
            else
            {
                modifyPartOutSourcedTextbox.BackColor = Color.White;
            }
        }
    }
}
