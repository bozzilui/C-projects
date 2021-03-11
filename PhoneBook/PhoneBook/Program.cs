using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            string contact = "";
            string sorn = "";
            string answer = "";
            string addnum = "";
            string result;
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            contacts.Add("luigi", "1234567890");

            searchnew();


            //adding ontp the phonebook
            void adding()
            {
                if (contacts.TryGetValue(contact, out result))
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(contact + "'s number is " + result);
                    Console.ForegroundColor = ConsoleColor.White;
                    searchnew();
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry that contact does not exist, would you like it to add it?");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ok what is their number?");
                        Console.ForegroundColor = ConsoleColor.White;
                        addnum = Console.ReadLine().ToString();

                        if ((double.TryParse(addnum, out num)) || (addnum.Length == 10))
                        {
                            contacts.Add(contact, addnum);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ok contact " + contact + " added, press enter to continue");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            searchnew();

                        }
                        else if ((addnum.Length != 10) || (double.TryParse(addnum, out num)))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry that is an invalid number");
                            Console.ForegroundColor = ConsoleColor.White;
                            checkingvalid();
                        }
                        
                    }
                    else if (answer == "no")
                    {
                        searchnew();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter in a valid answer(yes or no)");
                        Console.ForegroundColor = ConsoleColor.White;
                        answer = Console.ReadLine().ToLower();
                        yesorno();
                    }

                }

            }

            //restarting the search
            void searchnew()
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press S to search for contact, Press N to add a new one");
                Console.ForegroundColor = ConsoleColor.White;
                sorn = Console.ReadLine().ToLower();
                if (sorn == "s")
                {
                    checkingvalid();
                }
                else if (sorn == "n")
                {
                    checkingvalid();
                }
                else
                {
                    searchnew();
                }
            }

            //seeing which search they would like to do
            void checkingvalid()
            {
                if (sorn == "s")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Write the name of the contact you would like to search");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    contact = Console.ReadLine().ToLower();
                    adding();
                }
                else if (sorn == "n")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Write the name of the contact you would like to add");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    contact = Console.ReadLine().ToLower();
                    bool copy = false;
                    foreach (KeyValuePair<string, string> n in contacts)
                    {
                        if (n.Key == contact)
                        {
                            
                            copy = true;
                        }


                    }
                    if (copy == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry that contact already exists, would you like to edit it?");
                        Console.ForegroundColor = ConsoleColor.White;
                        answer = Console.ReadLine();
                        if (answer == "yes")
                        {
                            copy = false;
                            contacts.Remove(contact);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ok what is their number?");
                            Console.ForegroundColor = ConsoleColor.White;
                            addnum = Console.ReadLine().ToString();

                            if ((double.TryParse(addnum, out num)) || (addnum.Length == 10))
                            {
                                contacts.Add(contact, addnum);
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Ok contact " + contact + " added, press enter to continue");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ReadLine();
                                searchnew();

                            }
                            else if ((addnum.Length != 10) || (double.TryParse(addnum, out num)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sorry that is invalid");
                                Console.ForegroundColor = ConsoleColor.White;
                                checkingvalid();
                            }
                            
                        }
                        else if (answer == "no")
                        {
                            searchnew();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter in a valid answer(yes or no)");
                            Console.ForegroundColor = ConsoleColor.White;
                            answer = Console.ReadLine().ToLower();
                            checkingvalid();
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ok what is their number?");
                        Console.ForegroundColor = ConsoleColor.White;
                        addnum = Console.ReadLine().ToString();

                        if ((double.TryParse(addnum, out num)) || (addnum.Length == 10))
                        {
                            contacts.Add(contact, addnum);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ok contact " + contact + " added, press enter to continue");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            searchnew();

                        }
                        else if ((addnum.Length != 10) || (double.TryParse(addnum, out num)))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sorry that is invalid, please enter a valid number");
                            Console.ForegroundColor = ConsoleColor.White;
                            checkingvalid();
                        }
                        
                    }

                }
                              
            }

            //if you want to add a contact
            void yesorno()
            {
                if (answer == "yes")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ok what is their number?");
                    Console.ForegroundColor = ConsoleColor.White;
                    addnum = Console.ReadLine().ToString();

                    if ((double.TryParse(addnum, out num)) || (addnum.Length == 10))
                    {
                        contacts.Add(contact, addnum);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ok contact " + contact + " added, press enter to continue");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        searchnew();

                    }
                    else if ((addnum.Length != 10)||(double.TryParse(addnum, out num)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry that is invalid");
                        Console.ForegroundColor = ConsoleColor.White;
                        checkingvalid();
                    }
                   
                }
                else if (answer == "no")
                {
                    searchnew();
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter in a valid answer(yes or no)");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = Console.ReadLine().ToLower();

                }
            }
            Console.ReadKey();
        }
    }
}


