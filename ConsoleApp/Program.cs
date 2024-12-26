using ConsoleApp.Models;


Console.WriteLine("product name ");
string name = Console.ReadLine();
Console.WriteLine("product price ");
double price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("product quantity ");
int quantity =Convert.ToInt32(Console.ReadLine());

Product product = new Product();
product.info(name);
product.info(name, price);
product.info(name, price, quantity);




Console.WriteLine("------------------------------------------------------------");





//bonus using while loop
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
product.AllProducts();




Console.WriteLine("------------------------------------------------------------");




//using for loop

Product product1 = new Product();



Console.WriteLine("number of products you want to add: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.WriteLine("product name ");
    name = Console.ReadLine();
    Console.WriteLine("product price ");
    price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("product quantity ");
    quantity = Convert.ToInt32(Console.ReadLine());
    product1.AddProduct(name, price, quantity);
}
product1.AllProducts();


