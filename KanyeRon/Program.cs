using System;
using KanyeRon;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using static System.Net.WebRequestMethods;

var client = new HttpClient();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Kanye: {KanyeQuote}");
    Console.WriteLine($"Ron: {RonResponse}");
}
    