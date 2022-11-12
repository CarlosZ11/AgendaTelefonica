using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Datos
{
    public class RepositorioEmpresarial : Archivos
    {
        public RepositorioEmpresarial() : base()
        {
            ruta = "Contactos_Empresariales.txt";
        }




        public List<Empresarial> ObtenerTodoE()
        {
            StreamReader srE = new StreamReader(ruta);
            List<Entidades.Empresarial> empresarios = new List<Empresarial>();

            while(!srE.EndOfStream)
            {
                empresarios.Add(MappearE(srE.ReadLine()));
            }
            srE.Close();
            return empresarios;
        }

        Entidades.Empresarial MappearE(String LineaDatosE)
        {
            Entidades.Empresarial ContactoE = new Entidades.Empresarial();

            ContactoE.Id = int.Parse(LineaDatosE.Split(';')[0]);
            ContactoE.Nombre = (LineaDatosE.Split(';')[1]);
            ContactoE.Telefono = (LineaDatosE.Split(';')[2]);
            ContactoE.Nit = (LineaDatosE.Split(';')[3]);
            ContactoE.RazonSocial = (LineaDatosE.Split(';')[4]);
            ContactoE.Correo = (LineaDatosE.Split(';')[5]);
            return ContactoE;
        }

        public String ActualizarE(List<Empresarial> Empresarios, bool modo)
        {
            StreamWriter srE = new StreamWriter(ruta, modo);
            foreach (Empresarial Empresarial in Empresarios)
            {
                srE.WriteLine(Empresarial.ToString());
            }
            srE.Close();

            return $"Lista actualizada"; ;
        }
    }
}