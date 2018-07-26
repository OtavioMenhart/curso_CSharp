using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicoWebApiPaginacao.Models;

namespace ServicoWebApiPaginacao.Controllers
{
    public class CursosController : ApiController
    {
        private AulaContext db = new AulaContext();

        //POST
        public IHttpActionResult PostCurso(Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Cursos.Add(curso);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = curso.Id }, curso);
        }

        //Get único registro
        public IHttpActionResult GetCurso(int id)
        {
            if (id <= 0)
            {
                return BadRequest("O ID deve ser um número maior que zero");
            }

            var curso = db.Cursos.Find(id);

            if (curso == null)
            {
                return NotFound();
            }

            return Ok(curso);
        }

        //Put
        public IHttpActionResult PutCurso(int id, Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != curso.Id)
            {
                return BadRequest("O ID informado na URL é diferente do ID informado no corpo da requisição");
            }
            if (db.Cursos.Count(c => c.Id == id) == 0)
            {
                return NotFound();
            }
            db.Entry(curso).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        //Delete
        public IHttpActionResult DeleteCurso(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero.");

            var curso = db.Cursos.Find(id);

            if (curso == null)
                return NotFound();

            db.Cursos.Remove(curso);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: api/Curso
        public IHttpActionResult GetCursos(int pagina = 1, int tamanhoPagina = 10)
        {
            /*
             * skip - avançar uma quantidade de registros
             * take - pegar apenas uma quantidade de registros
             */

            var cursos = db.Cursos.OrderBy(c => c.DataPublicacao).Skip(tamanhoPagina * (pagina - 1)).Take(tamanhoPagina);
            return Ok(cursos);
        }
    }
}
