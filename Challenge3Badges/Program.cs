using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Badges
{
    //A badge class that has the following properties:
    //BadgeID
    //List of door names for access
    //A badge repository that will have methods that do the following:
    //Create a dictionary of badges.
    //The key for the dictionary will be the BadgeID.
    //The value for the dictionary will be the List of Door Names.
    //The Program will allow a security staff member to do the following:
    //create a new badge
    //update doors on an existing badge.
    //delete all doors from an existing badge.
    //show a list with all badge numbers and door access, like this:
    class Program
    {
        static int BadgeCount = 1;
        static void Main(string[] args)
        {
            BadgeRepository listOfBadges = new BadgeRepository();
            var running = true;
            StringBuilder BadgeOptions = new StringBuilder();
            Console.WriteLine("Hello Security Admin, what would you like to do?");
            BadgeOptions.AppendLine("1. Add a Badge");
            BadgeOptions.AppendLine("2. List all Badges");
            BadgeOptions.AppendLine("3. Edit a Badge");
            BadgeOptions.AppendLine("4. Quit");
            while (running)
            {
                var chosenAction = prompt(BadgeOptions.ToString());
                Console.WriteLine();
                if (chosenAction == "1")
                {
                    string confirmCreate = prompt("Do you wish to create a new badge? y/n").ToLower();
                    if (confirmCreate == "y")
                    {
                    var userBadge = EnterBadge();
                    AddBadgeItem(userBadge, listOfBadges);
                    
                    }
                }
                else if (chosenAction == "2")
                {
                    Console.WriteLine(listOfBadges.ListBadges());
                    Console.ReadLine();
                }
                else if (chosenAction == "3")
                {
                    int searchBadgeByID = int.Parse(prompt("What is the BadgeID to update?"));
                    Console.WriteLine($"{searchBadgeByID} has access to .\n What would you like to do?");
                    StringBuilder doorOptions = new StringBuilder();
                    doorOptions.AppendLine("1. Remove a Door");
                    doorOptions.AppendLine("2. Add a Door");
                    doorOptions.AppendLine("3. Remove ALL Doors");
                    doorOptions.AppendLine("4. Back");
                    var editing = true;
                    while (editing)
                    {
                        var editingOption = prompt(doorOptions.ToString());
                        Console.WriteLine();
                        if (editingOption == "1")
                        {
                            var doorToBeRemoved = prompt("Which door would you like to Remove?");
                            listOfBadges.RemoveDoorFromBadge(listOfBadges.GetBadge(searchBadgeByID), doorToBeRemoved);
                            editing = false;
                        }
                        else if (editingOption == "2")
                        {
                            var doorToBeAdded = prompt("What door would you like to add?");
                            listOfBadges.AddDoorToBadge(searchBadgeByID, doorToBeAdded);
                            editing = false;
                        }
                        else if (editingOption == "3")
                        {
                            var confirmRemoveAll = prompt($"{searchBadgeByID} is this the correct one to remove all access? y/n").ToLower();
                            if (confirmRemoveAll == "y")
                            {
                                listOfBadges.RemoveAllDoorsFromBadge(listOfBadges.GetBadge(searchBadgeByID));
                                
                            }
                            else
                            {
                                editing = false;
                            }
                            editing = false;
                        }
                        else if (editingOption == "4")
                        {
                            editing = false;
                        }
                        else
                        {
                            Console.WriteLine("Unrecognized please try again");
                        }
                    }
                }
                else if (chosenAction == "4")
                {
                    Console.WriteLine("Thank you, have a nice day!");
                    Console.ReadLine();
                    running = false;
                }
                else
                {
                    Console.WriteLine("Could Not Recognize Command");
                }
            }
        }
        private static Badge EnterBadge()
        {
            var badgeID = BadgeCount;
            var badge = new Badge();
            badge.badgeID = badgeID;
            return badge;
        }
        private static void AddBadgeItem(Badge badge, BadgeRepository listOfBadges)
        {
            listOfBadges.AddBadge(badge);
            BadgeCount++;
        }
        private static string prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower();
        }
                      
    }
}
