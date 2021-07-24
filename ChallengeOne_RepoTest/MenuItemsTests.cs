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

        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectInt()
        {
            MenuItems item = new MenuItems();

            item.MealNumber = 555;

            int expected = 555;
            int actual = item.MealNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealDescription_ShouldSetCorrectString()
        {
            MenuItems item = new MenuItems();

            item.MealDescription = "A  big, chocolatey donut lihgtly glazed and filled with chocolate cream.";

            string expected = "A  big, chocolatey donut lihgtly glazed and filled with chocolate cream.";
            string actual = item.MealDescription;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealIngrediants_ShouldSetCorrectString()
        {
            MenuItems item = new MenuItems();

            item.MealIngrediants = "A  big, chocolatey donut lihgtly glazed and filled with chocolate cream.";

            string expected = "A  big, chocolatey donut lihgtly glazed and filled with chocolate cream.";
            string actual = item.MealDescription;

            Assert.AreEqual(expected, actual);
        }

    }
}
