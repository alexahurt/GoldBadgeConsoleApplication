using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeTwo_Repo;

namespace ChallengeTwo_ConsoleApp
{
    class ProgramUI
    {
        private ClaimsRepo _itemRepo = new ClaimsRepo();
        // Queue<Claims> claimsQueue = new Queue<Claims>(); 

        public object ClaimNumber { get; private set; }

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
                    "1. Enter a new Claim \n" +
                    "2. View All Claims \n" +
                    "3. Resolve Next Claim \n" +
                   
                    "");

                // Get the user's input
                string input = Console.ReadLine();

                // Evalute the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create new content
                        CreateNewClaim();
                        break;
                    case "2":
                        // View all content
                        DisplayAllClaims();
                        break;
                    case "3":
                        // View content by name
                        ResolveNextClaim();
                        break;

                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new DeveloperInfo
        private void CreateNewClaim()
        {
            Console.Clear();
            Claims newItem = new Claims();

            Console.WriteLine("Enter in the claim number:");
            string numberAsString = Console.ReadLine();
            newItem.ClaimNumber = int.Parse(numberAsString);

            Console.WriteLine("Enter the Claim Type Number:\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            string claimAsString = Console.ReadLine();
            int claimAsInt = int.Parse(claimAsString);
            newItem.TypeOfClaim = (ClaimType)claimAsInt;

            Console.WriteLine("Enter the Claim Description:");
            newItem.ClaimDescription = Console.ReadLine();

            Console.WriteLine("Enter the Claim Cost:");
            string costAsString = Console.ReadLine();
            newItem.ClaimCost = int.Parse(costAsString);

            DateTime ClaimDate;
            Console.WriteLine("Enter in the Date of the Incident:");
            ClaimDate = DateTime.Parse(Console.ReadLine());

           
            Console.WriteLine("Is this a valid claim? (Y or N)");
            string validClaimString = Console.ReadLine(); 
            if(validClaimString == "y")
            {
                newItem.IsClaimValid = true;
            }
            else
            {
                newItem.IsClaimValid = false;
            }

            _itemRepo.AddClaimsToList(newItem);
        }




        //View Current DeveloperInfo that is saved
        private void DisplayAllClaims()
        {
            List<Claims> listOfItems = _itemRepo.GetClaimsList();

            foreach (Claims item in listOfItems)
            {
                Console.WriteLine($"Claim Number: {item.ClaimNumber}\n" +
                    $"Claim Type: {item.TypeOfClaim}\n" +
                    $"Claim Description: {item.ClaimDescription}\n" +
                    $"Claim Cost: {item.ClaimCost}\n" +
                    $"Date of Incident: {item.IncidentDate}\n" +
                    $"Claim Date: {item.ClaimDate}\n" +
                    $"Is this Claim Valid? {item.IsClaimValid}");
            }
        }
        


        //View existing Content by Name

        //Go to next claim
        static void ResolveNextClaim()
      
        {
            Console.Clear();

            Claims one = new Claims(55555, ClaimType.Car, "Fender Bender", 500, new DateTime(07 / 22 / 2021), new DateTime(07 / 23 / 2021), true);
            Claims two = new Claims(11111, ClaimType.Home, "Faulty wiring", 900, new DateTime(07 / 21 / 2021), new DateTime(07 / 23 / 2021), false);
            Claims three = new Claims(22222, ClaimType.Theft, "Jewelry stolen", 200, new DateTime(07 / 18 / 2021), new DateTime(07 / 23 / 2021), true);
            Claims four = new Claims(33333, ClaimType.Car, "Cracked windshield after a bird hit it.", 400, new DateTime(07 / 20 / 2021), new DateTime(07 / 24 / 2021), false);
            Claims five = new Claims(44444, ClaimType.Home, "Someone broke in through the backdoor", 600, new DateTime(07 / 25 / 2021), new DateTime(07 / 26 / 2021), true);
            

            Queue<Claims> claimsQueue = new Queue<Claims>();

            Console.WriteLine("Claim's Queue:");

            /// Console.WriteLine("Claim one" + {one} );
           
            claimsQueue.Enqueue(one);
            

            Console.WriteLine("Second Claim, type two");
            claimsQueue.Enqueue(two);

            Console.WriteLine("Third Claim, type three");
            claimsQueue.Enqueue(three);

            Console.WriteLine("Fourth Claim, type four");
            claimsQueue.Enqueue(four);

            Console.WriteLine("Fifth Claim, type five");
            claimsQueue.Enqueue(five);

            Console.ReadLine();

            






        }

        static Claims[] ReceivedClaims()
        {
            Claims[] claims = new Claims[]
            {
                new Claims(55555, ClaimType.Car, "Car accident on 465", 700, new DateTime (07/20/2021), new DateTime (07/22/2021), true),
                new Claims(44444, ClaimType.Home, "Basement Flooding", 850, new DateTime (07/15/2021), new DateTime (07/20/2021), false),
                new Claims(33333, ClaimType.Theft, "All cheese was stolen", 500, new DateTime (07/13/2021), new DateTime (07/18/2021), true)
            };
            return claims;
        }

       

        //Update Existing Content
        

        //Delete Existing Content
       

        //See method
        private void SeedContentList()
        {
            Claims one = new Claims(55555, ClaimType.Car, "Fender Bender", 500, new DateTime (07/22/2021), new DateTime (07/23/2021), true);
            Claims two = new Claims(11111, ClaimType.Home, "Faulty wiring", 900, new DateTime(07 / 21 / 2021), new DateTime(07 / 23 / 2021), false);
            Claims three = new Claims(22222, ClaimType.Theft, "Jewelry stolen", 200, new DateTime(07 / 18 / 2021), new DateTime(07 / 23 / 2021), true);
            Claims four = new Claims(33333, ClaimType.Car, "Cracked windshield after a bird hit it.", 400, new DateTime(07 / 20 / 2021), new DateTime(07 / 24 / 2021), false);
            Claims five = new Claims(44444, ClaimType.Home, "Someone broke in through the backdoor", 600, new DateTime(07 / 25 / 2021), new DateTime(07 / 26 / 2021), true);




            _itemRepo.AddClaimsToList(one);
            _itemRepo.AddClaimsToList(two);
            _itemRepo.AddClaimsToList(three);
            _itemRepo.AddClaimsToList(four);
            _itemRepo.AddClaimsToList(five);


        }

        public void ProcessClaim()
        {
            Claims one = new Claims(55555, ClaimType.Car, "Fender Bender", 500, new DateTime(07 / 22 / 2021), new DateTime(07 / 23 / 2021), true);
            Claims two = new Claims(11111, ClaimType.Home, "Faulty wiring", 900, new DateTime(07 / 21 / 2021), new DateTime(07 / 23 / 2021), false);
            Claims three = new Claims(22222, ClaimType.Theft, "Jewelry stolen", 200, new DateTime(07 / 18 / 2021), new DateTime(07 / 23 / 2021), true);
            Claims four = new Claims(33333, ClaimType.Car, "Cracked windshield after a bird hit it.", 400, new DateTime(07 / 20 / 2021), new DateTime(07 / 24 / 2021), false);
            Claims five = new Claims(44444, ClaimType.Home, "Someone broke in through the backdoor", 600, new DateTime(07 / 25 / 2021), new DateTime(07 / 26 / 2021), true);




            _itemRepo.AddClaimsToList(one);
            _itemRepo.AddClaimsToList(two);
            _itemRepo.AddClaimsToList(three);
            _itemRepo.AddClaimsToList(four);
            _itemRepo.AddClaimsToList(five);
        }

        

        
        

    }
}