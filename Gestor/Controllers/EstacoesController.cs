using System.Collections.Generic;
using System.Web.Mvc;
using Gestao.Infra.Data.Repositories;
using AutoMapper;
using Gestao.Domain.Entities;
using Gestor.ViewModels;

namespace Gestor.Controllers
{
    public class EstacoesController : Controller
    {
        private readonly EstacaoRepository _estacaoRepository = new EstacaoRepository();
         
        // GET: Estacoes
        public ActionResult Index()
        {
            var estacaoViewModel =
                Mapper.Map<IEnumerable<Estacao>, IEnumerable<EstacaoViewModel>>(_estacaoRepository.GetAll());
            return View(estacaoViewModel);
        }

        // GET: Estacoes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estacoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstacaoViewModel estacao)
        {
            if (ModelState.IsValid)
            {
                var estacaoDomain = Mapper.Map<EstacaoViewModel, Estacao>(estacao);
                _estacaoRepository.Add(estacaoDomain);

                return RedirectToAction("Index");
            }
            return View(estacao);
        }

        // POST: Estacoes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estacoes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estacoes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estacoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estacoes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
