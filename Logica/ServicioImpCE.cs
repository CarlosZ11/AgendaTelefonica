using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ServicioImpCE : IServicioCE
    {
        List<Empresarial> Empresarios;
        Datos.RepositorioEmpresarial repositorioEmpresarial;
        public ServicioImpCE()
        {
            repositorioEmpresarial = new Datos.RepositorioEmpresarial();
            Empresarios = repositorioEmpresarial.ObtenerTodoE();
        }


        public string AgregarE(Empresarial ContactoE)
        {
            repositorioEmpresarial.Guardar(ContactoE);
            Empresarios = repositorioEmpresarial.ObtenerTodoE();
            return $"Se ha creado el contacto exitosamente";
        }

        public string BorrarE(Empresarial ContactoE)
        {
            Empresarios.Remove(ContactoE);
            repositorioEmpresarial.ActualizarE(Empresarios, false);
            return $"Se ha eliminado el contacto exitosamente";
        }

        public string EditarE()
        {
            throw new NotImplementedException();
        }

        public bool ExistenciaE(Empresarial ContactoE)
        {
            throw new NotImplementedException();
        }

        public Empresarial ObtenerPorTelefonoE(string Telefono)
        {
            foreach (Empresarial empresarial in Empresarios)
            {
                if (empresarial.Telefono == Telefono)
                {
                    return empresarial;
                }
            }
            return null;
        }

        public List<Empresarial> ObtenerTodoE()
        {
            return Empresarios;
        }

    }
}