using GoldBadgeChallenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge1Test
{
    [TestClass]
    public class MenuRepositoryTest
    {
        [TestMethod]
        public void AddMenu_WhenAddingAMenu_ShouldAddAMenu()
        {
            //Arrange
            MenuRepository testRepository = new MenuRepository();
            Menu menu = new Menu(1, "das", "a", new List<string> { "good", "one" }, 420.69);

            //Act
            testRepository.AddMenu(menu);

            //Assert
            Assert.AreEqual(1, testRepository.CurrentMenu.Count);
        }

        [TestMethod]
        public void RemoveMenu_WhenRemovingAMenu_ShouldRemoveAMenu()
        {
            //Arrange
            MenuRepository testRemoveRepo = new MenuRepository();
            Menu menu = BasicMenu(1);
            //Act
            testRemoveRepo.RemoveMenu(menu);
            //Assert
            Assert.AreEqual(0, testRemoveRepo.CurrentMenu.Count);
        }

        private static Menu BasicMenu(int menuID)
        {
            return new Menu(menuID, "das", "a", new List<string> { "good", "one" }, 420.69);
        }

        [TestMethod]
        public void RemoveMenuByID_WhenRemovingMenuByID_ShouldRemoveAMenuByID()
        {
            //Arrange
            MenuRepository testRemoveID = new MenuRepository();
            Menu menu = BasicMenu(1);
            testRemoveID.AddMenu(menu);
            //Act
            testRemoveID.RemoveMenuById(1);
            //Assert
            Assert.AreEqual(0, testRemoveID.CurrentMenu.Count);
        }

        [TestMethod]
        public void ListMenus_WhenMenusExist_ShouldReturnAStringOfListedMenus()
        {
            //Arrange
            MenuRepository testListRepo = new MenuRepository();
            Menu menu = new Menu(1, "das", "a", new List<string> { "good", "one" }, 420.69);
            testListRepo.AddMenu(menu);

            //Act
            string result = testListRepo.ListMenus();

            //Assert
            StringAssert.Contains(result, $"Menu Number: 1,\n" +
                $"Meal name: das,\n" +
                $"Description: a,\n" +
                $"$420.69,\n" +
                $"Ingredients:\n" +
                $"good{Environment.NewLine}" +
                $"one");
        }
    }
}
