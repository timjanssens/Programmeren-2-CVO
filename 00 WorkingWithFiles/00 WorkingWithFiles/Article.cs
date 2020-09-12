using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_WorkingWithFiles
{
    class Article : Product
    {
        public int CountArticle { get; set; } = 0;
        public static List<Article> ArticleList { get; set; } = new List<Article>();

        public Article()
        {

        }

        public Article(int countArticle, string code, string name, double price)
            :base(code, name, price)
        {
            this.CountArticle = countArticle;
        }

        private double CalculatePriceArticles() => CountArticle * this.Price;
        


        public override string ToString()
        {
            return $"{this.CountArticle} piece(s) of {base.Name} for €{this.CalculatePriceArticles()} ";
        }

    }
}
