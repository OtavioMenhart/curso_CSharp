using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntroducao.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIIntroducao.Controllers
{
    [Produces("application/json")]
    [Route("api/Categorias")]
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext db;
                
        public CategoriasController(ApplicationDbContext db)
        {
            this.db = db;
        }

        //PARA USAR AUTENTICAÇÃO
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return db.Categorias.ToList();
        }

        [HttpGet("{id}", Name = "categoriaCriada")]
        public IActionResult GetById(int id)
        {
            var cat = db.Categorias.Include(x => x.Produtos).FirstOrDefault(x => x.Id == id);

            if (cat == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cat);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] Categoria cat)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(cat);
                db.SaveChanges();
                return new CreatedAtRouteResult("categoriaCriada", new { id = cat.Id }, cat);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }


        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Categoria cat, int id)
        {
            if (cat.Id != id)
            {
                return BadRequest(ModelState);                
            }
            else
            {
                db.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return Ok();
            }

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cat = db.Categorias.FirstOrDefault(x => x.Id == id);
            if (cat == null)
            {
                return BadRequest(ModelState);
            }
            else
            {
                db.Categorias.Remove(cat);
                db.SaveChanges();
                return Ok();
            }

        }

    }
}