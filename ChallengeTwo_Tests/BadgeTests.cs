using System;
using ChallengeThree_Rep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeThree_Tests
{
    [TestClass]
    public class BadgeTests
    {
        private Badges_Repo _repo;
        private Badges _badge;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new Badges_Repo();
            _badge = new Badges(12345, "Badge1", "DoorA");

            _repo.AddBadgeToList(_badge);
        }



        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            Badges badge = new Badges();
            badge.BadgeID = 12345;
            Badges_Repo repo = new Badges_Repo();

            repo.AddBadgeToList(badge);
            Badges badgeFromDictionary = repo.GetBadgeByID(12345);

            Assert.IsNotNull(badgeFromDictionary);
        }



        [TestMethod]
        public void UpdateBadgeDoors_ShouldReturnTrue()
        {
            Badges newDoor = new Badges(12345, "BadgeOne", "Door1");
            bool updateResult = _repo.UpdateBadgeDoors(12345, newDoor);
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void RemoveDoorsFromBadge_ShouldReturnTrue()
        {
            Badges newDoor = new Badges(12345, "Badgeone", "DoorB");
            bool deleteResult = _repo.RemoveDoorsFromBadge(12345);

            Assert.IsTrue(deleteResult);
        }
    }

}
