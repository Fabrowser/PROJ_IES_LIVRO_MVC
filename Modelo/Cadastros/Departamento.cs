﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo.Cadastros
{
    public class Departamento
    {

        public long? DepartamentoId { get; set; }
        public string Nome { get; set; }

        public long? InstituicaoID { get;set;}
        public Instituicao Instituicao { get; set; }

    }
}
