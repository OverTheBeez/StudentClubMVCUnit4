using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClubMVCUnit4.Models
{
    public class StudentModel
    {
        string name;
        int studentIDNumber;
        int credits;

        public StudentModel(string name, int studentIDNumber, int credits)
        {
            this.name = name;
            this.studentIDNumber = studentIDNumber;
            this.credits = credits;
        }

        public string Name { get => name; set => name = value; }
        public int StudentIDNumber { get => studentIDNumber; set => studentIDNumber = value; }
        public int Credits { get => credits; set => credits = value; }
    }
}
