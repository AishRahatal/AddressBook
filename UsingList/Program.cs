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
                                Console.WriteLine("\n 3. Add record to Address Book");
                                Console.WriteLine("\n 4. Update record from Address Book");
                                Console.WriteLine("\n 5.  Delete record from Address Book");
                                Console.WriteLine("\n 6.  To exit from Address Book");


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
                                AddressBook obj = AddressBook.accept();// calling display function

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

                        case 3: //UC2 - Adding  address
                            Console.WriteLine("-----------------------------------------------------");

                            Console.WriteLine("Adding address to the book:");
                            Console.WriteLine("Enter no of people's address information want to store:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("-----------------------------------------------------");

                            for (int i = 0; i < n1; i++)
                            {
                                AddressBook obj = AddressBook.accept();// calling display function

                                list.Add(obj);
                            }
                            Console.WriteLine("----------------------------------------------------");
                            AddressBook.display(list);
                            Console.WriteLine("----------------------------------------------------");

                            break;
                        case 4://UC3-edit  address
                            Console.WriteLine("----------------------------------------------------");

                            Console.WriteLine("Update record from address book:");
                            Console.WriteLine("Enter  first name:");
                            string fn = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("Enter  last name:");
                            string ln = Console.ReadLine();
                            AddressBook.Update(list, fn, ln);

                            break;
                        case 5: //UC4-Delete  address
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("Delete record from address book:");

                            Console.WriteLine("Enter  first name:");
                            string dfn = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("Enter  last name:");
                            string dln = Console.ReadLine();
                            AddressBook.Delete(list, dfn, dln);
                            break;

                        case 6:
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Thank you!, Exiting ..");
                            break;
                           
                    }
                }
                else
                {
                    Console.WriteLine("\n Invalid choice");

                }

            } while (ch!=6);

            Console.ReadKey();

        }


        

    }
}
