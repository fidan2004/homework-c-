using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace to_send_txt_file
{
    internal class Program
    {
        static string Path = @"C:\Users\Hp\source\repos\to send txt file\to send txt file\TextFile1.txt";
        static async Task Main(string[] args)
        {
            Console.WriteLine("pls enter url");
            string url = Console.ReadLine();
            var awaiter = await GetToDoAsync(url);

            if(awaiter != null)
            {
                await File.WriteAllTextAsync(Path,awaiter.ToString());
            }    
        }
        

        public static async Task<string> GetToDoAsync(string url)
        {
           // const string url = " https://jsonplaceholder.typicode.com/todos"; //url i ozum outputda daxil edecem ve o txt file na elave olunacaq
           using var  client = new HttpClient();
            var stringresult = await client.GetStringAsync(url);

            return stringresult;
        }
    }
}
