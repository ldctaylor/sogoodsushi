// See https://aka.ms/new-console-template for more information
using SoGoodSushi.Src;
using SoGoodSushi.Src.Utility;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

Menu menu = new();
menu.AddItemToMenu("Salmon, Avocado and Cream Cheese Sushi Roll", 4.5, MenuCategory.Sushi);
menu.AddItemToMenu("Teriyaki Chicken Sushi Roll", 4.5, MenuCategory.Sushi, false, false, true);
menu.AddItemToMenu("Tuna and Cucumber Sushi Roll", 4, MenuCategory.Sushi, false, false, false);
menu.AddItemToMenu("Miso Soup", 3.5, MenuCategory.Soups, false, true, true, "Delicious miso soup to accompany your meal.");
menu.AddItemToMenu("Udon Noodles", 15.90, MenuCategory.Main_Dishes, false, true, true, "Tell the waiter if you'd like it vegetarian.");
menu.AddItemToMenu("Udon Noodle Soup", 14.90, MenuCategory.Soups, false, true, false, "Chicken or vegetarian - tell your waiter.");
menu.AddItemToMenu("Mochi", 8.95, MenuCategory.Desserts, true, true, true, "Assortment of flavours.");
menu.AddItemToMenu("Bubble Tea", 16, MenuCategory.Drinks, true, true, true);
menu.AddItemToMenu("Green Tea", 2.5, MenuCategory.Drinks, false, true, true);

string customerName = Welcome.WelcomeCustomer();
Menu.RequestMenu(menu.menu);
Order order = new(customerName);
Waiter.TakeOrder(menu, order);

