using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialize variables to hold values for multiple iterations
            int vote = 0;
            int totalvotes = 7; //How many voters allowed in program
            int exit = 0;
            //do-while loop that continues voting program until exit variable = 4
            do
            {
                //For loop that loops until total votes reach determined voters specified in totalvotes variable
                for (int i = 1; i <= totalvotes; i++)
                {
                    Console.WriteLine($"Voter {i}:"); //Shows what voter iteration is on
                    Console.WriteLine(""); //Space for better visibility
                    vote = CastVote(vote); //Calls method CastVote while using vote variable to get user vote
                    ProcessResults(vote); //Calls method ProcessResults while using vote variable to add to dictionary
                }
                //Calls method DisplayResults to output results
                DisplayResults();
                //Prompts user whether or not to continue program or not
                Console.WriteLine("To exit program please press 4; if you wish to continue enter any key");
                //Converts user input to exit integer variable 
                exit = Convert.ToInt32(Console.ReadLine());
                //If-statement that calls ResetVotes if exit variable is not 4
                if (exit != 4)
                {
                    ResetVotes(); //Calls method ResetVotes to reset dictionary to zero
                }
            } while (exit != 4); //Escape sequence while exit string is not equal to 4
        }
        //Declare dictionary to hold candidate name and vote value
        public static Dictionary<string, int> candidates = new Dictionary<string, int>()
        {
            {"Rick Sanchez", 0}, //First candidate
            {"Morty Smith", 0}, //Second candidate
            {"Bird Person", 0} //Third candidate
        };
        //Method CastVote outputs all candidates and returns vote variable in integer
        public static int CastVote(int vote)
        {
            //Prompts user of choices on who to vote for
            Console.WriteLine("Who do you want to vote?");
            Console.WriteLine("1. Rick Sanchez");
            Console.WriteLine("2. Morty Smith");
            Console.WriteLine("3. Bird Person");
            //Prompts user for number pertaining to candidate
            Console.Write("Please type the number of the person you want to vote for: ");
            //Converts user input to vote integer variable
            vote = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            //Returns vote back to main method
            return vote; 
        }
        //Method ProcessResults takes vote from CastVote method to then add to dictionary/array
        public static void ProcessResults(int vote)
        {
            //Switch case structure that takes user's vote and adds one to candidates dictionary/array
            switch(vote)
            {
                case 1:
                    candidates["Rick Sanchez"]++;
                    break;
                case 2:
                    candidates["Morty Smith"]++;
                    break;
                case 3:
                    candidates["Bird Person"]++;
                    break;
            }
        }
        //Method DisplayResults prints out all candidates names and votes that they recieved from dictionary/array
        public static void DisplayResults()
        {
            //Foreach loop that outputs each candidates name and votes they recieved from dictionary/array
            foreach (var candidate in candidates)
            {
                Console.WriteLine($"{candidate.Key}: {candidate.Value} vote(s)");
            }
        }
        //Method ResetVotes take dictionary/array down to zero
        public static void ResetVotes()
        {
            //Resets all candidates votes to zero to start voting again
            candidates["Rick Sanchez"] = 0;
            candidates["Morty Smith"] = 0;
            candidates["Bird Person"] = 0;
        }
    }
}
