using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Char[] vowels = { 'e', 'u', 'i', 'o', 'a', };
            Console.WriteLine("enter the word");

            string WordInput = Console.ReadLine();

            Console.Clear();

            string Mystring = WordInput.ToLower();

            Console.WriteLine("------------------------------");

            Mystring.IndexOfAny(vowels);

            if ((Mystring.IndexOfAny(vowels) > 0))
            {

                int FirstVowel = Mystring.IndexOfAny(vowels);

                Mystring.Substring(FirstVowel);
                string FirstConst = Mystring.Substring(0, FirstVowel);

                string MyStringChange = Mystring.Substring(FirstVowel) + FirstConst + "ay";
                //Console.WriteLine("the word starts with a Consonant");
                Console.WriteLine("In Pig Latin {0} would be: {1} ", WordInput, MyStringChange);
            }
            else
            {
                string ChangeString = Mystring;

                ChangeString = Mystring + "way";

                Console.WriteLine("In Pig Latin {0} would be: {1} ", WordInput, ChangeString);
            }
            Console.WriteLine();
            
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
            Console.WriteLine("1) Translate a word into Pig Latin");
            Console.WriteLine("2) Quit");
            

            int userInput = RangeValidator(1, 2);

            if (userInput == 1)
            {
                PigLatin();
                return true;
            }
            else if (userInput == 2)
            {
                Console.WriteLine("option 2");
                return false;
            }
            
            else
            {
                return true;
            }

        }


    }
}