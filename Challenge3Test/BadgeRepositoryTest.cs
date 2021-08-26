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
            Badge badge = MakeBasicBadge();
            //Act

            //Assert

        }
        [TestMethod]
        public void GetBadgeTest_WhenGetBadge_ShouldReceiveABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act

            //Assert

        }
        [TestMethod]
        public void ListBadgesTest_WhenListBadges_ShouldListAllBadges()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act

            //Assert

        }
        [TestMethod]
        public void RemoveDoorFromBadgeTest_WhenRemoveDoorFromBadge_ShouldRemoveADoorFromABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act

            //Assert

        }
        [TestMethod]
        public void RemoveAllDoorsFromBadge_WhenRemoveAllDoorsFromBadge_ShouldRemoveAllDoorsFromABadge()
        {
            //Arrange
            BadgeRepository testRepository = new BadgeRepository();
            Badge badge = MakeBasicBadge();
            //Act

            //Assert

        }
    }
}
