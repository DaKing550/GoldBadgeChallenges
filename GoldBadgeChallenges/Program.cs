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
        static int MenuCount = 0;
        static void Main(string[] args)
        {

            //be able to put in a single menu and output all menus
            // a ui for the manager to access and use the repository
            var usermenu = EnterMenu();
            MenuRepository listOfMenus = new MenuRepository();
            AddMenuItem(usermenu, listOfMenus);
            listOfMenus.ListMenus();
            Console.ReadLine();
        }

        private static void AddMenuItem(Menu menu, MenuRepository listOfMenus)
        {
            listOfMenus.AddMenu(menu);
            MenuCount++;
        }
        
        private static Menu EnterMenu()
        {
      
            var mealName = prompt("enter meal name");
            var foodDesc = prompt("enter description of meal");
            var ingredients = IngredientEntry();
            var price = double.Parse(prompt("enter the price"));

            var menu = new Menu(MenuCount, mealName, foodDesc, ingredients, price);
            return menu;


        }
        private static string prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
        private static List<string> IngredientEntry()
        {
            List<string> ingredients = new List<string>();
            bool addMoreToList = true;
            while (addMoreToList)
            {
                string ingredient = prompt("Add ingredients, leave blank to end");
                if(ingredient == string.Empty)
                {
                    addMoreToList = false;
                    
                }
                else
                {
                    ingredients.Add(ingredient);
                }
            }
            return ingredients;

        }
    }
}
