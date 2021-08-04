using System;
using System.Collections.Generic;
using ChallengeTwo_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwo_RepoTests
{
    [TestClass]
    public class ClaimsTests
    {
        private ClaimsRepo _repo;
        private Claims _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimsRepo();
            _content = new Claims(12345, ClaimType.Car, "Car accident on 465.", 500,  new DateTime(2021, 7, 20), new DateTime(2021, 7, 21), true) ;

            _repo.AddClaimsToList(_content);
        }
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Claims content = new Claims();
            content.ClaimNumber = 12345;
            ClaimsRepo repository = new ClaimsRepo();

            // Act --> Get/run the code we want to test
            repository.AddClaimsToList(content);
            Claims contentFromDirectory = repository.GetClaimByNumber(12345);

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);
        }

        //Update
        [TestMethod]
        public void UpdateExistingClaim_ShouldReturnTrue()
        {
            // Arrange
            // TestInitialize
            Claims newContent = new Claims(12345, ClaimType.Car, "Car accident on 465.", 500, new DateTime(2021, 7, 20), new DateTime(2021, 7, 21), true);

            // Act
            bool updateResult = _repo.UpdateExistingClaim(12345, newContent);

            // Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow(12345, true)]
        [DataRow(54321, false)]
        [DataRow(55555, false)]
        [DataRow(11111, false)]
        public void UpdateExistingClaim_ShouldMatchGivenBool(int originalNumber, bool shouldUpdate)
        {
            // Arrange
            // TestInitialize
            Claims newContent = new Claims(12345, ClaimType.Home, "Home break in.", 350, new DateTime(2021, 7, 20), new DateTime(2021, 7, 21), new DateTime(2021, 7, 21), true);

            // Act
            bool updateResult = _repo.UpdateExistingClaim(originalNumber, newContent);

            // Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange
            Claims newContent = new Claims(12345, ClaimType.Car, "Car accident on 465.", 500, new DateTime(2021, 7, 20), true);
            //Act
            bool deleteResult = _repo.RemoveClaimFromList(_content.ClaimNumber);

            //Assert
            Assert.IsTrue(deleteResult);
        }

        [TestMethod]
        public void ResolveNextClaim()
        {
            Console.Clear();

            Queue<Claims> claimsQueue = new Queue<Claims>();

            foreach (Claims c in ReceivedClaims())
            {
                claimsQueue.Enqueue(c);
            }

            while (claimsQueue.Count > 0)
            {
                Claims currentClaim = claimsQueue.Dequeue();

                currentClaim.ProcessClaim();
            }


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

    }
}

