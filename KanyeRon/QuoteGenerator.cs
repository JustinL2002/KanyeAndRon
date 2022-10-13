using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Runtime.Intrinsics.X86;

namespace KanyeRon
{
    public class QuoteGenerator
    {
        public string KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeLink = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeLink).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            return kanyeQuote;
        }
        public string RonResponse()
        {
            var client = new HttpClient();

            var RonLink = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(RonLink).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            return ronResponse;
        }       
    }
}
