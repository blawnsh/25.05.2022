using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
              
            Console.WriteLine("Username'i daxil edin");
            string username = Console.ReadLine();

            Console.WriteLine("Password'u daxil edin");
            string password = Console.ReadLine();

            User[] users = { new Student("Salman", "Heziyev", "salmanhzyv", "salman123", "A"),
                             new Student("Malik", "Ebduleziz", "malikyt", "malik2005", "B"),
                             new User("Qasim", "Novruzov", "xesteqasim", "xesteyem111") };




            bool flag = false;
            foreach (var item in users)
            {
                if (username == item.Username && password == item.Password)
                {
                    flag = true;                    
                        item.WhoIs();
 
                }
            }
            if (!flag) Console.WriteLine("Bu username ve passwordda User yoxdur!");
        }
    }
}
