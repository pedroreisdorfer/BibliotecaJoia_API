using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; // para uso das operações assíncronas //
using BibliotrecaJoia.Models.ViewModels;


namespace BibliotrecaJoia.Models.Contracts.services
{
    public interface ILivroService
    {
        void Cadastrar(LivroViewModel livro);
        List<LivroViewModel> Listar();
        LivroViewModel PesquisarPorId(string id);
        void Atualizar(LivroViewModel livro);
        void Excluir(string id);
    }
}
