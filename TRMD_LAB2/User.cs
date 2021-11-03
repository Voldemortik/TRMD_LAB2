using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMD_LAB2
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }


        public void FindUserById(int Id,List<User> users)
        {
            var curUser = users.FirstOrDefault(x => x.Id == Id);
            if (curUser != null)
            {
                Console.WriteLine($"-------------------------------------------------------");
                Console.WriteLine($"User with Id: {Id}");
                Console.WriteLine($"User name: {curUser.Name}");
                Console.WriteLine($"User second name : {curUser.SecondName}");
                Console.WriteLine($"User age: {curUser.Age}");
            }
            else
            {
                Console.WriteLine($"Cant find user with Id {Id}");
            }
        }
        public void FindUserByName(string name, List<User> users)
        {
            var curUsers = users.Where(x => x.Name == name).ToList();
            if (curUsers != null)
            {
                Console.WriteLine($"-------------------------------------------------------");
                Console.WriteLine($"Users with name: {name}");
                foreach (var curUser in curUsers)
                {
                    Console.WriteLine($"User name: {curUser.Name}");
                    Console.WriteLine($"User second name : {curUser.SecondName}");
                    Console.WriteLine($"User age: {curUser.Age}");
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine($"Cant find users with Id {Id}");
            }
        }
        public void FindUserBySecondName(string secondName, List<User> users)
        {
            var curUsers = users.Where(x => x.SecondName == secondName).ToList();
            if (curUsers != null)
            {
                Console.WriteLine($"-------------------------------------------------------");
                Console.WriteLine($"Users with second name : {secondName}");
                foreach (var curUser in curUsers)
                {
                    Console.WriteLine($"User name: {curUser.Name}");
                    Console.WriteLine($"User second name : {curUser.SecondName}");
                    Console.WriteLine($"User age: {curUser.Age}");
                    Console.WriteLine(" ");
                }
            }
        }
        public void FindUserByAge(int age, List<User> users)
        {
            var curUsers = users.Where(x => x.Age == age).ToList();
            if (curUsers != null)
            {
                Console.WriteLine($"-------------------------------------------------------");
                Console.WriteLine($"Users with age : {age}");
                foreach (var curUser in curUsers)
                {
                    Console.WriteLine($"User name: {curUser.Name}");
                    Console.WriteLine($"User second name : {curUser.SecondName}");
                    Console.WriteLine($"User age: {curUser.Age}");
                    Console.WriteLine(" ");
                }
            }
        }
    }
}
