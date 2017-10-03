using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Molly Guthrie", "Noodles", "Rockford, MI"));
            students.Add(new Student("Michelle Jokish Polo","Spaghetti", "Ecuador"));
            students.Add(new Student("Rebecca Allard", "Pizza", "Charlevoix, MI"));
            students.Add(new Student("Brianna Jael", "Gumbo", "Fairfield,CA"));
            students.Add(new Student("Tammy Cole", "Maru Sushi", "Grand Rapids,MI"));
            students.Add(new Student("Lauren Babcock", "Cheeseburgers", "Plainwell,MI"));
            students.Add(new Student("Karina Lopez", "Tacos", "Holland, MI"));
            students.Add(new Student("Anel Guel-Juarez", "Pizza", "Grand Rapids,MI"));
            students.Add(new Student("Lisa Dewey", "Mushroom Masala Dosa", "Los Angeles, CA"));
            students.Add(new Student("Jonaca Hudson", "Sushi", "Lansing, MI"));
            students.Add(new Student("Tanvi Sathe", "Chicken Biryani", "India"));
            students.Add(new Student("Tommy Waalkes", "Indian Red Curries", "Raleigh, NC"));

            bool loopAgain = true;
            while (loopAgain == true)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?Enter a number 1-12");
                    int input = int.Parse(Console.ReadLine());
                    Console.Write("Student " + input + " is ");
                    // input-1 since the first entry in the list is 0, not 1. In a way it's re-numbering the students
                    students[input - 1].Name();
                    students[input - 1].FoodOrHometown();
                }
                //catches entries that are not numbers
                catch (FormatException)
                {
                    Console.WriteLine("not a valid entry");
                    loopAgain = true;
                }
                //catches indexes that are not in the list
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist");
                    loopAgain = true;
                }
                
                loopAgain = DoAgain();
            }
            

        }
        public static bool DoAgain()
        {
            string goAgain;
            Console.WriteLine("Would you like to learn about another student?(Y or N)");
            goAgain = Console.ReadLine();
            goAgain = goAgain.ToLower();
            bool repeat;
            if (goAgain == "y")
            {
                repeat = true;
            }
            else if (goAgain == "n")
            {
                repeat = false;
            }
            else
            {
                Console.WriteLine("Sorry not an accurate input");
                repeat = DoAgain();
            }
            return repeat;
        }
    }
}
