using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClubMVCUnit4.Models
{
    public class StudentList
    {
        List<StudentModel> students = new List<StudentModel>();

        public StudentList()
        {

            students.Add(new StudentModel("Jarad", 123, 16));
            students.Add(new StudentModel("Breanna", 456, 16));
            students.Add(new StudentModel("Cheryl", 789, 16));
            students.Add(new StudentModel("Forrest", 123, 16));
        }

        public List<StudentModel> getAllStudents()
        {
            return students;
        }

        public StudentModel getOneStudent(int index)
        {
            return students[index];
        }
    }
}
