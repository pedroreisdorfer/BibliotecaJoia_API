using BibliotrecaJoia.Models.Contracts.services;
using Microsoft.AspNetCore.Mvc;
using System;
using BibliotrecaJoia.Models.ViewModels;

namespace BibliotrecaJoia.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var livros = _livroService.Listar();
                return View(livros);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IActionResult Create()
        {
            return View(); // quando apertar lá em Create, irá retornar para mim uma View, uma página onde vou fazer cadastro do meu livro
        }                  // precisa de uma segunda action em Create, pois dps de salvar meu cadastro, essa nova action faz o cadastro no banco mesmo dai

        [HttpPost] // se não identificar nada, ele é um GET
        [ValidateAntiForgeryToken] // para proteger a página contra ataques CSRF
        public IActionResult Create([Bind("Nome, Autor, Editora")] LivroViewModel livro) // Bind usado para que ele entenda os campos que precisam ser usados como base para poder montar meu objeto livro
        {
            try
            {
                _livroService.Cadastrar(livro);

                return RedirectToAction("List");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // esse edit é GET, que é de solicitação
        public IActionResult Edit(string? id) // action de pesquisa de informação
        {
            var livro = _livroService.PesquisarPorId(id);

            if (string.IsNullOrEmpty(id) || livro == null)
            {
                return NotFound();
            }


            return View(livro);
        }

        [HttpPost] // aqui é o edit do processamento, que vai atualizar. Poderia ter usado  httpput para atualização
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id, Nome, Autor, Editora")] LivroViewModel livro)
        {
            if (string.IsNullOrEmpty(livro.Id))
            {
                return NotFound();
            }

            try
            {
                _livroService.Atualizar(livro);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Details(string? id) // para cria sua view, é só apertar com o botão direito em Details e add uma view
        {
            var livro = _livroService.PesquisarPorId(id);

            if (string.IsNullOrEmpty(id) || livro == null)
            {
                return NotFound();
            }


            return View(livro);
        }

        public IActionResult Delete(string? id)  // função que carrega as informações com detalhes antes de efetivar a exclusão. Por padrão aqui é o método GET
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }

            var livro = _livroService.PesquisarPorId(id);

            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        [HttpPost]
        public IActionResult Delete([Bind("Id, Nome, Autor, Editora")] LivroViewModel livro)
        {


            _livroService.Atualizar(livro);
            return RedirectToAction("List");

        }

    }
}
