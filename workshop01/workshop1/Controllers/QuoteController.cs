using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace workshop1.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class QuoteController : Controller
    {
        
        private static readonly string[] Quotes = new[]
        {
            "Logic will get you from A to B. Imagination will take you everywhere.",
            "There are 10 kinds of people. Those who know binary and those who don \'t.",
             "There are two ways of constructing a software design. One way is to make it",
            "so simple that there are obviously no deficiencies and the other is to make",
            "it so complicated that there are no obvious deficiencies.",
            "It \'s not that I\'m so smart, it\'s just that I stay with problems longer.",
             "It is pitch dark. You are likely to be eaten by a grue."
        };

      
        [HttpGet]
        public object Get()
        {
            string quote = Quotes[Random.Shared.Next(Quotes.Length)];
            return new  { quote };
        }



    }
}
