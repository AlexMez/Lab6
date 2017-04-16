using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {

                displayMenu = MainMenu();

            }
        }

        static void PigLatin()
        {

            //user input

            Console.Write("Enter a line to be translated: ");

            string input = Console.ReadLine();

            //Validation for numbers and lengh.

            while ((input.Length <= 1)) //(!Regex.IsMatch(input, @"([^a-zA-Z0-9]|^\s)")))*/
            {
                Console.WriteLine("not a valid entry, try again");
                input = Console.ReadLine();
            }

            string mySentence = input.ToLower();

            //Seperate each word to translate each

            string[] words = mySentence.Split(' ');

            Console.WriteLine("that translates to: ");

            //translate each word in the sentence with a foreach iteration
            //and console.write them

            foreach (var Word in words)

            {

                {

                    Char[] vowels = { 'e', 'u', 'i', 'o', 'a', };

                    Word.IndexOfAny(vowels);

                    //this is to keep numbers unchanged
                    int n;
                    bool isNumeric = int.TryParse(Word, out n);
                    if (isNumeric)
                    {
                        Console.Write(n + " ");
                    }

                    else if ((Word.IndexOfAny(vowels) > 0))
                    {
                        //Console.WriteLine("the word starts with a Consonant");

                        int FirstVowel = Word.IndexOfAny(vowels);

                        Word.Substring(FirstVowel);
                        string FirstConst = Word.Substring(0, FirstVowel);

                        string MyStringChange = Word.Substring(FirstVowel) + FirstConst + "ay";

                        Console.Write(MyStringChange + " ");
                    }

                    else
                    //the word starts with a vowel
                    {
                        string ChangeString = Word;

                        ChangeString = Word + "way";

                        Console.Write(ChangeString + " ");
                    }

                }
                
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");
        }
        public static int GetValidInteger()
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not an option");
            }
            return input;
        }
        public static int RangeValidator(int min, int max)

        {

            int input;

            //Console.WriteLine($"Please enter an Integer between {min} and {max}");

            input = GetValidInteger();

            while (input < min || input > max)

            {

                Console.WriteLine("this is not an option");

                input = GetValidInteger();

            }

            return input;



        }
        public static bool MainMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Translate a line into Pig Latin");
            Console.WriteLine("2) Quit");


            int userInput = RangeValidator(1, 2);

            if (userInput == 1)
            {
                Console.Clear();
                PigLatin();
                return true;
            }
            else if (userInput == 2)
            {
                Console.Clear();
                return false;
            }

            else
            {

                return true;
            }

        }


    }
}