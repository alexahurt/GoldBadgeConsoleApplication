using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repo
{
    //POCO
    public enum ClaimType
    {
        Car =1,
        Home,
        Theft,
    }


    public class Claims
    {
        public int ClaimNumber { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public double ClaimCost { get; set; }

        public DateTime IncidentDate { get; set; }

        public DateTime ClaimDate { get; set; }


        public bool IsClaimValid { get; set; }

        public Claims() { }

        public Claims(int claimNumber, ClaimType typeOfClaim, string claimDescription, double claimCost, DateTime incidentDate, DateTime claimDate, bool isClaimValid)
        {
            ClaimNumber = claimNumber;
            TypeOfClaim = typeOfClaim;
            ClaimDescription = claimDescription;
            ClaimCost = claimCost;
            IncidentDate = incidentDate;
            ClaimDate = claimDate;
            IsClaimValid = isClaimValid;
        }

        public void ProcessClaim(int claimNumber, ClaimType typeOfClaim, string claimDescription, double claimCost, DateTime incidentDate, DateTime claimDate, bool isClaimValid)
        {
            Console.WriteLine($"Claim {ClaimNumber} processed!");
        }

        
    }
}