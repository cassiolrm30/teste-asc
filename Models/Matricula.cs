using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("alunomateria")]
    public class Matricula
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_aluno")]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }

        [Column("id_materia")]
        public int MateriaId { get; set; }
        public virtual Materia Materia { get; set; }
    }
}