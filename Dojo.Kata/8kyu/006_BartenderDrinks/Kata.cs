using System.Collections.Generic;
using System.Globalization;

namespace Dojo.Kata._8kyu._006_BartenderDrinks
{
    public class Kata
    {
        public static string GetDrinkByProfession(string p)
        {
            Dictionary<string, string> catalog = new Dictionary<string, string>();
            catalog.Add("Jabroni", "Patron Tequila");
            catalog.Add("School Counselor", "Anything with Alcohol");
            catalog.Add("Programmer", "Hipster Craft Beer");
            catalog.Add("Bike Gang Member", "Moonshine");
            catalog.Add("Politician", "Your tax dollars");
            catalog.Add("Rapper", "Cristal");
            const string _Default = "Beer";

            p = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(p);
            string result;
            if (catalog.ContainsKey(p))
            {
                catalog.TryGetValue(p, out result);
            }
            else 
            {
                result = _Default;
            }
            return result;
        }
    }
}
