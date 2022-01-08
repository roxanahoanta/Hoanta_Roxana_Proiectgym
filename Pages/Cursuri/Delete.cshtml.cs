using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hoanta_Roxana_Proiectgym.Data;
using Hoanta_Roxana_Proiectgym.Models;

namespace Hoanta_Roxana_Proiectgym.Pages.Cursuri
{
    public class DeleteModel : PageModel
    {
        private readonly Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext _context;

        public DeleteModel(Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Curs Curs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curs = await _context.Curs.FirstOrDefaultAsync(m => m.ID == id);

            if (Curs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Curs = await _context.Curs.FindAsync(id);

            if (Curs != null)
            {
                _context.Curs.Remove(Curs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
