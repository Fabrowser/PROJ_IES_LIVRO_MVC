using Capitulo01_MVC.Data;
using Capitulo01_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC.Controllers
{
    public class DepartamentoController : Controller
    {

        private readonly IESContext _context;


        public DepartamentoController(IESContext context)
        {
            this._context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Departamentos.Include(i => i.Instituicao).OrderBy(c => c.Nome).ToListAsync());
        }



        //	GET:	Departamento/Create
        [HttpGet]
        public IActionResult Create()
        {
            var instituicoes = _context.Instituicoes.OrderBy(i => i.Nome).ToList();

            instituicoes.Insert(0, new Instituicao() { InstituicaoID = 0, Nome = "Seleciona a instituição" });
            ViewBag.Instituicoes = instituicoes;
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]   
        public async Task<IActionResult> Create ([Bind("Nome","InstituicaoID")] Departamento departamento)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(departamento);
                    await _context.SaveChangesAsync();
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
        public async  Task<IActionResult> Edit(long? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }


            var departamento = await _context.Departamentos.SingleOrDefaultAsync(m => m.DepartamentoId == Id);  

            if(departamento == null)
            {
                return NotFound();
            }

            ViewBag.Instituicoes = new SelectList(_context.Instituicoes.OrderBy(b => b.Nome), "InstituicaoID", "Nome", departamento.InstituicaoID);

            return View(departamento);


        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(long? id, [Bind("DepartamentoId,Nome, InstituicaoID")] Departamento departamento)
        {

            if(id != departamento.DepartamentoId)
            {
                return NotFound();

            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamento);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.DepartamentoId))
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

            ViewBag.Instituicoes = new SelectList(_context.Instituicoes.OrderBy(b => b.Nome), "InnstituicaoID", "Nome", departamento.InstituicaoID);
            return View(departamento);

        }

        private bool DepartamentoExists(long? id)
        {
            return _context.Departamentos.Any(e => e.DepartamentoId == id);
        }


        public async Task<IActionResult> Details(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.SingleOrDefaultAsync(m => m.DepartamentoId==id);
            _context.Instituicoes.Where(i => departamento.InstituicaoID == i.InstituicaoID).Load();

            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }



        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.SingleOrDefaultAsync(m => m.DepartamentoId == id);
            _context.Instituicoes.Where(i => departamento.InstituicaoID == i.InstituicaoID).Load();

            if (departamento == null)
            {

                return NotFound();
            }

            return View(departamento);

        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (long? id)
        {
            var departamento = await _context.Departamentos.SingleOrDefaultAsync(m => m.DepartamentoId == id);
            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();
            TempData["Message"] = "Departamento " + departamento.Nome.ToUpper() + " foi removido";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}
