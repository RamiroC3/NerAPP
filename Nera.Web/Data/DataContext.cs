using Microsoft.EntityFrameworkCore;
using Nera.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nera.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {    
        }
        public DbSet<Rescatista> Rescatistas { get; set; }

        public DbSet<TipoRescate> TipoRescates { get; set; }

        public DbSet<Rescate> Rescates { get; set; }

        public DbSet<RegistroRescate> RegistroRescates { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

    }
}
