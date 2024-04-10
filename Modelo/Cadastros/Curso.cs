using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    public class Curso
    {
        public long? CursoID { get; set; }
        public string Nome { get; set; }

        public long? DepartamentoID { get; set; }
        public Departamento Deprtamento { get; set; }


        public virtual ICollection<CursoDisciplina> CursosDisciplinas{get;set;}

}
}
