using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("materia")]
    public class Materia
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        public List<Matricula> Matriculas { get; set; }
        public List<Prova> Provas { get; set; }
    }
}