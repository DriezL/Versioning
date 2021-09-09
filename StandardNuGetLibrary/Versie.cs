using System;
using System.Reflection;

namespace StandardNuGetLibrary
{
    public class Versie
    {
        public string Get()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
