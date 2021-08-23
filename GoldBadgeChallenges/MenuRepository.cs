using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenges
{
    public class MenuRepository
    {
        List<Menu> Menus = new List<Menu>();
        public IReadOnlyList<Menu> CurrentMenu => this.Menus;
        public void AddMenu(Menu newMenu)
        {
            Menus.Add(newMenu);

        }

        public void RemoveMenu(Menu menu)
        {
            Menus.Remove(menu);
        }

        public void RemoveMenuById(int menuNum)
        {
            var result = Menus.First(m => m.menuNumber == menuNum);
            RemoveMenu(result);
        }

        public string ListMenus()
        {
            var menuItems = new StringBuilder();
            foreach (Menu newMenu in Menus)
            {
                menuItems.AppendLine(newMenu.ToString());
                //Console.WriteLine($"{newMenu}");
            }

            // Append: string.Empty + "TheInformationYouAdded" + "Morestuff"
            // AppendLine: "TheInformationYouAdded" + "/n" + "MoreStuff
            return menuItems.ToString();
        }

    }
}
