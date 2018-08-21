using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_0_1.Models
{
    public class Generator
    {
        private Random random = new Random();

        public int ReturnNumber()
        {
            return random.Next(100);
        }
    }
}
