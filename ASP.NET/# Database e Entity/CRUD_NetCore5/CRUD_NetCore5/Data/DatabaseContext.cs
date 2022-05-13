using CRUD_NetCore5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NetCore5.Data {
    public class DatabaseContext : DbContext {

        public DatabaseContext(DbContextOptions<DatabaseContext> option) : base(option)  { }

        public DbSet<Livro> Livros { get; set; }

    }
}
