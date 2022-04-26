using Asp_Core_Mvc_Filtros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Mvc_Filtros.Data {
    public class DatabaseContext : DbContext {

        public DatabaseContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }

    }
}
