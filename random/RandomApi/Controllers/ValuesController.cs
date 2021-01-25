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
        public double Post()
        {
            double flt = random.NextDouble();
            Console.WriteLine(flt);
            return flt;
        }

        // PUT api/values/5
        public string Put()
        {
            return "Thank you for the new number";
        }

        // DELETE api/values/5
        public char Delete()
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
             return Convert.ToChar(shift + 65);

        }
        public DateTime Patch()
        {
            DateTime now = DateTime.Now;
            return now;
           
        }
        public string Options()
        {

            return "Get-randominteger,Post-doublenumber,Put-string,Delete-character,Patch-current Datetime";
        }
    }
}
