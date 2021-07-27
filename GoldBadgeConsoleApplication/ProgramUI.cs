using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeOne_Repo;

namespace GoldBadgeConsoleApplication
{
    class ProgramUI
    {
        private MenuItemsRepo _itemRepo = new MenuItemsRepo();

        //method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display options to user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create a New Meal Option \n" +
                    "2. View All Meal Options \n" +
                    "3. Find Meal by Name \n" +
                    "4. Update Existing Meal \n" +
                    "5. Delete Existing Meal \n" +
                    "6. Exit" +
                    "");

                // Get the user's input
                string input = Console.ReadLine();

                // Evalute the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new content
                        CreateNewItem();
                        break;
                    case "2":
                        // View all content
                        DisplayAllItems();
                        break;
                    case "3":
                        // View content by name
                        DisplayItemByName();
                        break;
                    case "4":
                        // update existing content
                        UpdateExistingItem();
                        break;
                    case "5":
                        // delete existing content
                        DeleteExistingItem();
                        break;

                    case "6":
                        // exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid entry.");
                        break;


                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new DeveloperInfo
        private void CreateNewItem()
        {
            Console.Clear();
            MenuItems newItem = new MenuItems();

            Console.WriteLine("Enter in the desired meal number:");
            string numberAsString = Console.ReadLine();
            newItem.MealNumber = int.Parse(numberAsString);

            Console.WriteLine("Enter the name of the meal:");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter the meal's description:");
            newItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter the meal's ingrediants:");
            newItem.MealIngrediants = Console.ReadLine();

            Console.WriteLine("Enter in the price of the meal:");
            string priceAsString = Console.ReadLine();
            newItem.MealPrice = double.Parse(priceAsString);

            _itemRepo.AddItemsToList(newItem);
        }




        //View Current DeveloperInfo that is saved
        private void DisplayAllItems()
        {
            List<MenuItems> listOfItems = _itemRepo.GetItemsList();

            foreach (MenuItems item in listOfItems)
            {
                Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                    $"Meal Name: {item.MealName}\n"+
                    $"Meal Description: {item.MealDescription}\n" +
                    $"Meal Ingredients: {item.MealIngrediants}\n" +
                    $"Meal Price: {item.MealPrice}");
            }
        }

        //View existing Content by Name
        private void DisplayItemByName()
        {
            Console.Clear();
            //prompt the user to give me a name
            Console.WriteLine("Enter the name of the meal: ");

            //get the users input
            string MealName = Console.ReadLine();

            //find the user by that title
            MenuItems item = _itemRepo.GetItemByName(MealName);

            //display said user if not null
            if (item != null)
            {
                Console.WriteLine($"Meal Name: {item.MealName}\n" +
                    $"Meal Number: {item.MealNumber}\n" +
                    $"Meal Description: {item.MealDescription}\n" +
                    $"Meal Ingredients: {item.MealIngrediants}\n" +
                    $"Meal Price {item.MealPrice}");
            }
            else
            {
                Console.WriteLine("This meal does not currently exist.");
            }
        }

        private MenuItems DisplayItemByName(object name)
        {
            throw new NotImplementedException();
        }

        //Update Existing Content
        private void UpdateExistingItem()
        {
            // display all content
            DisplayAllItems();
            // ask for the name of the developer to update
            Console.WriteLine("Enter the name of the meal that you would like to update: ");
            // get that name
            string oldMealName = Console.ReadLine();

            // build a new object
            MenuItems newItem = new MenuItems();

            Console.WriteLine("Enter the name of the meal:");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter the meal number:");
            string numberAsString = Console.ReadLine();
            newItem.MealNumber = int.Parse(numberAsString);

            Console.WriteLine("Enter in the description of the meal: ");
            newItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter in the ingredients of the meal: ");
            newItem.MealIngrediants = Console.ReadLine();

            Console.WriteLine("Enter in the price of the meal: ");
            string priceAsString = Console.ReadLine();
            newItem.MealPrice = Convert.ToDouble(priceAsString);



            //verify
            bool wasUpdated = _itemRepo.UpdateExistingItem(oldMealName, newItem);


            if (wasUpdated)
            {
                Console.WriteLine("This meal has been successfully updated!");
            }
            else
            {
                Console.WriteLine("This meal could not be updated");
            }
        }

        //Delete Existing Content
        private void DeleteExistingItem()
        {


            DisplayAllItems();


            // get the name they want to delete
            Console.WriteLine("\nEnter the name of the meal that you would like to remove:");

            string input = Console.ReadLine();

            //call the delete method
            bool wasDeleted = _itemRepo.RemoveItemFromList(input);


            // if the content was deleted, say so
            // otherwise state it could not be deleted
            if (wasDeleted)
            {
                Console.WriteLine("This meal has been deleted from the database.");
            }
            else
            {
                Console.WriteLine("The meal could not be deleted from the database.");
            }




        }

        //See method
        private void SeedContentList()
        {
            MenuItems chocolateDonut = new MenuItems(555, "Chocolate Donut", "A  big, chocolatey donut lightly glazed and filled with chocolate cream.", "flour, cocoa powder, granulated sugar, baking powder, salt, eggs, whole milk, butter, vegetable oil, vanilla, powdered sugar, vanilla extract, milk", 2.99);
            MenuItems everythingBagel = new MenuItems(111, "Everything Bagel", "A freshly made bagel with everything seasoning.", "water, instant yeast, bread flour, granulated sugar, salt, vegetable oil, honey, cornmeal, everything seasoning", 1.50);
            MenuItems veggiePanini = new MenuItems(222,"Veggie Panini", "A delicious panini with cheese and a variety of chopped vegetables.", "sourdough bread, light mayo, butter, colby jack cheese, spinach, tomoatoes, avocado", 5.99);
            MenuItems cinnamonStreuselMuffin = new MenuItems(333, "Cinnamon Streusel Muffin", "A cinnamon muffin topped with a brown sugar, cinnamon crumble.", "flour, brown sugar, unsalted butter, sugar, eggs, whole milk, vanilla extract, baking powder", 1.99);
            MenuItems cafeAuLait = new MenuItems(444, "Cafe Au Lait", "A creamy but strong coffee", "french roast coffee, steamed milk", 1.79);
            



            _itemRepo.AddItemsToList(chocolateDonut);
            _itemRepo.AddItemsToList(everythingBagel);
            _itemRepo.AddItemsToList(veggiePanini);
            _itemRepo.AddItemsToList(cinnamonStreuselMuffin);
            _itemRepo.AddItemsToList(cafeAuLait);
           

        }
    }
}
