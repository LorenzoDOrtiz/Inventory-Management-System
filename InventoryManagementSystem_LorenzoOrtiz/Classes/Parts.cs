namespace InventoryManagementSystem_LorenzoOrtiz.Parts
{
    public abstract class Part
    {

        private static int partCount = 0;
        public static int PartCount => partCount;

        // Constructor for our part objects
        public Part(string name, int inStock, decimal price, int max, int min, int partID = 0)
        {
            PartID = partID == 0 ? ++partCount : partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
        }


        // Properties
        public int PartID { get; protected set; }
        public string Name { get; protected set; }
        public int InStock { get; protected set; }
        public decimal Price { get; protected set; }
        public int Max { get; protected set; }
        public int Min { get; protected set; }
    }

    public class InhousePart : Part
    {
        // Constructor
        public InhousePart(string name, int inStock, decimal price, int max, int min, int machineID, int partID = 0) : base(name, inStock, price, max, min, partID)
        {
            MachineID = machineID;
        }

        // Property
        public int MachineID { get; private set; }
    }

    public class OutsourcedPart : Part
    {
        // Constructor
        public OutsourcedPart(string name, int inStock, decimal price, int max, int min, string companyName, int partID = 0) : base(name, inStock, price, max, min, partID)
        {
            CompanyName = companyName;
        }

        // Property
        public string CompanyName { get; private set; }
    }
}
