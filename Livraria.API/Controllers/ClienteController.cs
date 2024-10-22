using Livraria.Application.Dtos;
using Livraria.Application.Services;
using Livraria.Application.Services.Implementation;
using Livraria.Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {

        private readonly IClienteService _clienteService;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteService clienteService, IClienteRepository clienteRepository )
        {
            _clienteService = clienteService;
            _clienteRepository = clienteRepository;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            return Ok(_clienteService.FindAll());
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            if (_clienteService.FindClinteById(id) == null) return NotFound("Livro não existe");

            return Ok(_clienteService.FindClinteById(id));

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Create([FromBody] ClienteDto cliente)
        {
            if (cliente == null) return BadRequest();
            
            try
            {
                var clienteLivro = _clienteService.Create(cliente);
                return Ok(clienteLivro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Update([FromBody] ClienteDto cliente)
        {
            if (_clienteService.Update(cliente) == null) return BadRequest("Este livro ainda não está cadastrado");

            _clienteService.Update(cliente);
            return Ok(cliente);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete([FromRoute] int id)
        {
            if (_clienteService.FindClinteById(id) == null) return NotFound("Livro não existe");

            _clienteService.Delete(id);
            return Ok();

        }

        [HttpGet("ObterPedidosDoCliente/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult RetornarPedidosDoCliente([FromRoute] int id)
        {
            try
            {
                var result = _clienteService.ObterPedidosDoCliente(id);
                return Ok(result);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }



    }
}
