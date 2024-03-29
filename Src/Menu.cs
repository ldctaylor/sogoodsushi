using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SoGoodSushi.Src.Utility;
using static System.Formats.Asn1.AsnWriter;

namespace SoGoodSushi.Src
{
    public class Menu
    {
        public List<MenuItem> menu;

        public Menu()
        {
            this.menu = [];
        }

        public void AddItemToMenu(string name, double price, MenuCategory category = 0, bool dairy = true, bool vego = false, bool isAvail = true, string desc = "")
        {
            menu.Add(new MenuItem(name, price, category, dairy, vego, isAvail, desc));
            menu.Last().Id = menu.Count;
        }
        public static void RequestMenu(List<MenuItem> menu, string specialMenu = "")
        {
            Console.WriteLine($"Here is our {specialMenu.ToUpper()} menu:");
            foreach (MenuCategory category in Enum.GetValues(typeof(MenuCategory)))
            {
                Console.WriteLine($"\n*******{category.ToString().ToUpper()}********");

                foreach (MenuItem item in menu)
                {
                    if (item.MenuCategory == category)
                        switch (specialMenu)
                        {
                            case "vegetarian":
                                if (item.IsVegetarian)
                                    item.PrintMenuItem();
                                break;
                            case "dairyfree":
                                if (!item.ContainsDairy)
                                    item.PrintMenuItem();
                                break;
                            default:
                                item.PrintMenuItem();
                                break;
                        }

                }


            }
        }

        public static MenuItem? FindItemInMenu(List<MenuItem> menu, int Id)
        { 
            if (menu.Count > 0)
                foreach (MenuItem item in menu)
                    {
                        if (item.Id == Id)
                            return item;
                    }
            return null;

        }
    }
}