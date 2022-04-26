using Asp_Core_Mvc_Filtros.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Mvc_Filtros.Models {
    public class AutorRepository : IAutorRepository {

        private readonly DatabaseContext _dbContext;

        public AutorRepository(DatabaseContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Autor autor) {
            //throw new NotImplementedException();
            if (!_dbContext.Autores.Any()) {
                autor.Id = 1;
            } else {
                int maxId = _dbContext.Autores.Max(x => x.Id);
            }
            _dbContext.Autores.Add(autor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id) {
            var deleteAutor = _dbContext.Autores.FirstOrDefault(x => x.Id == id);
            _dbContext.Autores.Remove(deleteAutor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Autor> GetByIdAsync(int id) {
            return await _dbContext.Autores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Autor>> ListAsync() {
            return await _dbContext.Autores.AsNoTracking().ToListAsync();
        }

        public async Task UpdateAsync(Autor autor) {
            _dbContext.Entry(autor).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
