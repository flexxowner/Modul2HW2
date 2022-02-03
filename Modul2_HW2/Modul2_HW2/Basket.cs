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

        public List<Basket> ProductList = new List<Basket>(9);
        public List<Basket> AddList(List<Basket> productsList)
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                var Index = random.Next(1, 5);
                if (Index == 1)
                {
                    ProductList.Add(productsList[0]);
                }
                else if (Index == 2)
                {
                    ProductList.Add(productsList[1]);
                }
                else if (Index == 3)
                {
                    ProductList.Add(productsList[2]);
                }
                else if (Index == 4)
                {
                    ProductList.Add(productsList[3]);
                }
            }
            return ProductList;
        }

    }
}
