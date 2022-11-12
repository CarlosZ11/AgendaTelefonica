using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IServicioCF
    {
        String AgregarF(Familiar ContactoF);

        List<Familiar> ObtenerTodoF();

        String EditarF();

        String BorrarF(Familiar ContactoF);

        bool ExistenciaF(Familiar ContactoF);

    }
}