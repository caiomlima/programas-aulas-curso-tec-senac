using Microsoft.AspNetCore.Mvc;
using Produtos_API.Models;
using Produtos_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Produtos_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase {

        static readonly IProdutoRepository _repository = new ProdutoRepository();

        /*-------------------------------------------------- Get --------------------------------------------------*/
        [HttpGet]
        public IEnumerable<Produto> GetAll() {
            return _repository.GetAllProducts();
        }


        /*-------------------------------------------------- Get By Id --------------------------------------------------*/
        [HttpGet("{id}", Name = "GetProduto")]
        public IActionResult GetProductById(int id) {
            Produto produto = _repository.GetById(id);
            if(produto == null) {
                return NotFound();
            }
            return Ok(produto);
        }


        /*-------------------------------------------------- Create --------------------------------------------------*/
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Produto produto) {
            if(produto == null) {
                return BadRequest();
            }
            produto = _repository.NewProduct(produto);
            return CreatedAtRoute("GetProduto", new { id = produto.Id }, produto);
        }


        /*-------------------------------------------------- Edit --------------------------------------------------*/
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Produto produto) {
            if (produto == null) {
                return BadRequest();
            }
            produto.Id = id;
            if(!_repository.UpdateProduct(produto)) {
                return NotFound();
            }
            return new NoContentResult();
        }


        /*-------------------------------------------------- Delete --------------------------------------------------*/
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id) {
            Produto produto = _repository.GetById(id);
            if(produto == null) {
                return BadRequest();
            }
            _repository.RemoveProduct(id);
            return new NoContentResult();
        }

    }
}
