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

        public void ListMenus()
        {
            foreach (Menu newMenu in Menus)
            {
                Console.WriteLine($"{newMenu}");
            }
        }

    }
}
