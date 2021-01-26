using System;
using System.Net.Http;

namespace ApiClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseAsString = await client.GetStringAsync("https://swapi.dev/api/people/1/ ");

            Console.WriteLine(responseAsString);
        }
    }
}
