using Challenge3Badges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge3Test
{
    [TestClass]
    public class BadgeRepositoryTest
    {
        private static Badge MakeBasicBadge()
        {
            return new Badge(1);
        }
        [TestMethod]
        public void AddBadgeTest_WhenAddingABadge_ShouldAddABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act
            testRepository.AddBadge(badge);
            //Assert
            Assert.AreEqual(1, testRepository.DictionaryOfBadges.Count);

        }
        [TestMethod]
        public void AddDoorToBadgeTest_WhenAddingDoorToBadge_ShouldAddDoorToBadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            MakeBasicBadge();
            //Act
            testRepository.AddDoorToBadge(1, "a1");
            Badge testBadge = testRepository.GetBadge(1);
            //Assert
            // Assert the Badge ID is correct. Then Assert that the list contains the correct door.
            Assert.AreEqual(1,testBadge.badgeID);
            bool containsDoor = testBadge.DoorAccess.Contains("a1");
            Assert.IsTrue(containsDoor);

        }
        [TestMethod]
        public void GetBadgeTest_WhenGetBadge_ShouldReceiveABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act
            testRepository.AddBadge(badge);
            testRepository.GetBadge(1);
            //Assert
            
            Assert.AreEqual(true, testRepository.DictionaryOfBadges.ContainsKey(1));

        }
        [TestMethod]
        public void ListBadgesTest_WhenListBadges_ShouldListAllBadges()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act
            testRepository.AddBadge(badge);
            testRepository.AddDoorToBadge(1, "a1");
            string result = testRepository.ListBadges();
            //Assert
            StringAssert.Contains(result,  "1", "a1,");
        }
        [TestMethod]
        public void RemoveDoorFromBadgeTest_WhenRemoveDoorFromBadge_ShouldRemoveADoorFromABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            
            //Act
            Badge testBadge = testRepository.GetBadge(1);
            testRepository.AddDoorToBadge(1, "a1");
            testRepository.RemoveDoorFromBadge(testBadge, "a1");
            //Assert
            Assert.AreEqual("1", testBadge.badgeID);
            bool containsEmptyList = testBadge.DoorAccess.Contains("");
            Assert.IsTrue(containsEmptyList);
        }
        [TestMethod]
        public void RemoveAllDoorsFromBadge_WhenRemoveAllDoorsFromBadge_ShouldRemoveAllDoorsFromABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act
            testRepository.AddBadge(badge);
            testRepository.AddDoorToBadge(1, "a1");
            testRepository.RemoveAllDoorsFromBadge(badge);
            //Assert
            Assert.AreEqual(1,badge.badgeID);
            bool containsEmptyList = badge.DoorAccess.Contains(" ");
            Assert.IsTrue(containsEmptyList);
        }
    }
}
