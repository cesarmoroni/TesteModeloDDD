using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TesteModeloDDD.Application.Interface;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.MVC.ViewModels;
using System.Linq;

namespace TesteModeloDDD.MVC.Controllers
{
    public class LivrosController : Controller
    {
        // GET: Livros
        private readonly ILivroAppService _LivroApp;
        private readonly ICategoriaAppService _CategoriaApp;

        public LivrosController(ILivroAppService LivroApp, ICategoriaAppService CategoriaApp)
        {
            _LivroApp = LivroApp;
            _CategoriaApp = CategoriaApp;
        }

        // GET: Categoria
        public ActionResult Index()
        {
            var LivroViewModel = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(
                _LivroApp.GetAll().OrderBy(e => e.Nome));

            return View(LivroViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(_CategoriaApp.GetAll(), "CategoriaId", "Nome");
            return View();
        }

        // POST: Categoria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _LivroApp.Add(LivroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_CategoriaApp.GetAll(), "CategoriaId", "Nome", Livro.CategoriaId);
            return View(Livro);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            ViewBag.CategoriaId = new SelectList(_CategoriaApp.GetAll(), "CategoriaId", "Nome", LivroViewModel.CategoriaId);

            return View(LivroViewModel);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LivroViewModel Livro)
        {
            if (ModelState.IsValid)
            {
                var LivroDomain = Mapper.Map<LivroViewModel, Livro>(Livro);
                _LivroApp.Update(LivroDomain);

                return RedirectToAction("Index");
            }

            ViewBag.CategoriaId = new SelectList(_CategoriaApp.GetAll(), "CategoriaId", "Nome", Livro.CategoriaId);
            return View(Livro);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var Livro = _LivroApp.GetById(id);
            var LivroViewModel = Mapper.Map<Livro, LivroViewModel>(Livro);

            return View(LivroViewModel);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Livro = _LivroApp.GetById(id);
            _LivroApp.Remove(Livro);

            return RedirectToAction("Index");
        }
    }
}