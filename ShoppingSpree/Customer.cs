using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Customer
    {
        private string customerName;
        private decimal walletBalance;
        private List<Product> bagOfProducts;
       

        public Customer(string name, decimal balance) {
            this.Name = name;
            this.Balance = balance;
            this.bagOfProducts = new List<Product>();
        }

        public void Buy(Product[] products) 
        {
            foreach (Product product in products) 
            {
                Buy(product);
            }
                
        }

        public void Buy(Product product)
        {
            if (this.walletBalance > product.Price && product.Stock >= 1)
            {
                this.bagOfProducts.Add(product);
                this.walletBalance -= product.Price;
                product.Stock -= 1;
                Console.WriteLine(this.customerName + " bought " + product.Name);
            }

            else if (this.walletBalance < product.Price)
            {
                Console.WriteLine(this.customerName + " can't afford " + product.Name);
            }

            else if (product.Stock == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(product.Name + " is out of stock");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }
        public void Buy() 
        {
            Console.WriteLine(this.customerName + " bought nothing ");
        }
        
      
        public string Name
        {
            get
            {
                return this.customerName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Name can not be empty or less then 3 characters");
                }
                this.customerName = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.walletBalance;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wallet balance can not be negative");
                }
                this.walletBalance = value;
            }
        }

    }
}
