using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repo
{
    //POCO
    public class MenuItems
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngrediants { get; set; }
        public double MealPrice { get; set; }

        public MenuItems() { }

        public MenuItems(int mealNumber, string mealName, string mealDescription, string mealIngrediants, double mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngrediants = mealIngrediants;
            MealPrice = mealPrice;
        }
    }
}
