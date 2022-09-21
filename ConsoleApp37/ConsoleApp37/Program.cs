using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    internal class Program
    {
        public static Filter con = new Filter();
        static void Main(string[] args)
        {
            SeedDatabase();
            int a = int.Parse(Console.ReadLine());
            
            switch (a)
            {
                
                case 1:
                    Console.WriteLine("enter number");
                    string number = Console.ReadLine();
            Console.WriteLine(con.FilterByNumber(number).ToString());
                    break;
                    case 2:
                    CreateContact();
                    break;
                case 3:
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();   
                    FindByName(name);
                    break;
                case 4:
                    Console.WriteLine("all contact");
                   con. View();
                    break;
            }

        }
        public static void SeedDatabase()
        {
            var cont = new Contact("fidan", "555-55");
            var cont1 = new Contact("ayan", "555-54");
            var cont2 = new Contact("aylin", "555-53");


            con.AddContact(cont);
            con.AddContact(cont1);
            con.AddContact(cont2);
            
        }
        public static void FindByName(string name)
        {
            List <Contact> contact= con.Searchbyname(name);
            foreach (Contact c in contact)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public static Contact CreateContact()
        {
            Console.Write("enter name");
            string name = Console.ReadLine().Trim();
            Console.Write("enter number");
            string number = Console.ReadLine();
            Contact contact = new Contact(name, number);
            con.AddContact(contact);
            Console.WriteLine(con.FilterByNumber(contact.number).ToString());
            return contact;
        }
       
    }
}
