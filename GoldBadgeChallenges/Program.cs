using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    //Create a MenuRepository Class that has methods needed.
    //Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    //Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
    class Program
    {
        static void Main(string[] args)
        {

            //be able to put in a single menu and output all menus
            // a ui for the manager to access and use the repository

            var menu = MakeMenu();
            var menu2 = MakeMenu(2);
            var usermenu = EnterMenu(3);
            MenuRepository listOfMenus = new MenuRepository();
            listOfMenus.AddMenu(menu);
            listOfMenus.AddMenu(menu2);
            listOfMenus.AddMenu(usermenu);
            listOfMenus.ListMenus();

            Console.ReadLine();
        }

        private static Menu MakeMenu()
        {
            var menuNum = 1;
            var mealName = "Spaghetti and Meatballs";
            var foodDesc = "Its mom's spaghetti";
            var ingredients = new List<string> { "spaghetti", "meatballs" };
            var price = 1.00;
            
            var menu = new Menu(menuNum, mealName, foodDesc, ingredients, price);
            return menu;
            

        }
        private static Menu MakeMenu(int menuNum)
        {
            var mealName = $"{menuNum}Spaghetti and Meatballs";
            var foodDesc = $"{menuNum}Its mom's spaghetti";
            var ingredients = new List<string> { "spaghetti", "meatballs" };
            var price = 1.00;

            var menu = new Menu(menuNum, mealName, foodDesc, ingredients, price);
            return menu;


        }
        private static Menu EnterMenu(int menuNum)
        {
      
            var mealName = prompt("enter meal name");


            var foodDesc = prompt("enter description of meal");
            var ingredients = new List<string> { "spaghetti", "meatballs" };
            var price = int.Parse(prompt("enter the price"));

            var menu = new Menu(menuNum, mealName, foodDesc, ingredients, price);
            return menu;


        }
        private static string prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
    }
}
