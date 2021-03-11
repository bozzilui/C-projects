using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> thephrase = new List<string>();
            string[] tempphrase = { };
            char[] tempword = { };
            bool there = false;
            string tempwordp = "";
            string tempwordg = "";
            string tempwords = "";
            string piglatin = "";
            int i = 0;

            Console.WriteLine("Please input a word");
            string phrase = Console.ReadLine().ToLower();
            tempphrase = phrase.Split(' ');

            if (tempphrase.Length == 1)
            {

                foreach (string s in tempphrase)
                {
                    while (i < tempphrase.Length)
                    {
                        tempword = tempphrase[i].ToCharArray();
                        if ((tempword[0] == 'a') || (tempword[0] == 'e') || (tempword[0] == 'i') || (tempword[0] == 'o') || (tempword[0] == 'u'))
                        {
                            i++;
                            checkthewordvowel();

                        }
                        else
                        {
                            while (i < tempphrase.Length)
                            {
                                tempword = tempphrase[i].ToCharArray();
                                checkthewordconstant();
                            }
                        }
                    }

                }
                foreach (string g in thephrase)
                {
                    Console.Write(g + " ");
                }
            }
            else
            {
               
                foreach (string s in tempphrase)
                {
                    while (i < tempphrase.Length)
                    {
                        tempword = tempphrase[i].ToCharArray();
                        if ((tempword[0] == 'a') || (tempword[0] == 'e') || (tempword[0] == 'i') || (tempword[0] == 'o') || (tempword[0] == 'u'))
                        {
                            
                            checkthewordvowel();

                        }
                        else
                        {
                            while (i < tempphrase.Length)
                            {

                                tempword = tempphrase[i].ToCharArray();
                                i++;
                                checkthewordconstant();
                            }
                        }
                    }

                }
                foreach (string g in thephrase)
                {
                    Console.Write(g + " ");
                }
            }

            void checkthewordconstant()
            {
                there = false;
                tempwordg = "";
                tempwords = "";
                tempwordp = "";
                piglatin = "";
                
                foreach (char s in tempword)
                {
                    if ((s == 'a') || (s == 'e') || (s == 'i') || (s == 'o') || (s == 'u'))
                    {
                        if (there == false)
                        {
                            tempwordg = tempwordg + s;
                            there = true;
                        }
                        else if (there == true)
                        {
                            tempwordg = tempwordg + s;
                        }
                    }
                    else if ((s != 'a') || (s != 'e') || (s != 'i') || (s != 'o') || (s != 'u'))
                    {
                        if (there == false)
                        {
                            tempwordp = tempwordp + s;
                        }
                        else if (there == true)
                        {
                            tempwordg = tempwordg + s;
                        }

                    }

                }
                piglatin = tempwordg + tempwords + tempwordp + "ay";
                thephrase.Add(piglatin);
                

            }
            
            void checkthewordvowel()
            {
                
                
                    piglatin = tempphrase[i] + "yay";
                i++;
                thephrase.Add(piglatin);
                    

                
            }
            Console.ReadKey();


        }



    }
}


