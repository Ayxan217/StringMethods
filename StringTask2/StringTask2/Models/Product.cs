using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask2.Models
{
    public class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Income;
        public int Count;

        public Product(string brandName, string model, int price, int cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;

        }
        public  string IdMaker(string name, string model)
        {
            string id = name.Substring(0, 2) + model.Substring(0, 2);
            return id;
        }
        public  void GetInfo()
        {
            Console.WriteLine($"Brand {BrandName}, Model: {Model} Price{Price}, Count: {Count} Income: {Income}");
        }
        public int Sale( int income int price int cost int count)
        {
            if (count > 0)
            {
                income = price - cost;
                count--;
            }
            return count, income; //işlenmedi :(
        }

    }
}
