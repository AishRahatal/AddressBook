using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace day10
{

    class program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to  Address Book Program!");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Enter no of people's address information want to store:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");

            AddressBook1[] b = new AddressBook1[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = new AddressBook1();
            }
            int ch = 0;
            do
            {

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
                ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------");

                if (ch > 0)
                {

                    switch (ch)
                    {
                        case 1:
                            //UC1 - Creating address

                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("\n Accepting record in Address Book");
                            Console.WriteLine("-----------------------------------------------------");
                            AddressBook1.accept(b, n);
                            Console.WriteLine("-----------------------------------------------------");
                            break;
                        case 2:

                            Console.WriteLine("-----------------------------------------------------");

                            Console.WriteLine("Address book:");
                            Console.WriteLine("-----------------------------------------------------");
                            AddressBook1.display(b, n);
                            break;

                        case 3:// UC2-adding address
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Enter no of people's address information want to store:");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("---------------------------------------------------");

                            AddressBook1[] b1 = new AddressBook1[n1];
                            for (int i = 0; i < n1; i++)
                            {
                                b1[i] = new AddressBook1();
                            }
                            Console.WriteLine("\n Accepting record in Address Book");
                            Console.WriteLine("-----------------------------------------------------");
                            AddressBook1.accept(b1, n1);
                            AddressBook1 []newArray = new AddressBook1[b.Length + b1.Length];
                            Array.Copy(b, newArray,b.Length);
                            Array.Copy(b1, 0, newArray, b.Length, b1.Length);
                            n+=n1;
                            Console.WriteLine("Address book:");
                            Console.WriteLine("-----------------------------------------------------");
                            AddressBook1.display(newArray, n);
                            break;
                        case 4:

                            //UC3 - edit  address
                            Console.WriteLine("----------------------------------------------------");


                            Console.WriteLine("Update record from address book:");
                            Console.WriteLine("Enter  first name:");
                            string fn = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("Enter  last name:");
                            string ln = Console.ReadLine();


                            AddressBook1.update(fn, ln, b);
                            break;
                        case 5:
                            // UC4 - Delete  address
                            Console.WriteLine("Delete record from address book:");
                            Console.WriteLine("Enter  first name:");
                            string dfn = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");

                            Console.WriteLine("Enter  last name:");
                            string dln = Console.ReadLine();
                            AddressBook1.Delete(dfn, dln, b);
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
                
            } while (ch != 6);

            Console.ReadKey();



        }
    }
}

