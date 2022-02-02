using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_HW2
{
    class Starter
    {
        List<Products> ProductList = new List<Products>()
        {
            new Products() {Product = "potato",Price = 45},
            new Products() {Product = "orange",Price = 56},
            new Products() {Product = "tomato",Price = 30},
            new Products() {Product = "apple",Price = 25},
        };
        List<Products> ProductsToBuy = new List<Products>(9);
        Random random = new Random();
        Order order = new Order();
        public void Run()
        {
            Basket basket;
            for (int i = 0; i < 9; i++)
            {
                var Index = random.Next(1, 5);
                if (Index == 1)
                {
                    ProductsToBuy.Add(ProductList[0]);
                }
                else if (Index == 2)
                {
                    ProductsToBuy.Add(ProductList[1]);
                }
                else if (Index == 3)
                {
                    ProductsToBuy.Add(ProductList[2]);
                }
                else if (Index == 4)
                {
                    ProductsToBuy.Add(ProductList[3]);
                }
            }
            var data = ProductsToBuy;
            Console.WriteLine($"Products in the basket: {Basket.BasketInfo(data)}");
            Console.WriteLine("Do you want to place an order?");
            Console.WriteLine("Please, input yes or not");
            var answer = Console.ReadLine();
            if (answer == "yes")
            {
                basket = order.OrderStatusTrue();
                if (basket?.Status == true)
                {
                    Console.WriteLine($"Your order № {random.Next(1, 101)}:{order.OrderInfo(ProductsToBuy)}, total price:{order.TotalPrice(ProductsToBuy)}");
                }
            }
            else if (answer == "not")
            {
                basket = order.OrderStatusFalse();
                if (basket?.Status == false)
                {
                    Console.WriteLine("Order not generated");
                }
            }

        }
    }
}
