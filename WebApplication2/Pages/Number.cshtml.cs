using CoreClassLibrary2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class NumberModel : PageModel
    {
        private readonly ILogger<NumberModel> _logger;
        public string Versie { get; set; }

        public NumberModel(ILogger<NumberModel> logger)
        {
            _logger = logger;
            Versie = new AccountNumber().GetVersion();
        }

        public void OnGet()
        {
        }
    }
}
