using StandardNuGetLibrary;
using System;

namespace CoreClassLibrary1
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
