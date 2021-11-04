using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using languages.models;

namespace proLanguages.Pages_programming
{
    public class CreateModel : PageModel
    {
        private readonly proLanguageslanguagesContext _context;

        public CreateModel(proLanguageslanguagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public proLanguage proLanguage { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.proLanguage.Add(proLanguage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
