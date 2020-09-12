using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_WorkingWithFiles
{
    class Product
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public string MyProperty { get; set; } = string.Empty;
        public static List<Product> ProductList { get; set; } = new List<Product>();


        public Product()
        {
            
        }

        public Product(string code, string name, double price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Code({this.Code}) - {this.Name} - €{this.Price.ToString("0.##")}";
        }


    }
}
