using Microsoft.EntityFrameworkCore;
using MVC_EF_CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_EF_CORE.Data {
    public class DatabaseContext : DbContext {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
