using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static async  Task Main(string[] args)

        {
            #region task1
            //const string Url = "https://jsonplaceholder.typicode.com/todos";
            //HttpClient client = new HttpClient();


            //    var result = await client.GetStringAsync(Url);
            //Console.WriteLine(result);
            #endregion

            await GetToDo();
        }

        public static async Task GetToDo()
        {
            const string url = "https://jsonplaceholder.typicode.com/todos";
            HttpClient client = new HttpClient();
            var result = await client.GetStringAsync(url);

            Console.WriteLine(result);
        }

    }
}
