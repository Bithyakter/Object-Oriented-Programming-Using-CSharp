using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Student : IInformation, IPrinter
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }

        public string GetBasicInformation()
        {
            return "Reg No: " + RegNo + " Name: " + Name + " Roll: " + Roll;
        }
        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public void SetIpAddress(string ip)
        {
            throw new System.NotImplementedException();
        }

        /*------------Explicit Interface Implementation----------*/
        string IInformation.GetBasicInformation()   
        {
            return "Reg No: " + RegNo + " Name: " + Name;
        }

        /*===============Main Method============*/
        /*
        static void Main(string[] args)
        {
            Student students = new Student();
            students.Roll = "1263995";

            string stdInfo = students.GetBasicInformation();

            IInformation infoExp = students;    //Explicit Interface
            infoExp.GetBasicInformation();

            Department departments = new Department();
            departments.Code = "CSE";
            string deptInfo = departments.GetBasicInformation();

            Course courses = new Course();
            string courseInfo = courses.GetBasicInformation();

            IInformation information = students;
            information = departments;

            IPrinter printer = students;
            //printer = courses;      //not possible, its not implemented

            List<IInformation> informations = new List<IInformation>();
            informations.Add(students);
            informations.Add(departments);
            informations.Add(courses);

            Console.ReadLine();
        }
        */
    }
}
