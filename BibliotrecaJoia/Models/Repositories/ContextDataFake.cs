using BibliotrecaJoia.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace BibliotrecaJoia.Models.Repositories
{                                     // NOSSO BANCO DE DADOS FAKE
    public static class ContextDataFake
    {
        public static List<LivroViewModel> Livros; // meu objeto estático

        static ContextDataFake()
        {
            Livros = new List<LivroViewModel>();
            InitializeData(); // método que inicializa meu banco de dados
        }

        private static void InitializeData()
        {
            var livro = new LivroViewModel("Implementando Domain-Driven Design", "Vaugh Vernon", "Alta Books");
            Livros.Add(livro);

            livro = new LivroViewModel("Domain-Driven Design", "Eric Evans", "Alta Books");
            Livros.Add(livro);

            livro = new LivroViewModel("Redes Guia Prático", "Carlos E. Morimoto", "Sul Editores");
            Livros.Add(livro);

            livro = new LivroViewModel("PHP Programando com Orientação a Objetos", "Pablo Dall'Oglio", "Novatec");
            Livros.Add(livro);

            livro = new LivroViewModel("Introdução a Programação com Python", "Nilo N. C. Menezes", "Novatec");
            Livros.Add(livro);
        }
    }
}
