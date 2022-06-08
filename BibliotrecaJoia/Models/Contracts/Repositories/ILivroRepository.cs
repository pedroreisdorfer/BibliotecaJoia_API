using BibliotrecaJoia.Models.ViewModels;
using System.Collections.Generic;

namespace BibliotrecaJoia.Models.Contracts.Repositories
{
    public interface ILivroRepository
    {      // aqui é feito o crud
        void Cadastrar(LivroViewModel livro);
        List<LivroViewModel> Listar();
        LivroViewModel PesquisarPorId(string id);
        void Atualizar(LivroViewModel livro);
        void Excluir(string id);
    }
}
