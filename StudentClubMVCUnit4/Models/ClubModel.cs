using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClubMVCUnit4.Models
{
    public class ClubModel
    {

        string clubName;
        int clubIDNumber;
        int clubCapacity;
        string clubDescription;
        string clubPresident;

        public ClubModel()
        {
        }

        public ClubModel(string clubName, int clubIDNumber, int clubCapacity, string clubDescription, string clubPresident)
        {
            this.ClubName = clubName;
            this.ClubIDNumber = clubIDNumber;
            this.ClubCapacity = clubCapacity;
            this.ClubDescription = clubDescription;
            this.ClubPresident = clubPresident;
        }

        public string ClubName { get => clubName; set => clubName = value; }
        public int ClubIDNumber { get => clubIDNumber; set => clubIDNumber = value; }
        public int ClubCapacity { get => clubCapacity; set => clubCapacity = value; }
        public string ClubDescription { get => clubDescription; set => clubDescription = value; }
        public string ClubPresident { get => clubPresident; set => clubPresident = value; }
    }
}
