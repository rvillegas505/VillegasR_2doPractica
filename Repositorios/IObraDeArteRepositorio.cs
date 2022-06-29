using System.Collections.Generic;
using VillegasR_2doPractica.Models;

namespace VillegasR_2doPractica.Repositorios
{
    public interface IObraDeArteRepositorio
    {
        public void Agregar(ObraDeArte obra);
        public List<ObraDeArte> ObtenerTodas();

        public List<ObraDeArte> ObtenerSigloxix();

        public ObraDeArte ObtenerPorId(int id);

        public void Eliminar(int id);

        public void Modificar(ObraDeArte obra);
    }
}
