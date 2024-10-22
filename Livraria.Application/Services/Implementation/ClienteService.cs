using Livraria.Application.Dtos;
using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Livraria.Infraestructure.Context;
using Livraria.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services.Implementation
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;       
        private readonly DbEditContext _context;

        public ClienteService(IClienteRepository clienteRepository, DbEditContext context)
        {
            _clienteRepository = clienteRepository;
            _context = context;
        }

        //Eager Loading
        public ClienteDto ObterPedidosDoCliente(int id)
        {
            var entidadeDto = _clienteRepository.ObterPedidosDoCliente(id);

            var clienteDto = new ClienteDto
            {
                Id = entidadeDto.Id,
                Nome = entidadeDto.Nome,
                CPF = entidadeDto.CPF,
                Endereco = entidadeDto.Endereco,
                PedidosDtos = entidadeDto.Pedidos.Select(p => new PedidoDto
                {
                    Id = p.Id,
                    IdCliente = p.IdCliente,
                    LivroDto = new LivroDto
                    {
                        Titulo = p.Livro.Titulo,
                        Preco = p.Livro.Preco,
                        AutorLivro = p.Livro.AutorLivro.Nome
                        
                    }
                }).ToList()


            };

            return clienteDto;
        }

        public ClienteDto Create(ClienteDto item)
        {
            var cliente = new Cliente
            {
                Nome = item.Nome,
                CPF = item.CPF,
                Endereco = item.Endereco,
             
            };
             
            var result = _clienteRepository.Create(cliente);

            return new ClienteDto
            {   Id = result.Id,
                Nome = result.Nome,
                CPF = result.CPF,
                Endereco = result.Endereco,
                
            };


        }

        public void Delete(long IdItem)
        {
            _clienteRepository.Delete(IdItem);
        }

        public List<ClienteDto> FindAll()
        {
            var result = _clienteRepository.FindAll();

            List<ClienteDto> Clientes = new List<ClienteDto>();

            foreach (var item in result)
            {
                Clientes.Add(new ClienteDto
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    CPF = item.CPF,
                    Endereco = item.Endereco,

                });
            }

            return Clientes.ToList();
        }

        public ClienteDto FindClinteById(long IdItem)
        {
            var entidade = _clienteRepository.FindById(IdItem);

            if (entidade == null) return null;

            return new ClienteDto
            {   Id = entidade.Id,
                Nome = entidade.Nome,
                CPF = entidade.CPF,
                Endereco = entidade.Endereco,

            };

        }        

        public ClienteDto Update(ClienteDto item)
        {
            var entidade = _clienteRepository.FindById((long)item.Id);

            if (entidade == null) return null;

            entidade.Nome = item.Nome;
            entidade.CPF = item.CPF;
            entidade.Endereco = item.Endereco;

            _clienteRepository.Update(entidade);

            return new ClienteDto
            {   Id = item.Id,
                Nome = item.Nome,
                CPF = item.CPF,
                Endereco = item.Endereco,

            };

        }
    }
}
