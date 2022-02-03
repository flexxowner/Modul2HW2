using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Basket
    {

        public string Product { set; get; }
        public decimal Price { set; get; }

        public List<Basket> BasketList = new List<Basket>(9);
        public List<Basket> AddList(List<Products> productList)
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                var Index = random.Next(1, 5);
                if (Index == 1)
                {
                    BasketList.Add(new Basket() { Product = productList[0].Product, Price = productList[0].Price });
                }
                else if (Index == 2)
                {
                    BasketList.Add(new Basket() { Product = productList[1].Product, Price = productList[1].Price });
                }
                else if (Index == 3)
                {
                    BasketList.Add(new Basket() { Product = productList[2].Product, Price = productList[2].Price });
                }
                else if (Index == 4)
                {
                    BasketList.Add(new Basket() { Product = productList[0].Product, Price = productList[3].Price });
                }
            }
            return BasketList;
        }

    }
}
