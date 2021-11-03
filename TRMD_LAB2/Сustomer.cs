using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public class СustomerObj
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public decimal CurrentSum
        {
            get
            {
                if (CurrentSum > 5000)
                    return CurrentSum * 0.9m;

                else if (CurrentSum > 10_000)
                    return CurrentSum * 0.8m;

                else
                    return CurrentSum;
            }
            set
            {
                CurrentSum = value;
            }
        }
        public Guid CardNumber { get; set; }
        public СustomerObj()
        {

        }
        public СustomerObj(string name, string seconName, int age)
        {
            Name = name;
            SecondName = seconName;
            Age = age;
            CardNumber = Guid.NewGuid();
            CurrentSum = default;
        }

        public void GetCustomerInfo(СustomerObj cust)
        {

            Console.WriteLine($"-------------------------------------------------------");
            Console.WriteLine($"Customer Info");
            Console.WriteLine($"Customer name: {cust.Name}");
            Console.WriteLine($"Customer second name : {cust.SecondName}");
            Console.WriteLine($"Customer age: {cust.Age}");
            Console.WriteLine($"Customer CardNumber: {cust.CardNumber}");
            Console.WriteLine($"Customer Summary: {cust.CurrentSum}");
            Console.WriteLine(" ");
        }

    }
}
