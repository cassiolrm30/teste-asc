using simulador_periodos_academicos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace simulador_periodos_academicos.Repositories
{
    public class MateriaRepositorio
    {
        public readonly Contexto _contexto;

        public MateriaRepositorio(Contexto contexto)
        {
            _contexto = contexto;
            //Materia materia1 = new Materia(); materia1.Id = 1; materia1.Nome = "MATÉRIA 1"; materia1.Provas = new List<Prova>();
            //Prova prova1 = new Prova(); Prova prova2 = new Prova(); Prova prova3 = new Prova();
            //prova1 = new Prova(); prova1.Id = 1; prova1.Peso = 1M; prova1.MateriaId = materia1.Id; prova1.Materia = materia1; materia1.Provas.Add(prova1);
            //prova2 = new Prova(); prova2.Id = 2; prova2.Peso = 1.5M; prova2.MateriaId = materia1.Id; prova2.Materia = materia1; materia1.Provas.Add(prova2);
            //prova3 = new Prova(); prova3.Id = 3; prova3.Peso = 2M; prova3.MateriaId = materia1.Id; prova3.Materia = materia1; materia1.Provas.Add(prova3);
            //_contexto.Materias.Add(materia1); _contexto.Provas.Add(prova1); _contexto.Provas.Add(prova2); _contexto.Provas.Add(prova3);
            //materia1 = new Materia(); materia1.Id = 2; materia1.Nome = "MATÉRIA 2"; materia1.Provas = new List<Prova>();
            //prova1 = new Prova(); prova1.Id = 1; prova1.Peso = 1M; prova1.MateriaId = materia1.Id; prova1.Materia = materia1; materia1.Provas.Add(prova1);
            //prova2 = new Prova(); prova2.Id = 2; prova2.Peso = 1.5M; prova2.MateriaId = materia1.Id; prova2.Materia = materia1; materia1.Provas.Add(prova2);
            //prova3 = new Prova(); prova3.Id = 3; prova3.Peso = 2M; prova3.MateriaId = materia1.Id; prova3.Materia = materia1; materia1.Provas.Add(prova3);
            //_contexto.Materias.Add(materia1); _contexto.Provas.Add(prova1); _contexto.Provas.Add(prova2); _contexto.Provas.Add(prova3);
            //_contexto.SaveChanges();
        }

        public IList<Materia> GetAll()
        {
            IList<Materia> resultado = _contexto.Materias.ToList();
            return resultado;
        }

        public Materia Get(int id)
        {
            Materia resultado = _contexto.Materias.FirstOrDefault(x => x.Id == id);
            return resultado;
        }
        public bool Save(int id, string nome, ref string mensagemErro)
        {
            bool resultado = true;
            try
            {
                Materia materia = new Materia();
                materia.Id = id;
                materia.Nome = nome;
                if (id == 0)
                    _contexto.Materias.Add(materia);
                else
                    _contexto.Entry(materia).State = EntityState.Deleted;
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
                Materia materia = _contexto.Materias.FirstOrDefault(x => x.Id == id);
                var employer = new Materia { Id = id };
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