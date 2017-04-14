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
            bool run = true;
            while (run)
            {

                Char[] vowels = { 'e', 'u', 'i', 'o', 'a', };
                Console.WriteLine("enter a word");

                string Mystring = Console.ReadLine();

                Console.WriteLine("------------------------------");

                //string Mystring2 = "apples";

                Mystring.IndexOfAny(vowels);

                //Console.WriteLine((Mystring.IndexOfAny(vowels)));

                if ((Mystring.IndexOfAny(vowels) > 0))
                {

                    int FirstVowel = Mystring.IndexOfAny(vowels);

                    Mystring.Substring(FirstVowel);
                    string FirstConst = Mystring.Substring(0, FirstVowel);

                    string MyStringChange = Mystring.Substring(FirstVowel) + FirstConst + "ay";
                    //Console.WriteLine("the word starts with a Consonant");
                    Console.WriteLine(MyStringChange);
                }
                else
                {
                    string ChangeString = Mystring;

                    ChangeString = Mystring + "way";

                    Console.WriteLine(ChangeString);
                }


            }
        }
    }
}