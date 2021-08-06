using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeThree_Rep;

namespace ChallengeThree_Console
{
    class ProgramUI
    {
        private Badges_Repo _badgeRepo = new Badges_Repo();

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                Console.WriteLine("Hello Security Admin, What would you like to do?\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List all Badges\n" +
                    "");

                string input = Console.ReadLine();

                
                

                switch (input)
                {
                    case "1":
                        CreateNewBadge();
                        break;

                    case "2":
                        UpdateBadgeDoors();
                        break;

                    case "3":
                        GetBadgeList();
                        break;

                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        //create new Badge
        private void CreateNewBadge()
        {
            Console.Clear();
            Badges newBadge = new Badges();

            Console.WriteLine("What is the number on the badge:");
            string idAsString = Console.ReadLine();
            newBadge.BadgeID = int.Parse(idAsString);

            Console.WriteLine("List a door that it needs access to: ");
            newBadge.DoorName = Console.ReadLine();

            Console.WriteLine("Any other doors(y/n)?");
            string otherDoorsString = Console.ReadLine().ToLower();
            if (otherDoorsString == "yes")
            {
                newBadge.OtherDoors = true;
            }
            else
            {
                newBadge.OtherDoors = false;
            }


            Console.WriteLine("Enter in the badge name:");
            newBadge.BadgeName = Console.ReadLine();



            _badgeRepo.AddBadgeToList(newBadge);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void UpdateBadgeDoors()
        {
            GetBadgeList();

            Badges badgeID = new Badges();
            Badges doorName = new Badges();

            Console.WriteLine("What is the badge number that you would like to update?");

            string idAsString = Console.ReadLine();
            badgeID.BadgeID = int.Parse(idAsString);

            //Badges newDoor = new Badges();

            //Console.WriteLine("Enter in the badge ID:");
            //newDoor.DoorName = Console.ReadLine();

           
            Dictionary<int, string> badgeDictionary = new Dictionary<int, string>();
            badgeDictionary.Add(12345, "Door A, Door B, Door C");
            badgeDictionary.Add(23456, "Door D, Door E, Door F");
            badgeDictionary.Add(34567, "Door G, Door H, Door I");
            badgeDictionary.Add(45678, "Door J, Door K, Door L");
            badgeDictionary.Add(56789, "Door M, Door N, Door O");

            if (badgeID != null)
            {
                Console.WriteLine($"Badge ID: {badgeID.BadgeID}\n" +
                    $"Door Name: {doorName.DoorName}");
            }
            else
            {
                Console.WriteLine("There is no badge by that ID.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What would you like to do?\n" +
                    "1. Remove a door\n" +
                    "2. Add a door\n" +             
                    "");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RemoveDoorsFromBadge();
                    break;

                case "2":
                    AddDoorToBadge();
                    break;

            }



             void RemoveDoorsFromBadge()
            {
                
                //GetDoorByBadgeID();

                Console.WriteLine("Which door would you like to remove?");
                

                string getDoorName = Console.ReadLine();

                bool wasDeleted = _badgeRepo.RemoveDoorsFromBadge(getDoorName);

                if (wasDeleted)
                {
                    Console.WriteLine("This door has been removed");
                }
                else
                {
                    Console.WriteLine("This door could not be deleted");
                }


            }

           // Console.WriteLine("Press any key to continue...");
           // Console.ReadKey();
           // Console.Clear();

             void AddDoorToBadge()
            { 

                Badges newDoor = new Badges();
                Console.WriteLine("Enter the name of the door: ");

                newDoor.DoorName = Console.ReadLine();

                _badgeRepo.AddDoorToBadge(newDoor);

                
            }



        }

        private void GetBadgeList()
        {
            //Dictionary<int, string> badgeDictionary = new Dictionary<int, string>();

            //foreach (KeyValuePair<int, string> kvp in badgeDictionary)
            // {
            // Console.WriteLine("Key = {0}, Value = {1}",
            //kvp.Key, kvp.Value);
            // }

            List<Badges> listOfBadges = _badgeRepo.GetBadgeList();

            foreach(Badges badge in listOfBadges)
            {
                Console.WriteLine($"Badge ID: {badge.BadgeID}\n" +
                    $"Badge Name: {badge.BadgeName}\n" +
                    $"Door Access: {badge.DoorName}\n" +
                    $"Other Door access? {badge.OtherDoors}");
            }
        }

        private void SeedContentList()
        {
            Badges badgeOne = new Badges(12345, "Badge One", "Door A, Door F", false);
            Badges badgeTwo = new Badges(23456, "Badge Two", "Door B, Door X", false);
            Badges badgeThree = new Badges(34567, "Badge Three", "Door C", false);
            Badges badgeFour = new Badges(45678, "Badge Four", "Door D, Door M, Door Z, Door K", false);
            Badges badgeFive = new Badges(56789, "Badge Five", "Door E", false);

            _badgeRepo.AddBadgeToList(badgeOne);
            _badgeRepo.AddBadgeToList(badgeTwo);
            _badgeRepo.AddBadgeToList(badgeThree);
            _badgeRepo.AddBadgeToList(badgeFour);
            _badgeRepo.AddBadgeToList(badgeFive);

        }


    }
}
