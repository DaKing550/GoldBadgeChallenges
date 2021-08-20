using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    public class Claim
    {
        int ClaimID;
        List<string> ClaimType;
        string Description;
        double ClaimAmount;
        DateTime DateOfIncident;
        DateTime DateOfClaim;
        bool IsValid;
    }
}
