using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab8
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? \n(enter a number between 1-15 or type '1212' to see all your options)");
            while (true)
            {
                ReturnInfo();
                Console.WriteLine($"Would you like to learn about another student? (y/n)");
                string answer = Convert.ToString(Console.ReadLine().ToLower());
                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("Which student would you like to learn more about? \n(enter a number between 1-15 or type 1212 to view all your options)");
                    continue;
                }
                else if (answer == "no" || answer == "n")
                {
                    break;
                }
            }


        }
        
     // static void ValidateMethod(string value, string prompt)
     // {
     //     string answer = value;
     //
     //     if (answer == "yes" || answer == "y")
     //     {
     //         Console.WriteLine(prompt);
     //         break;
     //     }
     //     else if (answer == "no" || answer == "n")
     //     {
     //         break;
     //     }
     // }
     // "Which student would you like to learn more about? \n(enter a number between 1-15)"

        static void ReturnInfo()
        {
            string[,] studentList = new string[15, 4] {
                                                         { "Abby Wessels", "Traverse City, MI", "Soup", "Vaporwave" },
                                                         { "Blake Shaw", "Los Angeles, CA", "Cannolis", "Indie" },
                                                         { "Bob Valentic", "St. Clair Shores, MI", "Pizza", "Shoegaze" },
                                                         { "Jay Stiles", "Macomb, MI", "Pickles", "Class Rock" },
                                                         { "Jon Shaw", "Huntington Woods, MI", "Ribs", "Classic Rock" },
                                                         { "Jordan Owiesny", "Warren, MI", "Burgers", "Hip-Hop" },
                                                         { "Joshua Zimmerman", "Taylor, MI", "Turkey", "Orchestral" },
                                                         { "Lin-Z Chang", "Toledo, OH", "Ice Cream", "Folk/Indie" },
                                                         { "Madelyn Hilty", "Oxford, MI", "Croissent", "Celtic" },
                                                         { "Michael Hern", "Canton, MI", "Chicken Wings", "90's Alternative" },
                                                         { "Nana Banahene", "Guana", "Empanadas", "Jazz" },
                                                         { "Rochelle Toles", "Mars", "Space Cheese", "Techno" },
                                                         { "Shah Shahid", "Newark, NJ", "Chicken Wings", "Rap/Hip-Hop" },
                                                         { "Taylor Everts", "Caro, MI", "Cordon Bleu", "Pop" },
                                                         { "Tim Broughton", "Detroit, MI", "Chicken Parm", "Tibetan Throat Singing" },
                                                      };
            int input;
            while (true)
            {
                
                bool isNum = int.TryParse((Console.ReadLine()), out input);
                if (input == 1212)
                {
                    for (int i  = 0; i < studentList.GetLength(0); i++)
                    {
                        Console.WriteLine($"Student {i + 1}: {studentList[i, 0]}");
                    }
                    Console.WriteLine("Which student would you like to learn more about? \n(enter a number between 1-15 or enter 1212 to see all your options)");
                    continue;
                }
                else if (input < 1 || input > 15)
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number between 1-15 or enter 1212 to see all your options)");
                    continue;
                }
                else if (isNum == false)
                {
                    Console.WriteLine("That is not a valid response. Please try again.");
                    continue;
                }
                break;
            }
            int studentNumber = --input;
            //column one is name. two is hometown. 3 is favorite food. 4 is fvorite genre of music
           
            while (true)
            {
                StudentInfo(studentList, studentNumber);
                Console.WriteLine($"Would you like to know more about {studentList[studentNumber, 0]}? (y/n)");
                string answer2 = Convert.ToString(Console.ReadLine().ToLower());
                if (answer2 == "yes" || answer2 == "y")
                {
                    continue;
                }
                else if (answer2 == "no" || answer2 == "n")
                {
                    break;
                }
            }

        }

        static void StudentInfo(string[,] array, int value)
        {
            string[,] studentList = array;
            int studentNumber = value;
            Console.WriteLine($"What would you like to know about {studentList[studentNumber, 0]}?\nYour options are:\nHometown (type: hometown)\nFavorite Food (type: food)\nFavorite Music Genre (type: music)");

            while (true)
            {
                string answer = Convert.ToString(Console.ReadLine().ToLower());
                if (answer == "hometown")
                {
                    Console.WriteLine($"{studentList[studentNumber, 0]}'s hometown is {studentList[studentNumber, 1]}.");
                }
                else if (answer == "food")
                {
                    Console.WriteLine($"{studentList[studentNumber, 0]}'s favorite food is {studentList[studentNumber, 2]}.");
                }
                else if (answer == "music")
                {
                    Console.WriteLine($"{studentList[studentNumber, 0]}'s favorite genre of music is {studentList[studentNumber, 3]}.");
                }
                else
                {
                    Console.WriteLine("That is not a valid response. Please try again");
                    continue;
                }
                break;
                
            }
                
        
        }
    }
}
