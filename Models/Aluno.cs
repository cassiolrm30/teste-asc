using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("aluno")]
    public class Aluno
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("media_final")]
        public decimal MediaFinal { get; set; }

        [Column("situacao")]
        public bool Aprovado { get; set; }

        public Turma Turma { get; set; }
        public List<Matricula> Matriculas { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}