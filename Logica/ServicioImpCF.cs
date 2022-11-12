using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class ServicioImpCF : IServicioCF
    {
        List<Familiar> Familiares;
        Datos.RepositorioFamiliar repositorioFamiliar;
        public ServicioImpCF()
        {
            repositorioFamiliar = new Datos.RepositorioFamiliar();
            Familiares = repositorioFamiliar.ObtenerTodoF();
        }

        public string AgregarF(Familiar ContactoF)
        {
            repositorioFamiliar.Guardar(ContactoF);
            Familiares = repositorioFamiliar.ObtenerTodoF();
            return $"Se ha creado el contacto exitosamente";
  
        }

        public string BorrarF(Familiar ContactoF)
        {
            Familiares.Remove(ContactoF);
            repositorioFamiliar.ActualizarF(Familiares, false);
            return $"Se ha eliminado el contacto exitosamente";
        }

        public string EditarF()
        {
            throw new NotImplementedException();
        }

        public bool ExistenciaF(Familiar ContactoF)
        {
            throw new NotImplementedException();
        }

        public Familiar ObtenerPorTelefonoF(string Telefono)
        {
            foreach (Familiar familiar in Familiares)
            {
                if (familiar.Telefono == Telefono)
                {
                    return familiar;
                }
            }
            return null;
        }

        public List<Familiar> ObtenerTodoF()
        {
            return Familiares;
        }
    }
}
