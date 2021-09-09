using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
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
