using ESH_Desafio6.ApplicationService;
using ESH_Desafio6.ApplicationService.Interfaces;
using ESH_Desafio6.ApplicationService.Views;
using System;
using System.Web.Mvc;

namespace ESH_Desafio6.AppWeb.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IFacade _facade;
        public AlunoController()
        {
            _facade = new Facade();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var alunos = _facade.Alunos.ObterTodos();
            return View(alunos);
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var obj = _facade.Alunos.ObterPor(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(AlunoView view)
        {
            try
            {
                _facade.Alunos.Salvar(view);
                _facade.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //TODO: Exibir os Erros na View.
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _facade.Alunos.Excluir(id);
            _facade.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}