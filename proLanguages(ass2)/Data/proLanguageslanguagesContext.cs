using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using languages.models;

    public class proLanguageslanguagesContext : DbContext
    {
        public proLanguageslanguagesContext (DbContextOptions<proLanguageslanguagesContext> options)
            : base(options)
        {
        }

        public DbSet<languages.models.proLanguage> proLanguage { get; set; }
    }
