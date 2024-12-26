using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//class product
//3 functions
//first function takes name
//second function takes name and price
//third function takes name, price and quantity
//print the values in the main function






namespace ConsoleApp.Models
{
    public class Product
    {



        private string name;
        private double price;
        private int quantity;


        private List<Product> products = new List<Product>();



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public void PrintName(string name)
        {
            Console.WriteLine("Name: " + name);
        }

        public void PrintNameAndPrice(string name, double price)
        {
            Console.WriteLine("Name: " + name + " ,Price: " + price);
        }


        public void PrintAll(string name, double price, int quantity)
        {
            Console.WriteLine("Name: " + name + " ,Price: " + price + " ,Quantity: " + quantity + " ,Total price: " + (quantity * price));

        }


        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product { Name = name, Price = price, Quantity = quantity });



                 }


        public void PrintAllProducts()
        {
            foreach (var x in products)
            {
                Console.WriteLine("Name: " + x.name + " ,Price: " + x.price + " ,Quantity: " + x.quantity + " ,Total price: " + (x.quantity * x.price));
            }
        }
    }
}
