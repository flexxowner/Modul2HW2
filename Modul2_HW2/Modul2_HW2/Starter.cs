using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Starter
    {
        List<Products> ProductsList = new List<Products>()
        {
            new Products() {Product = "potato",Price = 45},
            new Products() {Product = "orange",Price = 56},
            new Products() {Product = "tomato",Price = 30},
            new Products() {Product = "apple",Price = 25},
        };
        Basket basket = new Basket();
        Order order = new Order();
        Random random = new Random();
        public void Run()
        {
            basket.AddList(ProductsList);
            StringBuilder builder = new StringBuilder();
            foreach (var item in basket.BasketList)
            {
                builder.Append($"{item.Product} ");
            }
            string products = builder.ToString();
            Console.WriteLine($"Products in the Basket:{products}");
            Console.WriteLine("Do you want to place an order?");
            Console.WriteLine("Please, input yes or not");
            var answer = Console.ReadLine();
            if (answer == "yes")
            {
                order.Status = true;
                order.AddOrder(basket.BasketList);
                order.TotalPrice(order.ProductList);
                StringBuilder builder1 = new StringBuilder();
                foreach (var item in order.ProductList)
                {
                    builder1.Append($"{item.Product} ");
                }
                string orderList = builder1.ToString();
                Console.WriteLine($"Your check number {random.Next(1,100)}: Products ordered: {orderList}");
                Console.WriteLine($"Total:{order.TotalPrice(order.ProductList)}");
            }
            else if (answer == "not")
            {
                order.Status = false;
                Console.WriteLine("Order not generated");
            }

        }
    }
}
