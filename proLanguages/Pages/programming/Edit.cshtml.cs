using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using languages.models;

namespace proLanguages.Pages_programming
{
    public class EditModel : PageModel
    {
        private readonly proLanguageslanguagesContext _context;

        public EditModel(proLanguageslanguagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(proLanguage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!proLanguageExists(proLanguage.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool proLanguageExists(int id)
        {
            return _context.proLanguage.Any(e => e.id == id);
        }
    }
}
