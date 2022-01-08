using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hoanta_Roxana_Proiectgym.Data;
using Hoanta_Roxana_Proiectgym.Models;

namespace Hoanta_Roxana_Proiectgym.Pages.Antrenori
{
    public class IndexModel : PageModel
    {
        private readonly Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext _context;

        public IndexModel(Hoanta_Roxana_Proiectgym.Data.Hoanta_Roxana_ProiectgymContext context)
        {
            _context = context;
        }

        public IList<Antrenor> Antrenor { get;set; }

        public async Task OnGetAsync()
        {
            Antrenor = await _context.Antrenor.ToListAsync();
        }
    }
}
