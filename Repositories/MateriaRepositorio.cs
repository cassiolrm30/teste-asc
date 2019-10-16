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