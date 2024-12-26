using ConsoleApp.Models;


//Console.WriteLine("product name ");
string name="";

//Console.WriteLine("product price ");
double price=0;

//Console.WriteLine("product quantity ");
int quantity=0 ;


Product product = new Product();


//product.PrintName(name);
//product.PrintNameAndPrice(name, price);
//product.PrintAll(name, price, quantity);






Console.WriteLine("Do you want to add a product? y/n");
string  choice = Console.ReadLine().ToLower();
while (choice == "y")
{
    Console.WriteLine("product name ");
    name = Console.ReadLine();
    Console.WriteLine("product price ");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("product quantity ");
    quantity = Convert.ToInt32(Console.ReadLine());
    product.AddProduct(name, price, quantity);
    Console.WriteLine("Do you want to add a product? y/n");
    choice = Console.ReadLine().ToLower();
}

//product.PrintName(name);
//product.PrintNameAndPrice(name, price);
//product.PrintAll(name, price, quantity);
product.PrintAllProducts();
