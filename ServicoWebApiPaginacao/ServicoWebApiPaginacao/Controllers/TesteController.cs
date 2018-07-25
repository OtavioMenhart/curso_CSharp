using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ServicoWebApiPaginacao.Models;

namespace ServicoWebApiPaginacao.Controllers
{
    public class TesteController : ApiController
    {
        private AulaContext db = new AulaContext();

        // GET: api/Teste
        public IQueryable<Curso> GetCursos()
        {
            return db.Cursos;
        }

        // GET: api/Teste/5
        [ResponseType(typeof(Curso))]
        public IHttpActionResult GetCurso(int id)
        {
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return NotFound();
            }

            return Ok(curso);
        }

        // PUT: api/Teste/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCurso(int id, Curso curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != curso.Id)
            {
                return BadRequest();
            }

            db.Entry(curso).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Teste
        [ResponseType(typeof(Curso))]
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

        // DELETE: api/Teste/5
        [ResponseType(typeof(Curso))]
        public IHttpActionResult DeleteCurso(int id)
        {
            Curso curso = db.Cursos.Find(id);
            if (curso == null)
            {
                return NotFound();
            }

            db.Cursos.Remove(curso);
            db.SaveChanges();

            return Ok(curso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CursoExists(int id)
        {
            return db.Cursos.Count(e => e.Id == id) > 0;
        }
    }
}