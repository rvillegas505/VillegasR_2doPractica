using System;
using System.Collections.Generic;
using System.Linq;
using VillegasR_2doPractica.Models;

namespace VillegasR_2doPractica.Repositorios
{
    public class ObraDeArteRepositorio : IObraDeArteRepositorio
    {

        PracticaParcialArteContext _contexto;

        public ObraDeArteRepositorio(PracticaParcialArteContext contexto)
        {
            _contexto = contexto;
        }
        public void Agregar(ObraDeArte obra)
        {
            _contexto.Add(obra);
            _contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            ObraDeArte obraAEliminar = ObtenerPorId(id);

            _contexto.Remove(obraAEliminar);
            _contexto.SaveChanges();
        }

        public void Modificar(ObraDeArte obra)
        {
            ObraDeArte obraAModificar = ObtenerPorId(obra.Id);
            if (obraAModificar == null)
            {
                throw new ArgumentException("No se puede modificar la obra, ya que no se encuentra disponible o no existe.");
            }

            obraAModificar.Nombre = obra.Nombre;
            obraAModificar.AnioCreacion = obra.AnioCreacion;

            _contexto.SaveChanges();

        }

        public ObraDeArte ObtenerPorId(int id)
        {
            ObraDeArte obraABuscar = _contexto.ObraDeArtes.Find(id);
            if (obraABuscar == null)
            {
                throw new ArgumentException("No se puede obtener la obra, ya que no se encuentra disponible o no existe.");
            }
            return obraABuscar;
        }

        public List<ObraDeArte> ObtenerSigloxix()
        {
            return _contexto.ObraDeArtes.Where(p=> p.AnioCreacion >= 1800 && p.AnioCreacion <= 1899).OrderByDescending(o => o.AnioCreacion).ToList();
        }

        public List<ObraDeArte> ObtenerTodas()
        {
            return _contexto.ObraDeArtes.ToList();
        }
    }
}
