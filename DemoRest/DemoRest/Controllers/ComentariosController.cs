using DemoRest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

            public ComentariosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ComentariosController>
        [HttpGet]
        public ActionResult<List<Comentario>> Get()
        {
            try
            {
                var listComentarios = _context.Comentario.ToList();
                return Ok(listComentarios);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        // GET api/<ComentariosController>/5
        [HttpGet("{id}")]
        public ActionResult<Comentario> Get(int id)
        {
           
            try
            {
                var comentario = _context.Comentario.Find(id);
                if (comentario == null)
                {
                    return NotFound();
                }
                return Ok(comentario);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        // POST api/<ComentariosController>
        [HttpPost]
        public ActionResult Post([FromBody] Comentario comentario)
        {
            try
            {
                _context.Add(comentario);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        // PUT api/<ComentariosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Comentario comentario)
        {
            try
            {
               if(id!= comentario.Id)
                {
                    return BadRequest();
                }
                _context.Entry(comentario).State = EntityState.Modified;
                _context.Update(comentario);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        // DELETE api/<ComentariosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var comentario = _context.Comentario.Find(id);
                if (comentario == null)
                {
                    return NotFound();
                }
                _context.Remove(comentario);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
