using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WozWebAPI.Controllers
{
    /// <summary>
    /// UsersController
    /// </summary>
    public class UsersController : ApiController
    {
        /// <summary>
        /// Doin some cool stuff
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get Some more stuff
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

    }
}
