using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Rep
{
    class DoorList
    {
        private static List<string> _listOfDoorNames = new List<string>();
        public static List<string> DoorNames
        {
            get
            {
                return _listOfDoorNames;
            }

            set
            {
                _listOfDoorNames = DoorList.DoorNames = _listOfDoorNames;
            }
        }
    };
}
