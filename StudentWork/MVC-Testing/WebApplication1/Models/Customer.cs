using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Name + "" + Surname + "";
        }
    }
}
