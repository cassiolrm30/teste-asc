using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace simulador_periodos_academicos.Models
{
    public class Contexto : DbContext
    {
        //public Contexto() : base("conexao") { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Evitar a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}