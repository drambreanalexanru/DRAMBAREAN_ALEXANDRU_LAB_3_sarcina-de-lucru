using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DRAMBAREAN_ALEXANDRU_LAB_2.Data;
using DRAMBAREAN_ALEXANDRU_LAB_2.Models;
using Microsoft.AspNetCore.Authentication;

namespace DRAMBAREAN_ALEXANDRU_LAB_2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context _context;

        public CreateModel(DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AUTHORID"] = new SelectList(_context.Set<AUTHOR>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public AUTHOR AUTHOR { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {

                return Page();
            }


            _context.AUTHOR.Add(AUTHOR);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}