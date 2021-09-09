using CoreClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Pages
{
    public class PersonModel : PageModel
    {
        private readonly ILogger<PersonModel> _logger;
        public string Versie { get; set; }

        public PersonModel(ILogger<PersonModel> logger)
        {
            _logger = logger;
            Versie = new Person().GetVersion();
        }

        public void OnGet()
        {
        }
    }
}
