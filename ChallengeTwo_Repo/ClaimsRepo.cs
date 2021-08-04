using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repo
{
    public class ClaimsRepo
    {
        private List<Claims> _listOfClaims = new List<Claims>();

        Queue<Claims> claimsQueue = new Queue<Claims>();

        public object ClaimNumber { get; private set; }


        //Create 
        public void AddClaimsToList(Claims item)
        {
            _listOfClaims.Add(item);
        }

        //Read
        public List<Claims> GetClaimsList()
        {
            return _listOfClaims;
        }

        // private DeveloperInfo GetContentByNameException(string v)
        // {
        // throw new NotImplementedException();
        // }
        //rewrite or it will force an exception

        //Update
        public bool UpdateExistingClaim(int ClaimNumber, Claims newClaim)
        {
            // Find the content
            Claims oldClaim = GetClaimByNumber(ClaimNumber);

            //Update the content
            if (oldClaim != null)
            {
                oldClaim.ClaimNumber = newClaim.ClaimNumber;
                oldClaim.TypeOfClaim = newClaim.TypeOfClaim;
                oldClaim.ClaimDescription = newClaim.ClaimDescription;
                oldClaim.ClaimCost = newClaim.ClaimCost;
                oldClaim.IncidentDate = newClaim.IncidentDate;
                oldClaim.ClaimDate = newClaim.ClaimDate;
                oldClaim.IsClaimValid = newClaim.IsClaimValid;

                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void ProcessClaim()
        {
            Console.WriteLine($"Claim {ClaimNumber} processed!");
        }

        //  public MenuItems GetItemByName(string v)
        // {
        //   throw new NotImplementedException();
        //  }

        //Delete
        public bool RemoveClaimFromList(int claimNumber)
        {
            Claims item = GetClaimByNumber(claimNumber);

            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfClaims.Count;
            _listOfClaims.Remove(item);

            if (initialCount > _listOfClaims.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Helper method
        public Claims GetClaimByNumber(int claimNumber)
        {
            foreach (Claims item in _listOfClaims)
            {
                if (item.ClaimNumber == claimNumber)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
