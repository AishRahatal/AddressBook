using System;
using System.Linq;

namespace day10
{
    public class AddressBook1
    {

        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public int phone { get; set; }
        public string mail { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string ln { get; private set; }
        public string fn { get; private set; }



        //Using array obiect

        public static void accept(AddressBook1[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter id (" + i + ") : ");
                b[i].id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter First Name(" + i + ") : ");
                b[i].fname = Console.ReadLine();

                Console.WriteLine("Enter Last Name(" + i + ") : ");
                b[i].lname = Console.ReadLine();

                Console.WriteLine("Enter Phone number(" + i + ") : ");
                b[i].phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Email Id(" + i + ") : ");
                b[i].mail = Console.ReadLine();

                Console.WriteLine("Enter address/house name/house number/street/society(" + i + ") : ");
                b[i].address = Console.ReadLine();

                Console.WriteLine("Enter City(" + i + ") : ");
                b[i].city = Console.ReadLine();

                Console.WriteLine("Enter State(" + i + ") : ");
                b[i].state = Console.ReadLine();

                Console.WriteLine("Enter Zip code(" + i + ") : ");
                b[i].zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------");

            }

        }

        public static void display(AddressBook1[] b,int n)
        {
            

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Id           : " + b[i].id);
                Console.WriteLine("First name   : " + b[i].fname);
                Console.WriteLine("Last name    : " + b[i].lname);
                Console.WriteLine("Phone        : " + b[i].phone);
                Console.WriteLine("Email Id     : " + b[i].mail);
                Console.WriteLine("Address/Society/Area : " + b[i].address);
                Console.WriteLine("City         : " + b[i].city);
                Console.WriteLine("State        : " + b[i].state);
                Console.WriteLine("Zip code     : " + b[i].zip);
                Console.WriteLine("----------------------------------------");

            }

        }

        //public static void addAddress(AddressBook1[] b, int n)
        //{

        //}

        public static void update(string fn, string ln, AddressBook1[] b)
    {

        int choice = 0;
        int count = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i].fname == fn && b[i].lname == ln)
            {
                count++;
            }
            if (count > 1)
            {
                Console.WriteLine("There are duplicate record");

            }
            else
            {

                if (b[i].fname == fn && b[i].lname == ln)
                {
                    while (choice != 7)
                    {

                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Enter 1 :to chnage name  ");

                        Console.WriteLine("Enter 2 :to chnage Phone number ");
                        Console.WriteLine("Enter 3 :to chnage Email Id ");
                        Console.WriteLine("Enter 4 :to chnage address/city/zip code ");
                        Console.WriteLine("Enter 5 :to chnage state");
                        Console.WriteLine("Enter 6 :to Display updated record");
                        Console.WriteLine("Enter 7 :to exit");

                        Console.WriteLine("----------------------------------------");

                        Console.WriteLine("\n Enter choice from menu:");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("---------------------------------------------------");


                        if (choice == 0)
                        {
                            Console.WriteLine("\n Invalid choice");


                        }
                        else
                        {
                            switch (choice)
                            {

                                case 1:

                                    Console.WriteLine("Enter First new Name : ");
                                    string newname = Console.ReadLine();
                                    b[i].fname = newname;

                                    Console.WriteLine("First name has been changed ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Enter new Last Name : ");
                                    string newlname = Console.ReadLine();
                                     b[i].lname = newlname;

                                    Console.WriteLine("Last name has been changed ");

                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("First name   : " + b[i].fname);
                                    Console.WriteLine("Last name   : " + b[i].lname);
                                    break;

                                case 2:
                                    Console.WriteLine("Enter new Phone number : ");
                                    int newphone = Convert.ToInt32(Console.ReadLine());
                                    b[i].phone = newphone;
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Phone number has been changed ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Phone Number  : " + b[i].phone);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter new Email Id : ");
                                    string newmail = Console.ReadLine();
                                    b[i].mail = newmail;
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("Email has been changed ");

                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Email  : " + b[i].mail);
                                    break;

                                case 4:

                                    Console.WriteLine("Enter address/house name/house number/street/society : ");
                                    string newaddress = Console.ReadLine();
                                    b[i].address = newaddress;
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("address has been changed ");

                                    Console.WriteLine("Enter new City : ");
                                    string newcity = Console.ReadLine();

                                    b[i].city = newcity;

                                    Console.WriteLine("----------------------------------------");
                                    Console.WriteLine("Enter new Zip code : ");
                                    int newzip = Convert.ToInt32(Console.ReadLine());
                                    b[i].zip = newzip;
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("city and Zip code has been changed ");
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("Address  : " + b[i].address);
                                    Console.WriteLine("City : " + b[i].city);
                                    Console.WriteLine("Zip Code : " + b[i].zip);
                                    break;
                                case 5:
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("Enter new State : ");
                                    string newstate = Console.ReadLine();
                                    b[i].state = newstate;
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("State has been changed ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("New state  : " + b[i].state);
                                    break;

                                case 6:
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Updated Record ");
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("First name   : " + b[i].fn);
                                    Console.WriteLine("Last name   : " + b[i].ln);
                                    Console.WriteLine("Phone Number  : " + b[i].phone);
                                    Console.WriteLine("Email  : " + b[i].mail);
                                    Console.WriteLine("Address  : " + b[i].address);
                                    Console.WriteLine("City : " + b[i].city);
                                    Console.WriteLine("Zip Code : " + b[i].zip);
                                    Console.WriteLine("New state  : " + b[i].state);

                                    break;
                            }


                        }
                    }
                }
                else
                {
                    Console.WriteLine("---------------------------------------------------");

                    Console.WriteLine("Record is not found in Address Book");
                }


                break;
            }
        }

    }
    public static void  Delete(string fn, string ln, AddressBook1[] b)
    {
        for (int i = 0; i < b.Length - 1; i++)
        {
            if (b[i].fname == fn && b[i].lname == ln)
            {
               b[i].id = b[i + 1].id;
               b[i].fname = b[i + 1].fname;
                b[i].lname = b[i + 1].lname;
                b[i].phone = b[i + 1].phone;
                b[i].mail = b[i + 1].mail;
                b[i].address = b[i + 1].address;
                b[i].city = b[i + 1].city;
                b[i].state = b[i + 1].state;
                b[i].zip = b[i + 1].zip;
                Console.WriteLine("Record is deleted successfully");
                Console.WriteLine("---------------------------------------------------");
          }
            else
            {
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine("Record is not found in Address Book");
            }
        }
    }

      
    }
}


