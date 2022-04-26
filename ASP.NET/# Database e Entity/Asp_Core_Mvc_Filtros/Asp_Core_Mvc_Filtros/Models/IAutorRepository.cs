using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Mvc_Filtros.Models {
    public interface IAutorRepository {

        Task<Autor> GetByIdAsync(int id);

        Task<List<Autor>> ListAsync();

        Task UpdateAsync(Autor autor);

        Task AddAsync(Autor autor);

        Task DeleteAsync(int id);

    }
}
