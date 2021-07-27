using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Repo
{
    public class MenuItemsRepo
    {
        private List<MenuItems> _listOfItems = new List<MenuItems>();

        //Create 
        public void AddItemsToList(MenuItems item)
        {
            _listOfItems.Add(item);
        }

        //Read
        public List<MenuItems> GetItemsList()
        {
            return _listOfItems;
        }

        // private DeveloperInfo GetContentByNameException(string v)
        // {
        // throw new NotImplementedException();
        // }
        //rewrite or it will force an exception

        //Update
        public bool UpdateExistingItem(string originalMealName, MenuItems newItem)
        {
            // Find the content
            MenuItems oldItem = GetItemByName(originalMealName);

            //Update the content
            if (oldItem != null)
            {
                oldItem.MealName = newItem.MealName;
                oldItem.MealNumber = newItem.MealNumber;
                oldItem.MealDescription = newItem.MealDescription;
                oldItem.MealIngrediants = newItem.MealIngrediants;
                oldItem.MealPrice = newItem.MealPrice;

                return true;
            }
            else
            {
                return false;
            }
        }

        //  public MenuItems GetItemByName(string v)
        // {
        //   throw new NotImplementedException();
        //  }

        //Delete
        public bool RemoveItemFromList(string mealName)
        {
            MenuItems item = GetItemByName(mealName);

            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            _listOfItems.Remove(item);

            if (initialCount > _listOfItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Helper method
        public MenuItems GetItemByName(string mealName)
        {
            foreach (MenuItems item in _listOfItems)
            {
                if (item.MealName.ToLower() == mealName.ToLower())
                {
                    return item;
                }
            }

            return null;
        }
    }
}
