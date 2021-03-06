using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    //input - get data from something
    //work - what you do with the input
    //output - showing to the user
    public class Menu 
    {
        public int menuNumber { get; }
        string mealName { get; }
        string foodDesc { get; }
        List<string> ingredients { get; }
        double price { get; }

        public Menu(int menuNum, string mealName, string foodDesc, List<string> ingredients, double price)
        {
            this.menuNumber = menuNum;
            this.mealName = mealName;
            this.foodDesc = foodDesc;
            this.ingredients = ingredients;
            this.price = price;
            
        }
        public override string ToString()
        {
            StringBuilder ingredientList = new StringBuilder();
            foreach (var ingredient in ingredients)
            {
                ingredientList.AppendLine($"{ingredient}");
            }
            return $"Menu Number: {menuNumber},\n" +
                $"Meal name: {mealName},\n" +
                $"Description: {foodDesc},\n" +
                $"${price},\n" +
                $"Ingredients:\n" +
                $"{ingredientList.ToString()}";
        }

    }
}
