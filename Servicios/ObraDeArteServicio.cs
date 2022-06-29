using System.Collections.Generic;
using VillegasR_2doPractica.Models;
using VillegasR_2doPractica.Repositorios;

namespace VillegasR_2doPractica.Servicios
{
    public class ObraDeArteServicio : IObraDeArteServicio
    {
        IObraDeArteRepositorio _obraDeArteRepositorio;

        public ObraDeArteServicio (IObraDeArteRepositorio obraDeArteRepositorio)
        {
            _obraDeArteRepositorio = obraDeArteRepositorio;
        }
        public void Agregar(ObraDeArte obra)
        {
            _obraDeArteRepositorio.Agregar(obra);
        }

        public void Eliminar(int id)
        {
            _obraDeArteRepositorio.Eliminar(id);
        }

        public void Modificar(ObraDeArte obra)
        {
            _obraDeArteRepositorio.Modificar(obra);
        }

        public ObraDeArte ObtenerPorId(int id)
        {
            return _obraDeArteRepositorio.ObtenerPorId(id);
        }

        public List<ObraDeArte> ObtenerSigloxix()
        {
            return _obraDeArteRepositorio.ObtenerSigloxix();
        }

        public List<ObraDeArte> ObtenerTodas()
        {
           return _obraDeArteRepositorio.ObtenerTodas();
        }
    }
}
