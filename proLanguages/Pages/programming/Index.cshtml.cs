using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using languages.models;

namespace proLanguages.Pages_programming
{
    public class IndexModel : PageModel
    {
        private readonly proLanguageslanguagesContext _context;

        public IndexModel(proLanguageslanguagesContext context)
        {
            _context = context;
        }

        public IList<proLanguage> proLanguage { get;set; }

        public async Task OnGetAsync()
        {
            proLanguage = await _context.proLanguage.ToListAsync();
        }
    }
}
