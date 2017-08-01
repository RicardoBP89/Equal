using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal
{
    class Person
    {
        public String Name;

        static void Main(string[] args)
        {
            var pedro = new Person() { Name = "Pedro" };
            var juan = new Person() { Name = "Pedro" };
        }
        
        public static Person operator ==(Person a, Person b)
        {
            if(true)
            return new Person() { name = a.Name + " " + b.Name + "son hermanos" };
            else
            return new Person() { name = a.Name + " " + b.Name + "no son hermanos" };
        }

        public override int GetHashCode()
        {
            return pedro.GetHashCode() && juan.GetHashCode();
        }
    }
}
