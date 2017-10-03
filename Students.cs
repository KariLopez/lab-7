using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{   //creates student object
    class Student
    {
        string name;
        string food;
        string homeTown;

        public Student(string n, string f, string ht)
        {
            name = n;
            food = f;
            homeTown = ht;
        }
        public void Name()
        {
            Console.WriteLine(name);
        }
        public void PrintFood()
        {
            Console.WriteLine(name + "'s favorite food is " + food);
        }
        public void PrintHomeTown()
        {
            Console.WriteLine(name + "'s hometown is " + homeTown);
        }
        //method to give information about student's hometown or food and to tell user if invalid entry was entered
        public  void FoodOrHometown()
        {
            Console.WriteLine("What would you like to know about "+name+ "(enter hometown or food)");
            string i = Console.ReadLine();
            i.ToLower();
           
            if (i == "food")
            {
                PrintFood();
                
            }
            else if (i == "hometown")
            {
                PrintHomeTown();
                
            }
            else
            {
                Console.WriteLine("That data does not exist. Please try again");
               

            }
         
        }

    }   

}

    


