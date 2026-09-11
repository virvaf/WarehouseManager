namespace WarehouseManager;

internal class Program
{
    static void Main(string[] args)
    {
        Location A101 = new Location(1, "A-101");
        Product testProduct = new Product(1, "test1", A101, 1, 12.99m);

        Console.WriteLine(testProduct.Location.Code);
    }
}