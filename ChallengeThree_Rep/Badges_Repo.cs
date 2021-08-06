using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Rep
{
    public class Badges_Repo
    {

        private List<Badges> _listOfBadges = new List<Badges>();
        //create

       
        public static void BadgeDictionary()
        { 

        Dictionary<int, string> badgeDictionary = new Dictionary<int, string>();
        badgeDictionary.Add(12345, "Door A, Door B, Door C");
        badgeDictionary.Add(23456, "Door D, Door E, Door F");
        badgeDictionary.Add(34567, "Door G, Door H, Door I");
        badgeDictionary.Add(45678, "Door J, Door K, Door L");
        badgeDictionary.Add(56789, "Door M, Door N, Door O");

        }

        public void AddBadgeToList (Badges badge)
        {
            _listOfBadges.Add(badge);
        }

        public void AddDoorToBadge(Badges doorName)
        {
            _listOfBadges.Add(doorName);
        }

        

        //read all badge numbers and door access

        public List<Badges> GetBadgeList()
        {
            return _listOfBadges;
        }

        //update doors on existing  badge

        public bool UpdateBadgeDoors (int badgeID, Badges newDoor)
        {
            Badges oldDoor = GetDoorByBadgeID(badgeID);

            if (oldDoor != null)
            {
                oldDoor.DoorName = oldDoor.DoorName;
                

                return true;
            }
            else
            {
                return false;
            }
        }

        //delete all doors from existing badge

        public bool RemoveDoorsFromBadge (string doorName)
        {

            Badges door = new Badges();

            if (door == null)
            {
                return false;
            }

            int initialCount = _listOfBadges.Count;
            _listOfBadges.Remove(door);

            if (initialCount > _listOfBadges.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        //Helper method - get door name by badge ID

        public Badges GetDoorByBadgeID (int badgeID)
        {
            foreach (Badges doorName in _listOfBadges)
            {
                if (doorName.BadgeID == badgeID)
                {
                    return doorName;
                }
            }

            return null;
        }

        //Helper method - get badge by badge ID

        public Badges GetBadgeByID (int badgeID)
        {
            foreach (Badges badge in _listOfBadges)
            {
                if (badge.BadgeID == badgeID)
                {
                    return badge;
                }
            }

            return null;
        }







    }
}
