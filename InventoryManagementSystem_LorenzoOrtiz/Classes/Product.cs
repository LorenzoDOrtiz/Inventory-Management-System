using InventoryManagementSystem_LorenzoOrtiz.Parts;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz.Products
{
    public class Product
    {
        private static int productCount = 0;
        public static int ProductCount => productCount;

        // Constructor
        public Product(string name, int inStock, decimal price, int max, int min, BindingList<Part> associatedParts = null, int productID = 0)
        {
            ProductID = productID == 0 ? ++productCount : productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            AssociatedParts = associatedParts ?? new BindingList<Part>();
        }


        // Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }

        // Method to add associated part
        public void AddAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }

        // Method to remove associated part by part ID
        public bool RemoveAssociatedPart(int partID)
        {
            Part partToRemove = null;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    partToRemove = part;
                    break;
                }
            }

            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            else
            {
                MessageBox.Show($"Part with ID {partID} not found.");
                return false;
            }
        }

        // Method to lookup associated part by ID
        public Part LookupAssociatedPart(int associatedPart)
        {
            foreach (Part currentAssociatedPart in AssociatedParts)
            {
                if (currentAssociatedPart.PartID == associatedPart)
                {
                    return currentAssociatedPart;
                }
            }
            Part newAssociatedPart = null;
            return newAssociatedPart;
        }
    }
}
