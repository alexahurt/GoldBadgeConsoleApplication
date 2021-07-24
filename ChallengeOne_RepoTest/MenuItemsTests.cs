using System;
using ChallengeOne_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOne_RepoTest
{
    [TestClass]
    public class MenuItemsTests 
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            MenuItems item = new MenuItems();

            item.MealName = "Chocolate Donut";

            string expected = "Chocolate Donut";
            string actual = item.MealName;

            Assert.AreEqual(expected, actual);
        }

       
    }
}
