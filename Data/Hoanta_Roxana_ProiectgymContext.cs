using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hoanta_Roxana_Proiectgym.Models;

namespace Hoanta_Roxana_Proiectgym.Data
{
    public class Hoanta_Roxana_ProiectgymContext : DbContext
    {
        public Hoanta_Roxana_ProiectgymContext (DbContextOptions<Hoanta_Roxana_ProiectgymContext> options)
            : base(options)
        {
        }

        public DbSet<Hoanta_Roxana_Proiectgym.Models.Abonament> Abonament { get; set; }

        public DbSet<Hoanta_Roxana_Proiectgym.Models.Antrenor> Antrenor { get; set; }

        public DbSet<Hoanta_Roxana_Proiectgym.Models.Curs> Curs { get; set; }
    }
}
