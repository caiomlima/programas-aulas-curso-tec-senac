using Produtos_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos_API.Services {
    public class ProdutoRepository : IProdutoRepository {

        private List<Produto> _produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepository() {
            NewProduct(new Produto { Nome = "Guaraná", Categoria = "Bebidas", Preco = 8.99M });
            NewProduct(new Produto { Nome = "Sabão em Pó", Categoria = "Limpeza", Preco = 20.00M });
            NewProduct(new Produto { Nome = "Sonho de Valsa", Categoria = "Doces", Preco = 1.50M });
            NewProduct(new Produto { Nome = "Danoninho", Categoria = "Gelados", Preco = 1.99M });
            NewProduct(new Produto { Nome = "Trakinas", Categoria = "Doces", Preco = 2.99M });
        }

        public IEnumerable<Produto> GetAllProducts() {
            return _produtos;
        }

        public Produto GetById(int id) {
            return _produtos.Find(x => x.Id == id);
        }

        public Produto NewProduct(Produto produto) {
            if(produto == null) {
                throw new ArgumentException("produto");
            }
            produto.Id = _nextId++;
            _produtos.Add(produto);
            return produto;
        }

        public void RemoveProduct(int id) {
            _produtos.RemoveAll(x => x.Id == id);
        }

        public bool UpdateProduct(Produto produto) {
            if(produto == null) {
                throw new ArgumentException("produto");
            }
            int index = _produtos.FindIndex(x => x.Id == produto.Id);
            if(index == 1) {
                return false;
            }
            _produtos.RemoveAt(index);
            _produtos.Add(produto);
            return true;
        }
    }
}
