using BibliotrecaJoia.Models.Contracts.Repositories;
using BibliotrecaJoia.Models.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;


namespace BibliotrecaJoia.Models.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public void Atualizar(LivroViewModel livro)
        {
            var objPesquisa = PesquisarPorId(livro.Id);
            ContextDataFake.Livros.Remove(objPesquisa);  // remove

            objPesquisa.Nome = livro.Nome; // atualiza
            objPesquisa.Editora = livro.Editora;
            objPesquisa.Autor = livro.Autor;

            Cadastrar(objPesquisa);
        }

        public void Cadastrar(LivroViewModel livro)
        {
            ContextDataFake.Livros.Add(livro);  // livros cadastrados vão estar no meu DB fake
        }

        public void Excluir(string id)
        {
            var objPesquisa = PesquisarPorId(id);
            ContextDataFake.Livros.Remove(objPesquisa);
        }

        public List<LivroViewModel> Listar()
        {
            var livros = ContextDataFake.Livros; //  a variável recebe minha lista "Livros" do meu bancod de dados fake
            return livros.OrderBy(p => p.Nome).ToList(); // a variável então é ordenada por nome e transformada em lista
        }

        public LivroViewModel PesquisarPorId(string id)
        {
            var livro = ContextDataFake.Livros.FirstOrDefault(p => p.Id == id);
            return livro;
        }
    }
}
