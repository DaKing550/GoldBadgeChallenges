using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            foreach (Claim claim in Claims)
            {
                claimItems.AppendLine(newClaim.ToString());
            }
        }

        public void RemoveClaim()
        {
            Claims.Remove(claim);
        }

        public void UpdateClaim()
        {

        }
    }
}
