using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoGoodSushi.Src
{
    public class Order
    {
        private DateTime OrderTime { get; }
        private OrderStatus OrderStatus { get; set; }
        public List<MenuItem> OrderedItems { get; }
        public int OrderNumber { get; }
        public string OrderOwner { get; }

        public Order(string name)
        {
            this.OrderTime = DateTime.Now;
            this.OrderNumber = new Random().Next(1000, 9999);
            this.OrderStatus = OrderStatus.Order_In_Progress;
            this.OrderedItems = [];
            this.OrderOwner = name;
        }

        public void OrderItem(MenuItem item)
        {
            if (!item.IsAvailable)
                Console.WriteLine($"We are very sorry, but {item.MenuItemName} is not currently available. Please choose something else.");
            else
            {
                OrderedItems.Add(item);
                Console.WriteLine($"\nOrder received for item {item.Id}: {item.MenuItemName}.\nPlease enter your next item to order, M to view the menu again, or X to finish ordering.");
            }
        }

        public static void DisplayOrder(Order order)
        {
            Console.WriteLine($"Order {order.OrderNumber} placed at {order.OrderTime} by {order.OrderOwner}. Total Cost: ${order.CalculateOrderTotal()}:0.00");
            
            foreach (MenuItem item in order.OrderedItems)
            {
                Console.WriteLine($"{item.Id} - {item.MenuItemName} - ${item.Price:0.00}");
            }
            Console.WriteLine($"Order { order.OrderNumber} totalling ${ order.CalculateOrderTotal():0.00}. Status: {order.OrderStatus}");
        }

        public double CalculateOrderTotal()
        {
            double total = 0;
            foreach (MenuItem item in OrderedItems)
            {
                total += item.Price;
            }
            return total;
        }

        public void CloseOrder(Order order)
        {
            OrderStatus = OrderStatus.Order_To_Be_Paid;

            Console.WriteLine($"\nYou have finished your order. Order number {OrderNumber} has gone to the kitchen.\nHere is a summary of your order:\n");
            DisplayOrder(order);

        }

        public void CancelOrder()
        {
            Console.WriteLine($"Order number {OrderNumber} is cancelled. Bye for now.");
            OrderStatus = OrderStatus.Order_Cancelled;
        }

        public static void PayOrder(Order order)
        {
            order.OrderStatus = OrderStatus.Order_Paid;
        }
    }
}
