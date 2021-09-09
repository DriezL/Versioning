using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public string GetName()
        {
            return "ClassLibrary1.Person.Name";
        }

        public string GetVersion()
        {
            var a = new Versie();
            return a.Get();
        }
    }
}
