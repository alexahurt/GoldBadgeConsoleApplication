using System;
using System.Collections.Generic;
using ChallengeOne_Repo;

namespace GoldBadgeConsoleApplication
{
    internal class MenuItemsRepo
    {
        public List<MenuItems> GetItemsList { get; internal set; }

        internal MenuItems GetItemByName(string mealName)
        {
            throw new NotImplementedException();
        }

        internal void AddItemToList(MenuItems newItem)
        {
            throw new NotImplementedException();
        }

        internal bool UpdateExistingItem(string oldMealName, MenuItems newItem)
        {
            throw new NotImplementedException();
        }

        internal bool RemoveItemFromList(string input)
        {
            throw new NotImplementedException();
        }

        internal List<MenuItems> GetItemsList()
        {
            throw new NotImplementedException();
        }
    }
}