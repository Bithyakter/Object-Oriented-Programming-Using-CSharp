using System.Collections.Generic;

namespace Interfaces
{
    public class Course : IInformation
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Credit { get; set; }

        public string GetBasicInformation()
        {
            return "Code: " + Code + " Name: " + Name + " Credit: " + Credit;
        }
    }
}
