using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGoodSushi.Src.Utility
{
    public class VegetarianStatement
    {
        public static string CheckVegetarianStatus(bool vegetarian)
        {
            if (vegetarian)
                return "Vegetarian. ";
            else return "";
        }

    }
}
