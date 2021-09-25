using System;
using System.Collections.Generic;

namespace AddressBook
{
        

    class Program
    {
   

        static void Main(string[] args)
        {
            var list = new List<AddressBook>(); // creating list
           

            Console.WriteLine("Welcome to  Address Book Program!");
            

            int ch = 0;
            do {
               
                 Console.WriteLine("***************************************************************");

                                       Console.WriteLine("\n \n\t\tMENU");

                Console.WriteLine("\n**************************************************************");
                                Console.WriteLine("\n 1. Create record in Address Book");
                                Console.WriteLine("\n 2. Display records of  Address Book");
                                

                      Console.WriteLine("\n***************************************************************");

                          Console.WriteLine("\n Enter choice from menu:");
                           ch= Convert.ToInt32(Console.ReadLine());

                if (ch > 0)
                {
                    switch (ch)
                    {
                        case 1: //UC1 - Creating address
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("\n Accepting record in Address Book");
                            Console.WriteLine("Enter no of people's address information want to store:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("-----------------------------------------------------");

                            for (int i = 0; i < n; i++)
                            {
                                AddressBook obj = AddressBook.accept(n);// calling display function

                                list.Add(obj);
                            }
                            Console.WriteLine("------------------------------------------------------");
                            break;

                        case 2:
                            Console.WriteLine("-----------------------------------------------------");

                            Console.WriteLine("Address book:");
                            Console.WriteLine("-----------------------------------------------------");

                            AddressBook.display(list);// calling display method
                            break;
}
                }
                else
                {
                    Console.WriteLine("\n Invalid choice");

                }

            } while (ch!=2);

            Console.ReadKey();

        }
    }
}