using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NikhilSarker.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// square the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Return the input number square result</return>
        /// <example>
        /// GET /api/square/10 -> 100
        /// GET /api/square/{id}
        /// </example>

        public int Get(int id)
        {
           int square =(int)Math.Pow(id, 2);
           
            return square;
        }
    }
}

