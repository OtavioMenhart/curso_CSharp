using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIIntroducao.Models;

namespace APIIntroducao.Controllers
{
    [Produces("application/json")]
    [Route("api/categorias/{CategoriaId}/Produtos")]
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProdutosController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<Produto> GetProdutos(int categoriaId)
        {
            return db.Produtos.Where(x => x.CategoriaId == categoriaId).ToList();
        }

        #region PADRÃO
        /*
        // GET: api/Produtos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produto = await db.Produtos.SingleOrDefaultAsync(m => m.Id == id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // PUT: api/Produtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto([FromRoute] int id, [FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != produto.Id)
            {
                return BadRequest();
            }

            db.Entry(produto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Produtos
        [HttpPost]
        public async Task<IActionResult> PostProduto([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Produtos.Add(produto);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        }

        // DELETE: api/Produtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produto = await db.Produtos.SingleOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            db.Produtos.Remove(produto);
            await db.SaveChangesAsync();

            return Ok(produto);
        }*/
        #endregion

        private bool ProdutoExists(int id)
        {
            return db.Produtos.Any(e => e.Id == id);
        }
    }
}