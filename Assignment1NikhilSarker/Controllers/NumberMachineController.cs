using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1NikhilSarker.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        ///  the input number return the result
        /// </summary>
        /// <param name="id">The input number</param>
        /// <return>Return the input number as a ?</return>
        /// <example>
        /// GET /api/numbermachine/3 -> ?.
        /// GET /api/numbermachine/{id}
        /// </example>

        public int Get(int id)
        {
            int result = (((id+10)-2)/4)*5;
                return result ;
            
           
            
        }
    }
          
}

