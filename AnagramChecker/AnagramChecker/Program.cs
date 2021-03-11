using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double wrong = 0;
            string firstsentence = "";
            string secondsentence = "";
            string anagram1 = "";
            string anagram2 = "";
            List<char> sentenceonel = new List<char>();
            List<char> sentencetwol = new List<char>();
            start();
            void start()
            {
                Console.WriteLine("Please enter a sentence");
                firstsentence = Console.ReadLine().ToLower();
                if (double.TryParse(firstsentence, out wrong))
                {
                    Console.WriteLine("That is not a correct input");
                    start();
                }
                Console.WriteLine("Now please enter a second sentence");
                secondsentence = Console.ReadLine().ToLower();
                if (double.TryParse(secondsentence, out wrong))
                {
                    Console.WriteLine("That is not a correct input");
                    start();
                }
                else
                {
                    loops();
                }
            }
            
            void loops()
            {
                foreach (char s in firstsentence)
                {
                    sentenceonel.Add(s);
                }
                foreach (char s in secondsentence)
                {
                    sentencetwol.Add(s);
                }

                sentenceonel.Sort();
                sentencetwol.Sort();

                foreach (char s in sentenceonel)
                {
                    if (s != ' ')
                    {
                        anagram1 = anagram1 + s;
                    }

                }
                foreach (char s in sentencetwol)
                {
                    if (s != ' ')
                    {
                        anagram2 = anagram2 + s;
                    }

                }

                if (anagram1 == anagram2)
                {
                    Console.WriteLine("That is an anagram");
                }
                else if (anagram1 != anagram2)
                {
                    Console.WriteLine("That is not an anagram");
                }
            }
            Console.ReadKey();
        }
    }
}
