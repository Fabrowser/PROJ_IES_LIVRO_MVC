using Capitulo01_MVC.Models;
using Capitulo01_MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capitulo01_MVC.Data.DAL.Cadastros;

namespace Modelo.Cadastros
{
    public class InstituicaoController : Controller
    {
        public readonly IESContext _context;
        private readonly InstituicaoDAL instituicaoDal;


        public InstituicaoController(IESContext context)
        {

            this._context=context;
            instituicaoDal= new InstituicaoDAL(_context);

        }

        public async Task<IActionResult> Index()
        {
            return View(await instituicaoDal.ObterInstituicoesClassificadasPorNome().ToListAsync());
        }


        //	GET:	Instituicao/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        //	POST:	Instituicao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome", "Endereco")] Instituicao instituicao)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    await instituicaoDal.GravarInstituicao(instituicao);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Não foi possivel Inserir os dados.");
            }

            return View(instituicao);

        }

        [HttpGet]
        public async Task<IActionResult> Edit(long? id)
        {

            return await ObterVisaoInstituicaoPorId(id);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(long? id, [Bind("InstituicaoID,Nome,Endereco")] Instituicao instituicao)
        {

            if (id != instituicao.InstituicaoID)
            {
                return NotFound();

            }

            if (ModelState.IsValid)
            {
                try
                {
                    await instituicaoDal.GravarInstituicao(instituicao);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await InstituicaoExists(instituicao.InstituicaoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(instituicao);

        }

        private async Task<bool> InstituicaoExists(long? id)
        {
            return await instituicaoDal.ObterInstituicaoPorId((long)id)!=null;
        }


        public async Task<IActionResult> Details(long? id)
        {

            return await ObterVisaoInstituicaoPorId(id);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {

            return await ObterVisaoInstituicaoPorId(id);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var instituicao = await instituicaoDal.EliminarInstituicaoPorId((long) id);

            TempData["Message"] = "Instituição	" + instituicao.Nome.ToUpper() + "	foi	removida";

            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> ObterVisaoInstituicaoPorId(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicao  = await instituicaoDal.ObterInstituicaoPorId ((long)id);

            if(instituicao==null)
            {
                return NotFound();
            }

            return View(instituicao);

        }


        //O Codigo abaixo foi criado no CAPITULO 01 com dados sendo do tipo LIST para exemplificar acesso a dados.

        /* private static IList<Instituicao> instituicoes = new List<Instituicao>()
         {

         new Instituicao()   {

          InstituicaoID   =   1,
          Nome    =   "UniParaná",
          Endereco    =   "Paraná"

         },

         new Instituicao()
         {

          InstituicaoID = 2,
          Nome = "UniSanta",
          Endereco = "Santa	Catarina"

         },

         new Instituicao()
         {

          InstituicaoID = 3,
          Nome = "UniSãoPaulo",
          Endereco = "São Paulo"

         },

         new Instituicao()
         {
          InstituicaoID = 4,
          Nome = "UniSulgrandense",
          Endereco = "Rio	Grande	do	Sul",

         },

         new Instituicao()
         {
          InstituicaoID = 5,
          Nome = "UniCarioca",
          Endereco = "Rio de	Janeiro"

         }

         };*/



        /*public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.Nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(long Id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == Id).First());

        }

        [HttpPost]
        public ActionResult Edit(Instituicao instituicao)
        {

            instituicoes[instituicoes.IndexOf(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First())] = instituicao;
            //Maneira Alternativa 
            //instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            //instituicoes.Add(instituicao);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Details(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        [HttpGet]

        public ActionResult Delete(long id)
        {
            return View (instituicoes.Where(i => i.InstituicaoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            return RedirectToAction("index");
        }*/




    }
}
