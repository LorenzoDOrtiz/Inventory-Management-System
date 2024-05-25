using InventoryManagementSystem_LorenzoOrtiz.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    public partial class AddPartForm : Form
    {
        private MainScreenForm mainScreenForm;

        public AddPartForm(MainScreenForm form)
        {
            InitializeComponent();
            mainScreenForm = form;
            // Start with inhouse radio button checked to make it easier if that's what you want to add
            addPartInHouseRadioButton.Checked = true;
            // Set the ID textbox to the next available ID
            addPartIDTextbox.Text = (Part.PartCount + 1).ToString();
        }

        private void addPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addPartInHouseRadioButton.Checked)
            {
                addPartMachineIDLabel.Text = "Machine ID";
                addPartRadioTextbox.BackColor = Color.White;
            }
            else
            {
                addPartMachineIDLabel.Text = "Company Name";
                addPartRadioTextbox.BackColor = Color.White;
            }
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partID = Part.PartCount + 1;
                string name = addPartNameTextbox.Text;
                bool inStockBool = int.TryParse(addPartInventoryTextbox.Text, out int inStock);
                bool priceBool = decimal.TryParse(addPartPriceCostTextBox.Text, out decimal price);
                bool maxBool = int.TryParse(addPartMaxTextbox.Text, out int max);
                bool minBool = int.TryParse(addPartMinTextbox.Text, out int min);

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

                if (addPartInHouseRadioButton.Checked)
                {
                    if (int.TryParse(addPartRadioTextbox.Text, out int machineID))
                    {
                        InhousePart inHousePart = new InhousePart(name, inStock, price, max, min, machineID, partID);
                        Inventory.AddPart(inHousePart);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid machine ID.");
                        return;
                    }
                }
                else if (addPartOutsourcedRadioButton.Checked)
                {
                    string companyName = addPartRadioTextbox.Text;
                    if (string.IsNullOrEmpty(companyName) || int.TryParse(companyName, out _))
                    {
                        MessageBox.Show("Please enter a valid company name.");
                        return;
                    }
                    OutsourcedPart outSourcedPart = new OutsourcedPart(name, inStock, price, max, min, companyName, partID);
                    Inventory.AddPart(outSourcedPart);
                }

                this.Close();
                mainScreenForm.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreenForm.Show();
        }

        // Visual validation checks
        private void addPartNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addPartNameTextbox.Text) || int.TryParse(addPartNameTextbox.Text, out _))
            {
                addPartNameTextbox.BackColor = Color.Red;
            }
            else
            {
                addPartNameTextbox.BackColor = Color.White;
            }
        }

        private void addPartInventoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addPartInventoryTextbox.Text, out _))
            {
                addPartInventoryTextbox.BackColor = Color.Red;
            }
            else
            {
                addPartInventoryTextbox.BackColor = Color.White;
            }
        }

        private void addPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(addPartPriceCostTextBox.Text, out _))
            {
                addPartPriceCostTextBox.BackColor = Color.Red;
            }
            else
            {
                addPartPriceCostTextBox.BackColor = Color.White;
            }
        }

        private void addPartMaxTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addPartMaxTextbox.Text, out _))
            {
                addPartMaxTextbox.BackColor = Color.Red;
            }
            else
            {
                addPartMaxTextbox.BackColor = Color.White;
            }
        }

        private void addPartMinTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(addPartMinTextbox.Text, out _))
            {
                addPartMinTextbox.BackColor = Color.Red;
            }
            else
            {
                addPartMinTextbox.BackColor = Color.White;
            }
        }

        private void addPartRadioTextbox_TextChanged(object sender, EventArgs e)
        {
            if (addPartInHouseRadioButton.Checked)
            {
                if (!int.TryParse(addPartRadioTextbox.Text, out _))
                {
                    addPartRadioTextbox.BackColor = Color.Red;
                }
                else
                {
                    addPartRadioTextbox.BackColor = Color.White;
                }
            }
            else if (addPartOutsourcedRadioButton.Checked)
            {
                if (int.TryParse(addPartRadioTextbox.Text, out _))
                {
                    addPartRadioTextbox.BackColor = Color.Red;
                }
                else
                {
                    addPartRadioTextbox.BackColor = Color.White;
                }
            }
        }
    }
}
