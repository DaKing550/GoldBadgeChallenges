using Challenge2Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Challenge2Test
{
    [TestClass]
    public class ClaimRepositoryTest
    {
        [TestMethod]
        public void AddClaim_WhenAddingAClaim_ShouldAddAMenu()
        {
            //Arrange
            ClaimRepository testRepository = new ClaimRepository();
            Claim claim = MakeBasicClaim(1);

            //Act
            testRepository.AddClaim(claim);

            //Assert
            Assert.AreEqual(1, testRepository.CurrentClaim.Count);
        }
        [TestMethod]
        public void ListClaims_WhenListingClaims_ShouldListClaims()
        {
            //Arrange
            ClaimRepository testListRepo = new ClaimRepository();
            Claim claim = MakeBasicClaim(1);
            testListRepo.AddClaim(claim);
            //Act
            string Result = testListRepo.ListClaims();
            //Assert
            StringAssert.Contains(Result, "Claim ID:\t" +
                "Claim type:\t" +
                "Description:\t" +
                "Claim Amount\t" +
                "Date Of Incident\t" +
                "Date Of Claim\t\t" +
                "IsValid\n" +
                $"1,\t\t" +
                $"car,\t\t" +
                $"a,\t\t" +
                $"$1.1,\t\t" +
                $"1/1/1111\t" +
                $"1/2/1111\t" +
                $"True");
        }

        private static Claim MakeBasicClaim(int claimID)
        {
            
            return new Claim(claimID, "car", "a", 1.1, DateTime.Parse("1/1/1111"), DateTime.Parse("1/2/1111"));
        }

        [TestMethod]
        public void DealClaim_WhenDealingWithAClaim_ShouldOutputTopClaim()
        {
            //Arrange
            ClaimRepository testDealClaim = new ClaimRepository();
            Claim claim = MakeBasicClaim(1);
            testDealClaim.AddClaim(claim);
            //Act
            testDealClaim.DealClaim();
            //Assert
            Assert.AreEqual(1, testDealClaim.CurrentClaim.Count);
        }
        [TestMethod]
        public void RemoveClaim_WhenRemoveAClaim_ShouldRemoveAClaim()
        {
            //Arrange
            ClaimRepository testRemoveClaim = new ClaimRepository();
            //Act

            //Assert
        }
        [TestMethod]
        public void RemoveClaimFromTop_WhenRemovingAClaimFromTheTop_ShouldRemoveAClaimFromTheTop()
        {
            //Arrange
            ClaimRepository testTopRemove = new ClaimRepository();
            //Act

            //Assert
        }
    }
}
