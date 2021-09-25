using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
        public static int id = 1;
        public int id1;
        public string fname;
        public string lname;
        public int phone;
        public string mail;
        public string address;
        public string city;
        public string state;
        public int zip;


        public AddressBook(int id1, string fname, string lname, int phone, string mail, string address,
            string city, string state, int zip) // parameter constructor
        {
            this.id1 = id1;
            this.fname = fname;
            this.lname = lname;
            this.phone = phone;
            this.mail = mail;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;


        }
        //getter fname
        public String getfName()
        {
            return fname;
        }

        // Setter fname
        public void setfame(String newName)
        {
            this.fname = newName;
        }
//============================================================
        //getter lnmae
        public String getlName()
        {
            return lname;
        }

        // Setter lname
        public void setlame(String newName)
        {
            this.lname = newName;
        }
 //============================================================
        //getter phone
        public int getphone()
        {
            return phone;
        }

 
        public void setphone(int newphone)
        {
            this.phone = newphone;
        }

 //============================================================
        //getter mail
        public String getmail()
        {
            return mail;
        }

        // Setter mail
        public void setmail(String newmail)
        {
            this.mail = newmail;
        }
 //============================================================

        //getter address
        public String getadds()
        {
            return address;
        }

        // Setter address
        public void setadds(String newaddress)
        {
            this.address = newaddress;
        }
 //============================================================


        // Setter city
        public void setcity(String newcity)
        {
            this.city = newcity;
        }
        //getter city
        public String getcity()
        {
            return city;
        }
 //============================================================

        // Setter state
        public void setstate(String newstate)
        {
            this.state = newstate;
        }
        //getter state
        public String getstate()
        {
            return state;
        }

 //============================================================

        //getter zip
        public int getzip()
        {
            return zip;
        }

        // Setter zip
        public void setzip(int newzip)
        {
            this.zip = newzip;
        }
//============================================================
         
        // Accept method  to get user input
        public static AddressBook accept()
        {

            //static int id;
            string fname;
            string lname;
            int phone;
            string mail;
            string address;
            string city;
            string state;
            int zip;
            
            int id1 = id; //auto increment

            Console.WriteLine("Enter First Name : ");
            fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            lname = Console.ReadLine();

            Console.WriteLine("Enter Phone number : ");
            phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Email Id : ");
            mail = Console.ReadLine();

            Console.WriteLine("Enter address/house name/house number/street/society : ");
            address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            city = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            state = Console.ReadLine();

            Console.WriteLine("Enter Zip code : ");
            zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            AddressBook uc1 = new AddressBook(id1, fname, lname, phone, mail, address, city, state, zip);
            id += 1;
            return uc1;

        }

        // Displaying address book(which details have entered by user)
        public static void display(List<AddressBook> list) 
        {

            foreach (var obj in list)
            {
                Console.WriteLine("Id           : " + obj.id1);
                Console.WriteLine("First name   : " + obj.fname);
                Console.WriteLine("Last name    : " + obj.lname);
                Console.WriteLine("Phone        : " + obj.phone);
                Console.WriteLine("Email Id     : " + obj.mail);
                Console.WriteLine("Address/Society/Area : " + obj.address);
                Console.WriteLine("City         : " + obj.city);
                Console.WriteLine("State        : " + obj.state);
                Console.WriteLine("Zip code     : " + obj.zip);
                Console.WriteLine("----------------------------------------");

            }

        }


        //Updating details in existing record
        internal static int Update(List<AddressBook> list, string fn, string ln)
        {
           
            foreach (var obj in list)
            {
               
                    if (fn == obj.fname && ln == obj.lname)
                    { 

                        int choice = 0;
                        while (choice != 6)
                        {

                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Enter 1 :to chnage name  ");

                            Console.WriteLine("Enter 2 :to chnage Phone number ");
                            Console.WriteLine("Enter 3 :to chnage Email Id ");
                            Console.WriteLine("Enter 4 :to chnage address/city/zip code ");
                            Console.WriteLine("Enter 5 :to chnage state");
                            Console.WriteLine("Enter 6 :to exit");
                            Console.WriteLine("----------------------------------------");

                            Console.WriteLine("\n Enter choice from menu:");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 0)
                            {
                                Console.WriteLine("\n Invalid choice");


                            }
                            else
                            {

                                if (choice == 1)
                                {
                                    Console.WriteLine("Enter First new Name : ");
                                    string newname = Console.ReadLine();
                                    obj.setfame(newname);
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("First name has been changed ");

                                    Console.WriteLine("Enter new Last Name : ");
                                    string newlname = Console.ReadLine();
                                    obj.setlame(newlname);
                                    Console.WriteLine("---------------------------------------------------");

                                    Console.WriteLine("Last name has been changed ");



                                    if (choice == 2)
                                    {
                                        Console.WriteLine("Enter new Phone number : ");
                                        int newphone = Convert.ToInt32(Console.ReadLine());
                                        obj.setphone(newphone);
                                        Console.WriteLine("---------------------------------------------------");

                                        Console.WriteLine("Phone number has been changed ");

                                        if (choice == 3)
                                        {
                                            Console.WriteLine("Enter new Email Id : ");
                                            string newmail = Console.ReadLine();
                                            obj.setmail(newmail);
                                            Console.WriteLine("---------------------------------------------------");

                                            Console.WriteLine("Email has been changed ");


                                            if (choice == 4)
                                            {
                                                Console.WriteLine("Enter address/house name/house number/street/society : ");
                                                string newaddress = Console.ReadLine();
                                                obj.setadds(newaddress);
                                                Console.WriteLine("---------------------------------------------------");

                                                Console.WriteLine("address has been changed ");

                                                Console.WriteLine("Enter new City : ");
                                                string newcity = Console.ReadLine();

                                                obj.setcity(newcity);

                                                Console.WriteLine("----------------------------------------");
                                                Console.WriteLine("Enter new Zip code : ");
                                                int newzip = Convert.ToInt32(Console.ReadLine());
                                                obj.setzip(newzip);
                                                Console.WriteLine("---------------------------------------------------");

                                                Console.WriteLine("city and Zip code has been changed ");



                                                if (choice == 5)
                                                {
                                                    Console.WriteLine("---------------------------------------------------");

                                                    Console.WriteLine("Enter new State : ");
                                                    string newstate = Console.ReadLine();
                                                    obj.setstate(newstate);
                                                    Console.WriteLine("---------------------------------------------------");

                                                    Console.WriteLine("State has been changed ");


                                                }
                                            }
                                        }
                                    }
                                }
                            }


                        }
                    }
                    else
                    {
                        Console.WriteLine("---------------------------------------------------");

                        Console.WriteLine("Record is not found in Address Book");
                    }
                
            }
            return 0;
        }

        // Deleting record from address book
        internal static int Delete(List<AddressBook> list, string fn, string ln)
        {


          bool flag = false;
            foreach (var obj1 in list)
            {

                if (fn == obj1.fname && ln == obj1.lname)
                {


                    list.Remove(obj1);

               flag = true;
                    break;
                }

            }

            if (flag)
            {
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine("Record is deleted from Address Book");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine("Record is not found in Address Book");
            }
            return 0;
        }
    }
}
