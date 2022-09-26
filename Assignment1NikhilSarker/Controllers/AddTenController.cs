using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NikhilSarker.Controllers
{
    public class AddTenController : ApiController
    {
        
    /// <summary>
    /// additional 10 from the input number
    /// </summary>
    /// <param name="id">The input number</param>
    /// <return>Return the input number plus ten</return>
    /// <example>
    /// GET /api/addten/10 -> 20
    /// GET /api/addten/{id}
    /// </example>
    
        public int Get(int id)
        {
            int additional = id + 10;
            return additional;
        }
    }
}

