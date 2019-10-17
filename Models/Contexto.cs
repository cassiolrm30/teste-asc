using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace simulador_periodos_academicos.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Prova> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}