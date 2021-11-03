using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public class Person2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Person2()
        {
            Id = default;
            Name = "DefaultName";
            SecondName = "DefaultSecondName";
            Age = default;
        }
        public Person2(string name,string secondName)
        {
            Name = name;
            SecondName = secondName;
        }
        public Person2(string name, string secondName,int age)
        {
            Name = name;
            SecondName = secondName;
            Age = age;
        }
    }
}
