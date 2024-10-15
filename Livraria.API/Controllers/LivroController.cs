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
    }
}
