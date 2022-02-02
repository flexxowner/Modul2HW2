using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Basket
    {

        public bool Status { get; }

        public Basket(bool status)
        {
            Status = status;
        }
        public static string BasketInfo(List<Products> data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in data)
            {
                stringBuilder.Append($"{item.Product} ");
            }
            return stringBuilder.ToString();
        }
    }
}
