using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SoGoodSushi.Src.Utility
{
    public class Waiter
    {
        public static void TakeOrder(Menu menu, Order order)
        {
        // Prompt user for input

            Console.WriteLine("\nPlease enter the first item number you would like to order and press Enter. Press V for vegetarian menu, D for dairy free menu, or X to finish ordering.");

            while (true)
            {
                string? customerInput = Console.ReadLine();
                if (customerInput != null)
                    {
                    Console.WriteLine($"Customer input is {customerInput}.");
                    switch (customerInput.ToUpper())
                    {
                        case "V":
                            Console.Clear();
                            Menu.RequestMenu(menu.menu, "vegetarian");
                            break;
                        case "D":
                            Console.Clear();
                            Menu.RequestMenu(menu.menu, "dairyfree");
                            break;
                        case "M":
                            Console.Clear();
                            Menu.RequestMenu(menu.menu);
                            break;
                        case "X":
                            Console.Clear();
                            {
                                if (order.OrderedItems.Count == 0)
                                    order.CancelOrder();
                                else
                                {
                                    order.CloseOrder(order);
                                }
                                break;
                            }
                        default:
                            if (int.TryParse(customerInput, out int itemId))
                            {
                                MenuItem? orderedItem = Menu.FindItemInMenu(menu.menu, itemId);
                                if (orderedItem == null)
                                {
                                    Console.WriteLine("Item not found. Please enter a valid item number from the menu.");
                                }
                                else
                                {
                                    order.OrderItem(orderedItem);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid item number from the menu.");

                            }
                            break;
                    }
                }
            }
            }
        }




    }