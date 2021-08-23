using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    
    //Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    class Program
    {
        static int MenuCount = 1;
        static void Main(string[] args)
        {
            MenuRepository listOfMenus = new MenuRepository();
            var running = true;
            StringBuilder menuOptions = new StringBuilder();
            menuOptions.AppendLine("1. Add a Meal");
            menuOptions.AppendLine("2. Look Up a Meal");
            menuOptions.AppendLine("3. Remove a Meal");
            menuOptions.AppendLine("4. Quit");

            while (running)
            {
                var chosenAction = prompt(menuOptions.ToString());
                Console.WriteLine();
                if (chosenAction == "1")
                {
                    var usermenu = EnterMenu();
                    AddMenuItem(usermenu, listOfMenus);
                }
                else if (chosenAction == "2")
                {
                    Console.WriteLine(listOfMenus.ListMenus());
                    Console.ReadLine();
                }
                else if (chosenAction == "3")
                {
                    var removeId = prompt("Which Number Would You like to Remove? ");
                        listOfMenus.RemoveMenuById(int.Parse(removeId));
                }
                else if(chosenAction == "4")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Could Not Recognize Command");
                }
                
            }
            
            // a ui for the manager to access and use the repository

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
