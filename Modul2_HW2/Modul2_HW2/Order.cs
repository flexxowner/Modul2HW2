using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Order
    {
        public Basket OrderStatusTrue()
        {
            return new Basket(true);
        }
        public Basket OrderStatusFalse()
        {
            return new Basket(false);
        }
        public string OrderInfo(List<Products> data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in data)
            {
                stringBuilder.Append($"{item.Product} ");
            }
            return stringBuilder.ToString();
        }
        public decimal TotalPrice(List<Products> data)
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
