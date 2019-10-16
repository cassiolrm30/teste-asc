using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("alunoprova")]
    public class AlunoProva
    {
        public int Id { get; set; }

        [Column("id_aluno")]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Column("id_prova")]
        public int ProvaId { get; set; }
        public virtual Prova Prova { get; set; }

        [Column("nota")]
        public decimal Nota { get; set; }
    }
}