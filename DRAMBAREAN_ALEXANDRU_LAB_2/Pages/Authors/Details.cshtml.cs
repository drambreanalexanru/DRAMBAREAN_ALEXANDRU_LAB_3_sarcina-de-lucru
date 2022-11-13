using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DRAMBAREAN_ALEXANDRU_LAB_2.Data;
using DRAMBAREAN_ALEXANDRU_LAB_2.Models;

namespace DRAMBAREAN_ALEXANDRU_LAB_2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context _context;

        public DetailsModel(DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context context)
        {
            _context = context;
        }

      public AUTHOR AUTHOR { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AUTHOR == null)
            {
                return NotFound();
            }

            var author = await _context.AUTHOR.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                AUTHOR = author;
            }
            return Page();
        }
    }
}
