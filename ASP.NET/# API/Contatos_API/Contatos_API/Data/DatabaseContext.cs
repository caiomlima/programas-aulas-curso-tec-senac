using Contatos_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contatos_API.Data {
    public class DatabaseContext : DbContext {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }

    }
}
