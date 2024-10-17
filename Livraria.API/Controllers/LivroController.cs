using Livraria.Application.Dtos;
using Livraria.Application.Services;
using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LivroController : Controller
    {

        private readonly ILivroService _repository;

        public LivroController(ILivroService repository)
        {
            _repository = repository;
        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            return Ok(_repository.FindAll());
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            if(_repository.FindById(id) != null)
            {
                return Ok(_repository.FindById(id));
            }

            else
            {
                return NotFound("Id não existe");
            }
            
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public IActionResult Create([FromBody] LivroDto livro)
        {
            if (livro == null) return BadRequest();
            livro.DataCriacao = null;
            try
            {
                var novoLivro = _repository.Create(livro);
                return Ok(novoLivro);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update([FromBody] LivroDto livro)
        {
            if(_repository.Update(livro) != null)
            {
                try
                {
                    _repository.Update(livro);
                    return Ok(livro);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest("Este livro ainda não está cadastrado");
            }
            
            
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public  IActionResult Delete([FromRoute] int id)
        {
            if(_repository.FindById(id) != null)
            {
                try
                {
                    _repository.Delete(id);
                    return Ok();
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }

            else
            {
                return NotFound("Id não existe");
            }
          
            
        }

    }
}
