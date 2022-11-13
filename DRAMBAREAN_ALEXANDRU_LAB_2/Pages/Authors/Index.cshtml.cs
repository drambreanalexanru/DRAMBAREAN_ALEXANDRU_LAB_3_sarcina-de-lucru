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
    public class IndexModel : PageModel
    {
        private readonly DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context _context;

        public IndexModel(DRAMBAREAN_ALEXANDRU_LAB_2.Data.DRAMBAREAN_ALEXANDRU_LAB_2Context context)
        {
            _context = context;
        }

        public IList<AUTHOR> AUTHOR { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AUTHOR != null)
            {
                AUTHOR = await _context.AUTHOR
                    .Include(b => b.Authors)
                    .ToListAsync();









            }
        }
    }
}
