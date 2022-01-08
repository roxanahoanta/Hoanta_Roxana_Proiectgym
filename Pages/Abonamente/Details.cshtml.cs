using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hoanta_Roxana_Proiectgym.Data;
using Hoanta_Roxana_Proiectgym.Models;

namespace Hoanta_Roxana_Proiectgym.Pages.Abonamente
{
    public class DetailsModel : PageModel
    {
        private readonly Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext _context;

        public DetailsModel(Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext context)
        {
            _context = context;
        }

        public Abonament Abonament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Abonament = await _context.Abonament.FirstOrDefaultAsync(m => m.ID == id);

            if (Abonament == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
