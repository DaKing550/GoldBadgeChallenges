using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    //1. Create a Claim class with properties, constructors, and any necessary fields.
    //2. Create a ClaimRepository class that has proper methods.
    //3. Create a Test Class for your repository methods.
    //4. Create a Program file that allows a claims manager to manage items in a list of claims.
    public class Claim
    {
        public int ClaimID { get; }

        public string ClaimType { get; }

        public string Description { get; set; }

        public double ClaimAmount { get; set; }

        DateTime DateOfIncident { get; }

        DateTime DateOfClaim { get; }

        public bool IsValid
        {
            get
            {
                var time = DateOfIncident - DateOfClaim;
                var Isvalid = time.Days <= 30; //magic number for the current limit of time span
                return Isvalid;
            }
        }

        public Claim(
            int ClaimID, 
            string ClaimType, 
            string Description, 
            double ClaimAmount, 
            DateTime DateOfIncident, 
            DateTime DateOfClaim)
            
        {
            this.ClaimID = ClaimID;
            this.ClaimType = ClaimType;
            this.Description = Description;
            this.ClaimAmount = ClaimAmount;
            this.DateOfIncident = DateOfIncident;
            this.DateOfClaim = DateOfClaim;
            
        }
        public override string ToString()
        {
            return "Claim ID:\t" +
                "Claim type:\t" +
                "Description:\t" +
                "Claim Amount\t" +
                "Date Of Incident\t" +
                "Date Of Claim\t\t" +
                "IsValid\n" +
                $"{ClaimID},\t\t" +
                $"{ClaimType},\t\t" +
                $"{Description},\t\t" +
                $"${ClaimAmount},\t\t" +
                $"{DateOfIncident.ToString("d")}\t" +
                $"{DateOfClaim.ToString("d")}\t" +
                $"{IsValid}";
        }
    }
}
