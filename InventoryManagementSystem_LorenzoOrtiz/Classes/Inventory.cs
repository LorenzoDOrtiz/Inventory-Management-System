using InventoryManagementSystem_LorenzoOrtiz.Parts;
using InventoryManagementSystem_LorenzoOrtiz.Products;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryManagementSystem_LorenzoOrtiz
{
    public static class Inventory
    {
        // Define BindingList<Product> for holding products and parts
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();



        static Inventory()
        {
            PopulateData();
        }

        public static void PopulateData()
        {
            // Create parts
            InhousePart woodenBoard = new InhousePart("Wooden Board", 100, 9.99m, 150, 50, 1001);
            OutsourcedPart screws = new OutsourcedPart("Screws", 200, 0.05m, 1000, 100, "ABC Supplies");
            InhousePart metalFrame = new InhousePart("Metal Frame", 50, 19.99m, 100, 20, 1002);
            OutsourcedPart glassTop = new OutsourcedPart("Glass Top", 30, 29.99m, 50, 10, "GlassWorks Inc.");
            InhousePart drawer = new InhousePart("Drawer", 40, 14.99m, 60, 15, 1003);
            OutsourcedPart handle = new OutsourcedPart("Handle", 300, 1.99m, 500, 100, "Hardware Co.");

            // Add Parts to inventory
            AllParts.Add(woodenBoard);
            AllParts.Add(screws);
            AllParts.Add(metalFrame);
            AllParts.Add(glassTop);
            AllParts.Add(drawer);
            AllParts.Add(handle);

            // Create lists of associated parts
            var deskParts = new BindingList<Part> { woodenBoard, screws };
            var tableParts = new BindingList<Part> { metalFrame, glassTop };
            var cabinetParts = new BindingList<Part> { drawer, handle };

            // Create products
            Product desk = new Product("Desk", 20, 149.99m, 25, 10, deskParts);
            Product table = new Product("Table", 15, 199.99m, 20, 5, tableParts);
            Product cabinet = new Product("Cabinet", 10, 249.99m, 15, 5, cabinetParts);

            // Add products to inventory
            Products.Add(desk);
            Products.Add(table);
            Products.Add(cabinet);
        }


        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        // Method to delete a part
        public static bool DeletePart(Part part)
        {
            Part partToDelete = LookupPart(part.PartID);
            if (partToDelete == null)
            {
                return false;

            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }


        public static Part LookupPart(int partID)
        {
            foreach (Part currentPart in AllParts)
            {
                if (currentPart.PartID == partID)
                {
                    return currentPart;
                }
            }
            Part newPart = null;
            return newPart;
        }


        public static void UpdatePart(int partID, Part updatedPart)
        {
            Part existingPart = LookupPart(partID);
            if (existingPart != null)
            {
                int index = AllParts.IndexOf(existingPart);
                AllParts[index] = updatedPart; // Replace the old part with the updated part
            }
            else
            {
                MessageBox.Show($"Part with ID {partID} not found.");
            }
        }



        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public static bool RemoveProduct(int productID)
        {
            Product productToRemove = null;

            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    productToRemove = product;
                    break;
                }
            }

            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            else
            {
                MessageBox.Show($"Product with ID {productID} not found.");
                return false;
            }
        }



        public static Product LookupProduct(int productID)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    return currentProduct;
                }
            }
            Product newProduct = null;
            return newProduct;
        }

        public static void UpdateProduct(int originalProductID, Product updatedProduct)
        {
            Product existingProduct = LookupProduct(originalProductID);
            if (existingProduct != null)
            {
                existingProduct.ProductID = updatedProduct.ProductID;
                existingProduct.Name = updatedProduct.Name;
                existingProduct.InStock = updatedProduct.InStock;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Max = updatedProduct.Max;
                existingProduct.Min = updatedProduct.Min;
                existingProduct.AssociatedParts = new BindingList<Part>(updatedProduct.AssociatedParts);
            }
            else
            {
                MessageBox.Show($"Product with ID {originalProductID} not found.");
            }
        }



    }
}
