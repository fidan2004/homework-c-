using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp37
{
    public class Filter
    {
        public  List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact cntct)
        {
            contacts.Add(cntct);
        }
        public  List<Contact> Searchbyname(string name)
        {
            return contacts.Where(x => x.name == name).ToList();
        }
        public Contact FilterByNumber(string number)
        {
            return contacts.Where(x => x.number == number).FirstOrDefault();
        }
        public void View()
        {
            if (contacts != null && contacts.Count != 0)
            {
                foreach(Contact cntct in contacts)
                {
                    Console.WriteLine(cntct.ToString());
                }
            }
        }



    }
}
