using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _00_Multiple_forms_Classes
{
    class Product
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Price { get; set; } = 0;

        public static List<Product> Products { get; set; } = new List<Product>();

        public Product()
        {

        }
        public Product(string code, string name, string description, int price)
            :this()
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Product name: {this.Name} => Product Code: {this.Code}";
        }


    }
}
