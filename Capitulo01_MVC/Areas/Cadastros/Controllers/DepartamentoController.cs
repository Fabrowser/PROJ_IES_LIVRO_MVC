using Capitulo01_MVC.Data;
using Capitulo01_MVC.Data.DAL.Cadastros;
using Capitulo01_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    [Area("Cadastros")]
    [Authorize]
    public class DepartamentoController : Controller
    {

        private readonly IESContext _context;
        private readonly DepartamentoDAL departamentoDal;
        private readonly InstituicaoDAL instituicaoDal;


        public DepartamentoController(IESContext context)
        {
            this._context = context;
            instituicaoDal = new InstituicaoDAL(context);
            departamentoDal = new DepartamentoDAL(context);
        }


        public async Task<IActionResult> Index()
        {
            return View(await departamentoDal.ObterDepartamentosClassificadosPorNome().ToListAsync());
        }



        //	GET:	Departamento/Create
        [HttpGet]
        public IActionResult Create()
        {
            var instituicoes = instituicaoDal.ObterInstituicoesClassificadasPorNome().ToList();

            instituicoes.Insert(0, new Instituicao() { InstituicaoID = 0, Nome = "Seleciona a instituição" });
            ViewBag.Instituicoes = instituicoes;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome", "InstituicaoID")] Departamento departamento)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    await departamentoDal.GravarDepartamento(departamento);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Não foi possivel Inserir os dados.");
            }

            return View(departamento);

        }


        //	GET: Departamento/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(long? id)
        {
            ViewResult visaoDepartamento = (ViewResult)await ObterVisaoDepartamentoPorId(id);
            Departamento departamento = (Departamento)visaoDepartamento.Model;

            ViewBag.Instituicoes = new SelectList(instituicaoDal.ObterInstituicoesClassificadasPorNome(), "InstituicaoID", "Nome", departamento.InstituicaoID);

            return visaoDepartamento;

        }



        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(long? id, [Bind("DepartamentoID,Nome, InstituicaoID")] Departamento departamento)
        {

            if (id != departamento.DepartamentoID)
            {
                return NotFound();

            }

            if (ModelState.IsValid)
            {
                try
                {
                    await departamentoDal.GravarDepartamento(departamento);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await DepartamentoExists(departamento.DepartamentoID))
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

            ViewBag.Instituicoes = new SelectList(instituicaoDal.ObterInstituicoesClassificadasPorNome(), "InnstituicaoID", "Nome", departamento.InstituicaoID);
            return View(departamento);

        }




        private async Task<bool> DepartamentoExists(long? id)
        {
            return departamentoDal.ObterDepartamentoPorId((long)id) != null;

        }


        public async Task<IActionResult> Details(long? id)
        {

            return await ObterVisaoDepartamentoPorId(id);

        }



        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            return await ObterVisaoDepartamentoPorId(id);

        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var departamento = await departamentoDal.EliminarDepartamentoPorId((long)id);
            TempData["Message"] = "Departamento " + departamento.Nome.ToUpper() + " foi removido";
            return RedirectToAction(nameof(Index));
        }

        private async Task<IActionResult> ObterVisaoDepartamentoPorId(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var departamento = await departamentoDal.ObterDepartamentoPorId((long)id);
            if (departamento == null)
            {
                return NotFound();
            }
            return View(departamento);
        }

    }
}
