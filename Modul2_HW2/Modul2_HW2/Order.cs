using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Order
    {
        public string Product { set; get; }
        public decimal Price { set; get; }

        public bool Status { set; get; }

        public List<Order> ProductList = new List<Order>(9);
        public List<Order> AddOrder(List<Basket> data)
        {
            for (int i = 0; i < 9; i++)
            {
                ProductList.Add(new Order() { Product = data[i].Product, Price = data[i].Price });
            }
            return ProductList;
        }

        public decimal TotalPrice(List<Order> data)
        {
            decimal summa = 0;
            for (int i = 0; i < data.Count; i++)
            {
                summa = summa + data[i].Price;
            }
            return summa;
        }
    }
}
