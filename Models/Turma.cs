using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("turma")]
    public class Turma
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("codigo")]
        public int Codigo { get; set; }
        [Column("qtd_alunos")]
        public int QtdAlunos { get; set; }
        public List<AlunoMateria> Matriculas { get; set; }
    }
}