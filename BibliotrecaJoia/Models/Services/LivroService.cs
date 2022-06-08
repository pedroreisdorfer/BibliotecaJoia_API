using System;
using System.Collections.Generic;
using BibliotrecaJoia.Models.Contracts.services;
using System.Threading.Tasks; // para uso das operações assíncronas //
using BibliotrecaJoia.Models.ViewModels;
using BibliotrecaJoia.Models.Contracts.Repositories;

namespace BibliotrecaJoia.Models.Services
{                                        // meu serviço vai acessar minha camada de repositório
                                         // e disponibilizar a quem requisitar um serviço de livros
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;   // criando assim uma dependência do repositório // depois será DbContext //

        public LivroService(ILivroRepository livroRepository) // construtor para que injeção de dependência possa ocorrer //
        { // será instanciado quando tiver a requisição ao meu LivroService
            _livroRepository = livroRepository;
        }

        public void Atualizar(LivroViewModel livro)
        {
            try
            {
                _livroRepository.Atualizar(livro); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cadastrar(LivroViewModel livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro); // pega os cadastros dos livros no meu DB fake, que podemos acessar pela variável _livroRepository
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(string id)
        {
            try
            {
                _livroRepository.Excluir(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LivroViewModel> Listar()
        {
            try
            {
                return _livroRepository.Listar(); // acessa repositório e retorna
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public LivroViewModel PesquisarPorId(string id)
        {
            try
            {
                return _livroRepository.PesquisarPorId(id); // acessa repositório e retorna
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
