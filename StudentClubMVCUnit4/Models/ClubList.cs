using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClubMVCUnit4.Models
{
    public class ClubList
    {
        static List<ClubModel> clubs = new List<ClubModel>();

        public ClubList()
        {
            if (clubs.Count == 0)
            {
                clubs.Add(new ClubModel("Video Game Club", 459, 20, "Club for video game lovers.", "Mario"));
                clubs.Add(new ClubModel("Coding Club", 111, 35, "Club for programmers to practice coding.", "Bruce"));
                clubs.Add(new ClubModel("Politics Club", 639, 12, "Club for individuals to talk about current politics.", "Sorin"));
                clubs.Add(new ClubModel("Travel Club", 032, 50, "Club for those who love to travel.", "Jen"));
                clubs.Add(new ClubModel("Sports Club", 322, 45, "Club to talk everything sports.", "Sharon"));
                clubs.Add(new ClubModel("Comedy Club", 509, 80, "Club to share some laughs", "Mack"));
            }
        }

        public List<ClubModel> getAllClubs()
        {
            return clubs;
        }

        public ClubModel getOneClub(int index)
        {
            return clubs[index];
        }

        public ClubModel AddNewClub(string name, int id, int capacity, string description, string president)
        {
            ClubModel newClub = new ClubModel(name, id, capacity, description, president);
            clubs.Add(newClub);

            return newClub;
        }
    }
}
