using System;
using System.Collections.Generic;
using System.Text;

namespace EX10_Base
{
    public class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";

        public Person(string ssn, string name)
		{
            Console.WriteLine("Person Constructor");
            this.ssn = ssn;
            this.name = name;
		}
        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
}
