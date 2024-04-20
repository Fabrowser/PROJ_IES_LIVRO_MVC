using Microsoft.AspNetCore.Mvc;
using Modelo.Docente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC.Data.DAL.Docente
{
    public class ProfessorDAL
    {

        private IESContext _context;

        public ProfessorDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Professor> ObterProfessoresClassificadosPorNome()
        {
            return _context.Professores.OrderBy(b => b.Nome);
        }


        public async Task<Professor> ObterProfessorPorId(long id)
        {

            return await _context.Professores.FindAsync(id);
        }

        public async Task<Professor> GravarProfessor(Professor professor)
        {
            if (professor.ProfessorID == null)
            {
                _context.Professores.Add(professor);

            }
            else
            {
                _context.Professores.Update(professor);
            }

            await _context.SaveChangesAsync();
            return professor;
        }

        public async Task<Professor> EliminarProfessorPorId(long id)
        {

            Professor professor = await ObterProfessorPorId(id);
            _context.Professores.Remove(professor);
            await _context.SaveChangesAsync();
            return professor;

        }

        internal Task<IActionResult> ObterProfessorPorId(long? id)
        {
            throw new NotImplementedException();
        }




    }
}
