using Capitulo01_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelo.Cadastros;
using Capitulo01_MVC.Data.DAL.Cadastros;
using Modelo.Discente;
using Capitulo01_MVC.Models.Infra;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Capitulo01_MVC.Data
{

    public class IESContext : IdentityDbContext<UsuarioDaAplicacao>
    {

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Academico> Academicos
        {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CursoDisciplina>()
            .HasKey(cd => new { cd.CursoID, cd.DisciplinaID });

            modelBuilder.Entity<CursoDisciplina>()
                .HasOne(c => c.Curso)
                .WithMany(cd => cd.CursosDisciplinas)
                .HasForeignKey(d => d.DisciplinaID);


            modelBuilder.Entity<CursoDisciplina>()
                .HasOne(c => c.Disciplina)
                .WithMany(cd => cd.CursosDisciplinas)
                .HasForeignKey(d => d.DisciplinaID);
        }


        //Abaixo Uma Sobrescrita caso a tabela ja exista na base de dados com nome diferente. 

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Departamento>().ToTable("Departamento");
         }*/



        //Abaixo Se quisermos acesso a dados diretamente na classe de contexto, porem, o mais adequado é incluir a Injeção de dependência na classe STARTUP

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database = IESCasaDoCodigo; Trusted_Connection = True; MultipleActiveResultSets = true");
        }*/



    }
}
