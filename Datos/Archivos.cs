using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Contracts;

namespace Datos
{
    public class Archivos
    {
        protected string ruta;

        public Archivos()
        {
            ruta = "Contactos.txt";
        }

        public Archivos(String fileName)
        {
            ruta = fileName;
        }

        public String Guardar(Entidades.Persona Contacto)
        {
            StreamWriter swF = new StreamWriter(ruta, true);
            //sw.WriteLine(Contacto.ToString());
            swF.WriteLine(Contacto);
            swF.Close();
            return $"Contacto familiar almacenado correctamente con el nombre: {Contacto.Nombre}";
        }

    }
}
