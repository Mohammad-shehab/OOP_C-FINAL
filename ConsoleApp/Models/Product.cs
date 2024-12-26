using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp.Models
{
    public class Product
    {
        // declaring a list of products
        public List<Product> products = new List<Product>();
        ///////////////////////////----Prop---//////////////////////////////////////////
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity{ get;  set; }
        ///////////////////////////----name function---//////////////////////////////////////////

        public void info(string name)
        {
            Console.WriteLine("Name: " + name);
        }
        ///////////////////////////----name, price function---//////////////////////////////////////////

        public void info(string name, double price)
        {
            Console.WriteLine("Name: " + name + " ,Price: " + price);
        }

        ///////////////////////////----name, price, quantity function---//////////////////////////////////////////

        public void info(string name, double price, int quantity)
        {
            Console.WriteLine("Name: " + name + " ,Price: " + price + " ,Quantity: " + quantity + " ,Total price: " + (quantity * price));

        }
        ///////////////////////////----addin a list of products---//////////////////////////////////////////

        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product { Name = name, Price = price, Quantity = quantity });
         }
        ///////////////////////////----Printing all products---//////////////////////////////////////////
        public void AllProducts()
        {
            foreach (var x in products)
            {
                Console.WriteLine("Name: " + x.Name + " ,Price: " + x.Price + " ,Quantity: " + x.Quantity + " ,Total price: " + (x.Quantity * x.Price));
            }
        }
    }
}
