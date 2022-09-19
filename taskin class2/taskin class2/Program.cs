
using System;

namespace taskin_class2
{
    public class Program
    {

        
        static void Main(string[] args)
        {

            Console.WriteLine("enter amount");
            try
            {
                decimal amount = Convert.ToDecimal(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine("enter decimal");
                return;

            }
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            int percent = 6;
            var firstyear = (year * (amount*percent / 100)) + amount;
            Console.WriteLine(firstyear);
        }
    }
}
