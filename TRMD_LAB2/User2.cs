using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public class User2
    {
        public int Id
        {
            get
            {
                Console.WriteLine($"User Id: {Id}");
                return Id;
            }
        }
        public string Name
        {
            get
            {
                Console.WriteLine($"User Name: {Name}");
                return Name;
            }
        }
        public string SecondName
        {
            get
            {
                Console.WriteLine($"User Second Name: {SecondName}");
                return SecondName;
            }
        }
        public int Age
        {
            get
            {
                Console.WriteLine($"User Age: {Age}");
                return Age;
            }
        }
    }
}
