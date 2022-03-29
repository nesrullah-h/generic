using System;
using System.Collections.Generic;
using System.Text;

namespace Generic.Models
{
    abstract class Product
    {
        private static int _id = 1;
        protected static int count { get; set; }  

        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public static int Count { get; set; }
        public int TotalinCome { get; set; }

        public abstract void Sell();
        public abstract void ShowInfo();

        public Product()
        {
            _id++;
            Id = _id;

        }
        

    }
}
