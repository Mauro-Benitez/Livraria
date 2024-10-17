using Livraria.Application.Dtos;
using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Livraria.Infraestructure.Context;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var autorExistente = _context.Autores.FirstOrDefault(a => a.Nome == item.AutorLivro);

            Autor autor;

            if (autorExistente == null)
            {
                autor = new Autor
                {
                    Nome = item.AutorLivro,
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
                IdAutor = autor.Id,
                AutorLivro = autor,
            };           
            var livroCriado = _livroRepository.Create(livro);

            item.DataCriacao = livroCriado.DataCriacao;
            item.Id = livroCriado.Id;

            return item;
        }

        public void Delete(long IdItem)
        {           
           _livroRepository.Delete(IdItem);                 
        }

        public List<LivroDto> FindAll()
        {
            var result = _livroRepository.FindAll();

            List<LivroDto> livros = new List<LivroDto>();

            foreach(var item in result)
            {
                var autor = _autorRepository.FindById(item.IdAutor);

                livros.Add(new LivroDto
                {   Id = item.Id,
                    AutorLivro = autor.Nome,
                    Preco = item.Preco,
                    Titulo = item.Titulo
                });
            }

            return livros.ToList();
        }

        public LivroDto FindById(long IdItem)
        {
            var entidade = _livroRepository.FindById(IdItem);
           
            if (entidade == null)
            {
                 throw new Exception("Este livro não existe");

            }

            var autor = _autorRepository.FindById(entidade.IdAutor);
           
                   
                    var entidadeDto = new LivroDto
                    {
                        Id = entidade.Id,
                        Titulo = entidade.Titulo,
                        AutorLivro = autor.Nome,
                        Preco = entidade.Preco,
                        DataCriacao = entidade.DataCriacao
                    };

                    return entidadeDto;       
             
        }   

        public LivroDto Update(LivroDto item)
        {

            var entidade = _livroRepository.FindById((long)item.Id);
            if (entidade == null)
            {
                throw new Exception("Este livro não existe");
            }
                   
                    var autor = _autorRepository.FindById(entidade.IdAutor);

                    entidade.Titulo = item.Titulo;
                    entidade.AutorLivro.Nome = item.AutorLivro;
                    entidade.DataCriacao = item.DataCriacao;
                    entidade.IdAutor = autor.Id;
                    entidade.Preco = item.Preco;
                    _livroRepository.Update(entidade);

                    var entidadeDto = new LivroDto
                    {
                        Id = entidade.Id,
                        Titulo = entidade.Titulo,
                        AutorLivro = autor.Nome,
                        Preco = entidade.Preco,
                        DataCriacao = entidade.DataCriacao
                    };

                    return entidadeDto;              
        }
    }
    
}
