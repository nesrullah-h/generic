using Generic.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Models
{
    internal class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public override void Sell()
        {
            Count--;
            TotalinCome++;
            if (Product.count==0)
            {
                throw new ProductCountIsZeroException();
            }
            return ;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"AuthorName:{AuthorName}\nPageCount:{PageCount}\nName:{Name}\nPrice{Price}\nCount{Count}");
        }
        public Book(string name, double price, string authorName, int pageCount)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }


}
