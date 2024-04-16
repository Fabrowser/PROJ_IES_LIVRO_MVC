using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC.Data.DAL.Cadastros
{
    public class CursoDAL
    {

        private IESContext _context;

        public CursoDAL(IESContext context)
        {
            _context = context;
        }



    }
}
