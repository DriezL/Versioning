using StandardNuGetLibrary;
using System;

namespace CoreClassLibrary2
{
    public class AccountNumber
    {
        public string GetAccountNumber()
        {
            return "1234567890";
        }

        public string GetVersion()
        {
            var a = new Versie();
            return a.Get();
        }
    }
}
