using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Product
    {
        private string productName;
        private decimal productPrice;
        private int productStock;
        public Product(string name, decimal price, int stock) 
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            
        }

        public string Name
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (value == "") 
                {
                    throw new ArgumentException("Name can not be empty");
                }
                this.productName = value;
            }
        }

        public decimal Price
        {
            get 
            {
                return this.productPrice;
            }
            private set 
            {
                if (value <= 0) 
                {
                    throw new ArgumentException("Price can not be negative");
                }
                this.productPrice = value;
            }

        }
        public int Stock         
        {
            get 
            {
                return this.productStock;
            }
            set 
            {
                if (value < 0) {
                    throw new ArgumentException("Stock can't be negative");
                }
                this.productStock = value;
            }
        }

        public void Inventory()
        {
            Console.WriteLine(this.productName + " saldo: " + this.productStock);

        }

    }
}
