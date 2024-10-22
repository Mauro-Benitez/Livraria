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

        private readonly ILivroService _livroService;

        public LivroController(ILivroService repository)
        {
            _livroService = repository;
        }



        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            return Ok(_livroService.FindAll());
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            if(_livroService.FindById(id) == null) return NotFound("Livro não existe");
            
            return Ok(_livroService.FindById(id));          
      
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
                var novoLivro = _livroService.Create(livro);
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
            if(_livroService.Update(livro) == null) return BadRequest("Este livro ainda não está cadastrado");  
            
            _livroService.Update(livro);
             return Ok(livro);                
         
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public  IActionResult Delete([FromRoute] int id)
        {
            if(_livroService.FindById(id) == null) return NotFound("Livro não existe");                                                    

            _livroService.Delete(id);
            return Ok();

        }

    }
}
