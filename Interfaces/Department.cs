using System.Collections.Generic;

namespace Interfaces
{
    public class Department : IInformation, IPrinter
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public Department()
        {
            Students = new List<Student>();
            Courses = new List<Course>();
        }
        public string GetBasicInformation()
        {
            return "Code: " + Code + " Name: " + Name + " Total Student: " + Students.Count;
        }

        public void SetIpAddress(string ip)
        {
            throw new System.NotImplementedException();
        }

        public void Print()
        {
            throw new System.NotImplementedException();
        }
    }
}
