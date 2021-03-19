using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Emission_backend
{
    public class EmissionDbContext:DbContext {
         public DbSet<Emission> emission { get; set; }
             protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=.\bin\emission.db");
    }

}