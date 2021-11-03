using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public class Person
    {
        public List<Person> people { get; set; }
        public Person()
        {
            people.Add(this);
            Console.WriteLine($"People count = {people.Count}");
        }
    }
}
