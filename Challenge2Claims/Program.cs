using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    //Create a Claim class with properties, constructors, and any necessary fields.
    //Create a ClaimRepository class that has proper methods.
    //Create a Test Class for your repository methods.
    //Create a Program file that allows a claims manager to manage items in a list of claims.
    class Program
    {
        static int ClaimCount = 1;
        static void Main(string[] args)
        {
            ClaimRepository listOfClaims = new ClaimRepository();
            var running = true;
            StringBuilder ClaimOptions = new StringBuilder();
            ClaimOptions.AppendLine("1. Add a Claim");
            ClaimOptions.AppendLine("2. Look Up a Claim");
            ClaimOptions.AppendLine("3. Deal with Claim");
            ClaimOptions.AppendLine("4. Quit");
            while (running)
            {
                var chosenAction = prompt(ClaimOptions.ToString());
                Console.WriteLine();
                if (chosenAction == "1")
                {
                    var userClaim = EnterClaim();
                    AddClaimItem(userClaim, listOfClaims);
                }
                else if (chosenAction == "2")
                {
                    Console.WriteLine(listOfClaims.ListClaims());
                    Console.ReadLine();
                }
                else if (chosenAction == "3")
                {
                    Console.WriteLine("Here are the details for the next claim to be handled");
                    Console.WriteLine(listOfClaims.DealClaim());
                    var claimDeal = prompt("Do you want to deal with this claim now y/n?");
                    if (claimDeal == "y")
                    {
                        listOfClaims.RemoveClaimFromTop(); 
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

        private static Claim EnterClaim()
        {

            var claimID = ClaimCount;    
            var claimDesc = prompt("enter description of Claim");
            var claimType = TypeEntry();
            var claimAmount = double.Parse(prompt("enter the Claim Amount"));
            var DateOfIncident = DateTime.Parse(prompt("Please enter the date of the incident: XX/XX/XXXX"));
            var DateOfClaim = DateTime.Parse(prompt("Please enter the date of the Claim: XX/XX/XXXX"));
            var time = DateOfIncident - DateOfClaim;
            var Isvalid = time.Days <= 30;

            var claim = new Claim(claimID, claimType, claimDesc, claimAmount, DateOfIncident, DateOfClaim);
                return claim;


        }

            private static void AddClaimItem(Claim claim, ClaimRepository listOfClaims)
        {
            listOfClaims.AddClaim(claim);
            ClaimCount++;
        }
        private static string prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower();

        }
        private static string TypeEntry()
        {
            string Types = "unassigned";
            Console.WriteLine("please enter Claim Type: Car, Home, or Theft.");
            bool enteringType = true;
            while (enteringType)
            { 
                Types = Console.ReadLine().ToLower();
                if (Types == "car")
                {                   
                    enteringType = false;
                }
                else if (Types == "home")
                {                    
                    enteringType = false;
                }
                else if (Types == "theft")
                {                    
                    enteringType = false;
                    
                }
                else
                {
                    Console.WriteLine("Invalid Type try again");

                }

            }
            return Types;
        }
    }
}
