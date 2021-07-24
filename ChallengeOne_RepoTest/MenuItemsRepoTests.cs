using System;
using ChallengeOne_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeOne_RepoTest
{
    [TestClass]
    public class MenuItemsRepoTests
    {
        public MenuItemsRepo _repo;


        private MenuItems _item;





        //Add Method
        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuItemsRepo();
            _item = new MenuItems(555, "Chocolate Donut", "A  big, chocolatey donut lightly glazed and filled with chocolate cream.", "flour, cocoa powder, granulated sugar, baking powder, salt, eggs, whole milk, butter, vegetable oil, vanilla, powdered sugar, vanilla extract, milk", 2.99);

            _repo.AddItemsToList(_item);
        }

        [TestMethod]
        public void AddtoList_ShouldGetNotNull()
        {
            MenuItems item = new MenuItems();
            item.MealName = "Chocolate Donut";
            MenuItemsRepo repository = new MenuItemsRepo();

            repository.AddItemsToList(item);
            MenuItems itemFromDirectory = repository.GetItemByName("Chocolate Donut");

            Assert.IsNotNull(itemFromDirectory);
        }


        [TestMethod]
        public void UpdateExistingItem_ShouldReturnTrue()
        {
            MenuItems newItem = new MenuItems(777, "Classic Donut", "A  big donut lightly glazed and filled with vanilla cream.", "flour, granulated sugar, baking powder, salt, eggs, whole milk, butter, vegetable oil, vanilla, powdered sugar, vanilla extract, milk", 1.99);


            bool updateResult = _repo.UpdateExistingItem("Chocolate Donut", newItem);

            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteItem_ShouldReturnTrue()
        {
            MenuItems newItem = new MenuItems(555, "Chocolate Donut", "A  big, chocolatey donut lightly glazed and filled with chocolate cream.", "flour, cocoa powder, granulated sugar, baking powder, salt, eggs, whole milk, butter, vegetable oil, vanilla, powdered sugar, vanilla extract, milk", 2.99);
            bool deleteResult = _repo.RemoveItemFromList(_item.MealName);
            Assert.IsTrue(deleteResult);
        }
    }
}
