using AspCoreMvc_Filtros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreMvc_Filtros.Data {
    public class AutorDbContext : DbContext {

        public AutorDbContext(DbContextOptions<DbContext> options) : base(options) {}

        public DbSet<Autor> Autores { get; set; }

    }
}
