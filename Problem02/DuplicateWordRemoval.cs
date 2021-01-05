//ID: 1775227
//Name: Marissa Goncalves
//Assignment 3 - Problem 2: Duplicate Word Removal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class DuplicateWordRemoval
    {

        //Static variable which initializes the input into a list of strings.
        public static List<string> sentenceList = new List<string>();

        static void Main(string[] args)
        {

            //Boolean variable that indicates whether the do-while loop should be repeated according to the user.
            bool inputAgain = true;

            do
            {

                //Print the title of the application.
                Console.WriteLine($"Duplicate Word Removal: ");

                //Skip a line.
                Console.WriteLine();

                //Prompt the user to enter a sentence.
                Console.Write($"Please enter a sentence with no punctuation: ");

                //Read the user's string input.
                string sentence = (Console.ReadLine());

                //Skip a line.
                Console.WriteLine();

                //Create a string array that splits the sentence into seperate words.
                sentenceList = sentence.ToLower().Split().ToList();


                //Create a LINQ variable to sort the words in alphabetical order and determine the nonduplicate words.
                var sortedSentenceWords =
                    from word in sentenceList
                    //let duplicateValue = findDuplicate(word)
                    //where duplicateValue.Equals(false)
                    orderby word
                    select word;
                 
                //Print the title of the sorted array of words from the sentence.
                Console.Write($"Sorted Sentence Words: ");

                //For every element in the sorted array, which duplicates are removed,
                foreach (var word in sortedSentenceWords.Distinct())
                {
                    //Print the distinct word from the array.
                    Console.Write($"{word} ");
                }


                //Skip a line.
                Console.WriteLine();

                //Skip a line.
                Console.WriteLine();




                //Prompt the user to enter another sentence (Yes) or not (End).
                Console.Write($"Would you like to enter another sentence? (YES) or (END): ");

                //Read the user's decision input.
                string decision = (Console.ReadLine());

                //Skip a line.
                Console.WriteLine();

                //If the user's input is "YES",
                if (decision == "YES")
                {
                    //Then, the boolean value is equal to true, which the do-while will be called again.
                    inputAgain = true;

                    //Skip a line.
                    Console.WriteLine();

                    //Skip a line.
                    Console.WriteLine();
                }

                //If the user's input is "END",
                else if (decision == "END")
                {
                    //Then, the boolean value is equal to false which the program will end.
                    inputAgain = false;

                    //Skip a line.
                    Console.WriteLine();

                    //Exit the entire program entirely.
                    Environment.Exit(0);
                }

            }

            //Condition to repeat loop when the variable still remains true.
            while (inputAgain == true);

        }


    }

}
