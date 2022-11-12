using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IServicioCE
    {
        String AgregarE(Empresarial ContactoE);

        List<Empresarial> ObtenerTodoE();

        String EditarE();

        String BorrarE(Empresarial ContactoE);

        Empresarial ObtenerPorTelefonoE(String Telefono);

        bool ExistenciaE(Empresarial ContactoE);
    }
}