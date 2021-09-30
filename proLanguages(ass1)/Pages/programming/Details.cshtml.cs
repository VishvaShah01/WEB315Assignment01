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
    public class DetailsModel : PageModel
    {
        private readonly proLanguageslanguagesContext _context;

        public DetailsModel(proLanguageslanguagesContext context)
        {
            _context = context;
        }

        public proLanguage proLanguage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            proLanguage = await _context.proLanguage.FirstOrDefaultAsync(m => m.id == id);

            if (proLanguage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
