using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace simulador_periodos_academicos.Models
{
    [Table("prova")]
    public class Prova
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("peso")]
        public decimal Peso { get; set; }

        [Column("id_materia")]
        public int MateriaId { get; set; }
        public virtual Materia Materia { get; set; }

        public List<Avaliacao> Avaliacoes { get; set; }
    }
}