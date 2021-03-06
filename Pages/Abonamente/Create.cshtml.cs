using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hoanta_Roxana_Proiectgym.Data;
using Hoanta_Roxana_Proiectgym.Models;

namespace Hoanta_Roxana_Proiectgym.Pages.Abonamente
{
    public class CreateModel : PageModel
    {
        private readonly Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext _context;

        public CreateModel(Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["AntrenorID"] = new SelectList(_context.Set<Antrenor>(), "ID", "NumeAntrenor");
            ViewData["CursID"] = new SelectList(_context.Set<Curs>(), "ID", "DenumireCurs");
            return Page();
        }

        [BindProperty]
        public Abonament Abonament { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Abonament.Add(Abonament);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
