using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleTables;

namespace ApiClient
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();

            var responseAsStream = await client.GetStreamAsync("https://swapi.dev/api/people/");

            var response = await JsonSerializer.DeserializeAsync<StarWarsPeopleResponse>(responseAsStream);
            var table = new ConsoleTable("Name", "Height", "Birth Year", "Eye Color", "Gender");
            foreach (var person in response.Results)
            {
                table.AddRow(person.Name, person.Height, person.BirthYear, person.EyeColor, person.Gender);
            }
            table.Write();
        }
    }
}
