using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {

                                    // name, price and stock
            Product milk = new Product("Milk", 12, 2);
            Product bread = new Product("Bread", 30, 1);
            Product oil = new Product("Oil", 20, 1000);
            Product meat = new Product("Meat", 110, 500);


                                         // name, wallet balance                     
            Customer pesho = new Customer("Pesho", 170);
            Customer gesho = new Customer("Gesho", 200);
            Customer tresho = new Customer("Tresho", 500);
            
            milk.Inventory();
            bread.Inventory();
            oil.Inventory();
            meat.Inventory();

            Console.WriteLine();

          
            pesho.Buy(milk);
            pesho.Buy(bread);
            pesho.Buy(oil);
            pesho.Buy(meat);

            Console.WriteLine();

            gesho.Buy();
            gesho.Buy(bread);
            gesho.Buy(oil);
            gesho.Buy(meat);

            Console.WriteLine();

            tresho.Buy(new Product[] { milk, bread, oil, meat });


            Console.WriteLine();

            milk.Inventory();
            bread.Inventory();
            oil.Inventory();
            meat.Inventory();

            tresho.Buy(milk);
            gesho.Buy();
            pesho.Buy(meat);


            Console.ReadLine();
        }
    }
}
