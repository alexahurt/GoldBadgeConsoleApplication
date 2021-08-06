using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Rep
{
    public class Badges
    {

        public int BadgeID { get; set; }
        
        public string BadgeName { get; set; }

        public string DoorName { get; set; }

        public bool OtherDoors { get; set; }

        public Badges() { }


        public Badges(int badgeID, string badgeName, string doorName, bool otherDoors)
        {
            BadgeID = badgeID;
          
            BadgeName = badgeName;

            DoorName = doorName;

            OtherDoors = otherDoors;
        }

        

    }

    
}
