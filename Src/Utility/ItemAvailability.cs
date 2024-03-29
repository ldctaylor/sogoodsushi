using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGoodSushi.Src.Utility
{
    // I am trying to abstract away the availability statement logic from the Menu class. However, I feel like there is
    // an element of duplication in how I have done it with declaring a class and then a string field. 
    // But that's the nature of abstraction, right? I am really not sure if I have missed something basic here or if this
    // is a good way to do it. 
    public class ItemAvailability
    {
        public static string CheckItemAvailability(bool available)
        {
            if (!available)
                return "NOT CURRENTLY AVAILABLE";
            else return "";
        }

    }
}

