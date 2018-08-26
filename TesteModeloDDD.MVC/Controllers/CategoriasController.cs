using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using TesteModeloDDD.Application.Interface;
using TesteModeloDDD.Domain.Entities;
using TesteModeloDDD.MVC.ViewModels;
using System.Linq;

namespace TesteModeloDDD.MVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaAppService _CategoriaApp;

        public CategoriasController(ICategoriaAppService CategoriaApp)
        {
            _CategoriaApp = CategoriaApp;
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var CategoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(
                _CategoriaApp.GetAll().OrderByDescending(e=>e.Nome)
                );
            return View(CategoriaViewModel);
        }

        private ActionResult View(object orderby)
        {
            throw new NotImplementedException();
        }

        // GET: Categorias/Details/5
        public ActionResult Details(int id)
        {
            var Categoria = _CategoriaApp.GetById(id);
            var CategoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(Categoria);

            return View(CategoriaViewModel);
        }

        // GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaViewModel Categoria)
        {
            if (ModelState.IsValid)
            {
                var CategoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(Categoria);
                _CategoriaApp.Add(CategoriaDomain);

                return RedirectToAction("Index");
            }

            return View(Categoria);
        }

        // GET: Categorias/Edit/5
        public ActionResult Edit(int id)
        {
            var Categoria = _CategoriaApp.GetById(id);
            var CategoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(Categoria);

            return View(CategoriaViewModel);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriaViewModel Categoria)
        {
            if (ModelState.IsValid)
            {
                var CategoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(Categoria);
                _CategoriaApp.Update(CategoriaDomain);

                return RedirectToAction("Index");
            }

            return View(Categoria);
        }

        // GET: Categorias/Delete/5
        public ActionResult Delete(int id)
        {
            var Categoria = _CategoriaApp.GetById(id);
            var CategoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(Categoria);

            return View(CategoriaViewModel);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Categoria = _CategoriaApp.GetById(id);
            _CategoriaApp.Remove(Categoria);

            return RedirectToAction("Index");
        }
    }
}
