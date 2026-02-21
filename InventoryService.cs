namespace InventoryManagement.Services
{
    public class InventoryService
    {
        private string[,] products;
        private int[] initialStock;

        public InventoryService()
        {
            products = new string[2, 3];

            // Row 0 - Product Names
            products[0, 0] = "Apples";
            products[0, 1] = "Milk";
            products[0, 2] = "Bread";

            // Row 1 - Stock Quantities
            products[1, 0] = "10";
            products[1, 1] = "5";
            products[1, 2] = "20";

            // Store original stock values
            initialStock = new int[3];
            for (int i = 0; i < 3; i++)
            {
                initialStock[i] = int.Parse(products[1, i]);
            }
        }

        // Return inventory array
        public string[,] GetInventory()
        {
            return products;
        }

        // Update stock for a product
        public void UpdateStock(int productIndex, int newStock)
        {
            if (productIndex >= 0 && productIndex < 3)
            {
                products[1, productIndex] = newStock.ToString();
            }
        }

        // Reset inventory to original stock
        public void ResetInventory()
        {
            for (int i = 0; i < 3; i++)
            {
                products[1, i] = initialStock[i].ToString();
            }
        }
    }
}