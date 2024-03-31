using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SoGoodSushi.Src.Utility;

namespace SoGoodSushi.Src;

public class MenuItem
{
    public int Id { get; set; }
    public string MenuItemName { get; set; }
    public string? MenuItemDesc { get; set; }
    public MenuCategory MenuCategory { get; set; }
    public bool ContainsDairy { get; private set; }
    public bool IsVegetarian { get; private set; }
    public bool IsAvailable { get; private set; }

    public double Price { get; private set; }

    public MenuItem(string name, double price, MenuCategory category = 0, bool dairy = true, bool vego = false, bool isAvail = true, string? desc = "") 
    {
        this.MenuItemName = name;
        this.MenuItemDesc = desc;
        this.MenuCategory = category;
        this.ContainsDairy = dairy;
        this.IsVegetarian = vego;
        this.IsAvailable = isAvail;
        this.Price = price;
    }

    public void PrintMenuItem()
    {
         Console.WriteLine($"Item {Id, -3} - {MenuItemName, -45} - ${Price:0.00}.  {MenuItemDesc} {VegetarianStatement.CheckVegetarianStatus(IsVegetarian)}{AllergyStatement.CreateAllergyStatement(ContainsDairy)}{ItemAvailability.CheckItemAvailability(IsAvailable)}");
    }

}