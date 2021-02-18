using System;
using System.Collections.Generic;
using System.Text;

namespace EX10_Base
{
    class Employee : Person
    {
        public string id ;
		public Employee(string ssn, string name, string id):base(ssn, name)
		{
			Console.WriteLine("Employee Constructor");
            this.id = id;
		}
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }
}
