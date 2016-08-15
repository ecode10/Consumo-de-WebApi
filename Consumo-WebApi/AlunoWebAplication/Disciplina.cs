using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlunoWebAplication
{
    public class Disciplina
    {
        [Key]
        public System.Int32 idDisc { get; set; }

        public string descricaoDisc { get; set; }
    }
}