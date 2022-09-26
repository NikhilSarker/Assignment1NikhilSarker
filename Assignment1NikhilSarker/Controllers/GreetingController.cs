using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NikhilSarker.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// sets the value of return Hello World        
        /// </summary>
        /// <example>
        /// POST /api/greeting/ -> Hello World.
        /// POST /api/greeting/{id}
        /// In Command Prompt Type: curl -d "" "http://localhost:60366/api/greeting "
        /// </example>

        public string POST()
        {
            return "Hello World";
        }



        /// <summary>
        /// additional the input number  in the two string
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Return the input number between the two string</return>
        /// <example>
        /// GET /api/greeting/3 -> Greetings to 3 peoples.
        /// GET /api/greeting/{id}
        /// </example>

        public string Get(int id)
        {
            string additional = ("Greetings to " + id + " People!");

            return additional;
        }
    }
}
