using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DRAMBAREAN_ALEXANDRU_LAB_2.Data;
using DRAMBAREAN_ALEXANDRU_LAB_2.Models;

namespace DRAMBAREAN_ALEXANDRU_LAB_2.Pages.Authors
{
    public class EditModel : PageModel
    {
        private readonly DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context _context;

        public EditModel(DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public AUTHOR AUTHOR { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AUTHOR == null)
            {
                return NotFound();
            }

            var author =  await _context.AUTHOR.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            ViewData["ID"] = new SelectList(_context.Set<AUTHOR>(), "ID",
"AUTHORName");
            AUTHOR = author;
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

            _context.Attach(AUTHOR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AUTHORExists(AUTHOR.ID))
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

        private bool AUTHORExists(int id)
        {
          return _context.AUTHOR.Any(e => e.ID == id);
        }
    }
}
