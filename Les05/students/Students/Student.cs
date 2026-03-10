using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Course { get; set; }

        public Student(int studentId, string firstName, string lastName, DateTime birthDate, string course)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Course = course;
        }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }

        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - BirthDate.Year;
            if (currentDate < BirthDate.AddYears(age))
            {
                age--;
            }
            return age;
        }

    }
}
