using Livraria.Application.Dtos;
using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Livraria.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services.Implementation
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IRepository<Autor> _autorRepository;
        private readonly DbEditContext _context;

        public LivroService(ILivroRepository livroRepository, IRepository<Autor> autorRepository, DbEditContext context)
        {
            _livroRepository = livroRepository;
            _autorRepository = autorRepository;
            _context = context;
        }

        public LivroDto Create(LivroDto item)
        {
            var autorExistente = _context.Autores.FirstOrDefault(a => a.Nome == item.Autor);

            Autor autor;

            if (autorExistente == null)
            {
                autor = new Autor
                {
                    Nome = item.Autor,
                    DataNascimento = null

                };

                _autorRepository.Create(autor);

            }
            else
            {
                autor = autorExistente;
            }

            var livro = new Livro
            {
                Titulo = item.Titulo,
                Preco = item.Preco,
                Autor = autor,
            };

            item.DataCriacao = livro.DataCriacao;

            _livroRepository.Create(livro);

            return item;
        }

        public void Delete(long IdItem)
        {
            throw new NotImplementedException();
        }

        public List<LivroDto> FindAll()
        {
            throw new NotImplementedException();
        }

        public LivroDto FindById(long IdItem)
        {
            throw new NotImplementedException();
        }

        public LivroDto Update(LivroDto item)
        {
            throw new NotImplementedException();
        }
    }
    
}
