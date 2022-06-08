using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotrecaJoia.Models.Entities;

namespace BibliotrecaJoia.Models.ViewModels
{
    public class LivroViewModel : EntidadeBase
    {
        // public string Id { get; set; } // Id não precisa mais ter, pois herda da EntidadeBase
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public LivroViewModel()
        {
        }

        public LivroViewModel(string id, string nome, string autor, string editora)
            : this(nome, autor, editora)
        {
            this.Id = id;
        }

        public LivroViewModel(string nome, string autor, string editora)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Editora = editora;
        }

    }
}
