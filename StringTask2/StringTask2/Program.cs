namespace StringTask2;
using StringTask2.Models;

public class Program : Product
{
    public Program(string brandName, string model, int price, int cost, int count) : base(brandName, model, price, cost, count)
    {
    }

    static void Main(string[] args)
    {
        Product product = new Product("apple", "iphone", 999, 600, 17);
        Console.WriteLine(string.Concat("ID: ", IdMaker(product.BrandName, product.Model)));

    }





}
