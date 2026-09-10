namespace WarehouseManager;

internal class Program
{
    static void Main(string[] args)
    {
        Product testProduct = new Product(1, "test1", "A-100", 1, 12.99m);

        Console.WriteLine(testProduct.Name);
    }
}