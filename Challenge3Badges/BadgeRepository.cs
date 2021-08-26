using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Badges
{
    public class BadgeRepository
    {
       
       public Dictionary<int, List<string>> DictionaryOfBadges = new Dictionary<int, List<string>>();
        

        public void AddBadge(Badge newBadge)
        {
            DictionaryOfBadges.Add(newBadge.badgeID, new List<string>());
        }

        public void AddDoorToBadge(int badgeId, string door)
        {
            
            if (!DictionaryOfBadges.ContainsKey(badgeId))
            {
                DictionaryOfBadges.Add(badgeId, new List<string>());                
            }
            if(DictionaryOfBadges[badgeId] == null)
            {
                DictionaryOfBadges[badgeId] = new List<string>();
            }
            DictionaryOfBadges[badgeId].Add(door);

            

        }
        public Badge GetBadge(int badgeId)
        {
            Badge badgeToBeGot = new Badge();
            badgeToBeGot.badgeID = badgeId;
            badgeToBeGot.DoorAccess = DictionaryOfBadges[badgeId];

            return badgeToBeGot;
        }

        public string ListBadges()
        {
            var badgeItems = new StringBuilder();
            Console.WriteLine("ID#\t Door Access");
            foreach(KeyValuePair<int, List<string>> badge in DictionaryOfBadges)
            {
                badgeItems.Append($"{badge.Key.ToString()}\t");
                foreach(var door in badge.Value)
                {
                   badgeItems.Append($"{door}, ");
                }
                badgeItems.AppendLine();
                
                //badgeItems.AppendLine(badge.ToString());
            }
            return badgeItems.ToString();
        }
        
        public void RemoveDoorFromBadge(Badge badge, string door)
        {
            var badgeId = badge.badgeID;
            DictionaryOfBadges[badgeId].Remove(door);
        }
        public void RemoveAllDoorsFromBadge(Badge badge)
        {
            DictionaryOfBadges[badge.badgeID].Clear();
        }
    }
}
