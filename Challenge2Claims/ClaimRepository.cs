using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Claims
{
    class ClaimRepository
    {
        List<Claim> Claims = new List<Claim>();

        public void AddClaim(Claim newClaim)
        {
            Claims.Add(newClaim);
        }

        public string ListClaims()
        {
            var claimItems = new StringBuilder();
            foreach (Claim Claim in Claims)
            {
                claimItems.AppendLine(Claim.ToString());
            }

            return claimItems.ToString();
        }
        public string DealClaim()
        {
            var queue = Claims.First();
            return queue.ToString();
        }
        public void RemoveClaim(Claim claim)
        {
            Claims.Remove(claim);
        }

        public void RemoveClaimFromTop()
        {
            
            var result = Claims.First();
            RemoveClaim(result);
        }
       
        public Claim GetClaimbyID(int ClaimID)
        {
            var result = Claims.First(c => c.ClaimID == ClaimID);
            return result;
        }
    }
}
