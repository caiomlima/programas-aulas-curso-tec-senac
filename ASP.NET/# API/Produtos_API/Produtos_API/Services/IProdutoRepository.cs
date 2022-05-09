using Produtos_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_API.Services {
    public interface IProdutoRepository {

        IEnumerable<Produto> GetAllProducts();

        Produto GetById(int id);

        Produto NewProduct(Produto produto);

        bool UpdateProduct(Produto produto);

        void RemoveProduct(int id);

    }
}
