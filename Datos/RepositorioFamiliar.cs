using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioFamiliar : Archivos
    {
        public RepositorioFamiliar() : base()
        {
            ruta = "Contactos_Familiares.txt";
        }

        public List<Familiar> ObtenerTodoF()
        {
            StreamReader srF = new StreamReader(ruta);
            List<Entidades.Familiar> familiares = new List<Familiar>();

            while(!srF.EndOfStream)
            {
                familiares.Add(MappearF(srF.ReadLine()));
            }
            srF.Close();    
            return familiares;
        }

        Entidades.Familiar MappearF(String LineaDatosF)
        {
            Entidades.Familiar ContactoF = new Entidades.Familiar();

            ContactoF.Id = int.Parse(LineaDatosF.Split(';')[0]);
            ContactoF.Nombre = (LineaDatosF.Split(';')[1]);
            ContactoF.Telefono = (LineaDatosF.Split(';')[2]);
            ContactoF.FechaNacimiento = Convert.ToDateTime(LineaDatosF.Split(';')[3]);
            return ContactoF;
        }

        public String ActualizarF(List<Familiar> Familiares, bool modo)
        {
            StreamWriter srF = new StreamWriter(ruta, modo);
            foreach (Familiar Familiar in Familiares)
            {
                srF.WriteLine(Familiar.ToString());
            }
            srF.Close();

            return $"Lista actualizada"; ;
        }




    }
}