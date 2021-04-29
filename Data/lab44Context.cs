using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab44.modele;

namespace lab44.Data
{
    public class lab44Context : DbContext
    {
        public lab44Context (DbContextOptions<lab44Context> options)
            : base(options)
        {
        }

        public DbSet<lab44.modele.Car> Car { get; set; }

        public DbSet<lab44.modele.Telefon> Telefon { get; set; }

        public DbSet<lab44.modele.Kierowca> Kierowca { get; set; }

        public DbSet<lab44.modele.Zmiana> Zmiana { get; set; }
    }
}
