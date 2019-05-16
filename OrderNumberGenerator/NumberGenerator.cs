using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNumberGenerator
{
    public class NumberGenerator
    {
        public string GenerateNumber(string prefix)
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");
            string OrderNumber = String.Format("{0}-{1}{2}-{3}", prefix, DateTime.Now.Year, DateTime.Now.Month.ToString("D2"), r);
            return OrderNumber;
        }
    }
}
