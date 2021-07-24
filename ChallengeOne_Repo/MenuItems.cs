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
        public decimal MealPrice { get; set; }

        public MenuItems() { }

        public MenuItems(int MealNumber, string MealName, string MealDescription, string MealIngrediants, decimal MealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngrediants = mealIngrediants;
            MealPrice = mealPrice;
        }
    }
}
