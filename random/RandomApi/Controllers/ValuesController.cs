using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RandomApi.Controllers
{
    public class ValuesController : ApiController
    {
        Random random = new Random();

        // GET api/values
        public int Get()
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            return shift;
        }

        // POST api/values
        public double Post([FromBody] string value)
        {
            double flt = random.NextDouble();
            return flt;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
