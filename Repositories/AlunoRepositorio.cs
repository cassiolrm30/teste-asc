using simulador_periodos_academicos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace simulador_periodos_academicos.Repositories
{
    public class AlunoRepositorio
    {
        public readonly Contexto _contexto;

        public AlunoRepositorio(Contexto contexto)
        {
            //_contexto = contexto;
            //Turma turma = new Turma(); turma.Id = 1; turma.Codigo = 101; turma.Ano = DateTime.Today.Year; turma.Periodo = (DateTime.Today.Month <= 6 ? 1 : 2);
            //Aluno aluno1 = new Aluno(); aluno1.Id = 1; aluno1.Nome = "ALUNO 1"; aluno1.Turma = turma; _contexto.Alunos.Add(aluno1);
            //Aluno aluno2 = new Aluno(); aluno2.Id = 2; aluno2.Nome = "ALUNO 2"; aluno2.Turma = turma; _contexto.Alunos.Add(aluno2);
            //_contexto.SaveChanges();
        }

        public IList<Aluno> GetAll()
        {
            IList<Aluno> resultado = _contexto.Alunos.ToList();
            return resultado;
        }

        public Aluno Get(int id)
        {
            Aluno resultado = _contexto.Alunos.FirstOrDefault(x => x.Id == id);
            return resultado;
        }
        public bool Save(int id, string nome, ref string mensagemErro)
        {
            bool resultado = true;
            try
            {
                Aluno aluno = new Aluno();
                aluno.Id = id;
                aluno.Nome = nome;
                if (id == 0)
                    _contexto.Alunos.Add(aluno);
                else
                    _contexto.Entry(aluno).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                resultado = false;
            }
            return resultado;
        }

        public bool Delete(int id, ref string mensagemErro)
        {
            bool resultado = true;
            try
            {
                Aluno aluno = _contexto.Alunos.FirstOrDefault(x => x.Id == id);
                var employer = new Aluno { Id = id };
                _contexto.Entry(employer).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                mensagemErro = ex.Message;
                resultado = false;
            }
            return resultado;
        }
    }
}