﻿using Microsoft.EntityFrameworkCore;
using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC.Data.DAL.Cadastros
{
    public class DepartamentoDAL
    {


        private IESContext _context;

        public DepartamentoDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Departamento> ObterDepartamentosClassificadosPorNome()
        {
            return _context.Departamentos.Include(i=> i.Instituicao).OrderBy(b=>b.Nome);
        }

        public async Task<Departamento> ObterDepartamentoPorId(long id)
        {
            var departamento = await _context.Departamentos.SingleOrDefaultAsync(m => m.DepartamentoID == id);
            _context.Instituicoes.Where(i => departamento.InstituicaoID == i.InstituicaoID).Load();
            return departamento;

        }

        public async Task<Departamento> GravarDepartamento(Departamento departamento)
        {
            if (departamento.DepartamentoID == null)
            {
                _context.Departamentos.Add(departamento);

            }
            else
            {
                _context.Departamentos.Update(departamento);
            }

            await _context.SaveChangesAsync();
            return departamento;
        }


        public async Task<Departamento> EliminarDepartamentoPorId(long id)
        {
            Departamento departamento = await ObterDepartamentoPorId(id);
            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();
            return departamento;
        }

        public IQueryable<Departamento> ObterDepartamentosPorInstituicao(long instituicaoID)
        {
            var departamentos = _context.Departamentos.Where(d => d.InstituicaoID == instituicaoID).OrderBy(d => d.Nome);
            return departamentos;
        }


    }
}
