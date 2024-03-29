using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGoodSushi.Src.Utility
{

    // I am trying to abstract away the allergy statement logic from the Menu class. Initially, I constructed this AllergyStatement
    // // class and had it containing a string Property for the statement, and then set the value for the Property
    // using a method. I then refactored to remove the Property as I thought the method could return the string directly -
    // is this good practice, or bad practice?? The other way just seemed overly complicated but I am not sure which
    // makes better use of abstraction / encapsulation.

    public class AllergyStatement
    {
        public static string CreateAllergyStatement(bool dairy)
        {
            if (dairy)
                return "Note: Contains dairy. ";
            else return "";
        }

    }
}
