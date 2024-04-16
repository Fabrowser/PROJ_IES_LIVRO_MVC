using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capitulo01_MVC.Data.DAL.Docente;
using Capitulo01_MVC.Data.DAL.Cadastros;
using Capitulo01_MVC.Data;

namespace Capitulo01_MVC.Areas.Docente.Controllers
{
    [Area("Docente")]
    public class ProfessorController : Controller
    {
        private readonly IESContext _context;
        private readonly DepartamentoDAL departamentoDAL;
        private readonly InstituicaoDAL instituicaoDAL;
        private readonly CursoDAL cursoDAL;
        private readonly ProfessorDAL professorDAL;

        public ProfessorController(IESContext context)
        {
            _context = context;
            instituicaoDAL = new InstituicaoDAL(context);
            departamentoDAL = new DepartamentoDAL(context);
            cursoDAL = new CursoDAL(context);
            professorDAL = new ProfessorDAL(context);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
