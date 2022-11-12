using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Entidades.Familiar ContactoF = new Entidades.Familiar();
            //Logica.ServicioImpCF servicioCF = new Logica.ServicioImpCF();

            //ContactoF.Id = 3;
            //ContactoF.Nombre = "Carlos";
            //ContactoF.Telefono = "3182945266";
            //ContactoF.FechaNacimiento = new DateTime(1999, 10, 11);


            //Datos.RepositorioFamiliar repositorioFamiliar = new Datos.RepositorioFamiliar();
            //var contacto = servicioCF.ObtenerPorTelefonoF("3006331473");
            //servicioCF.BorrarF(contacto);



            //Console.WriteLine(repositorioFamiliar.GuardarF(ContactoF));

            //Console.WriteLine("Id -- Nombre -- Telefono -- Fecha de Nacimiento");

            //foreach (var item in repositorioFamiliar.ObtenerTodoF())
            //{
            //    Console.WriteLine($"{item.Id} -- {item.Nombre} -- {item.Telefono} -- {item.FechaNacimiento.ToShortDateString()}");
            //}


            //Entidades.Empresarial ContactoE = new Entidades.Empresarial();

            //ContactoE.Id = 2;
            //ContactoE.Nombre = "Sara";
            //ContactoE.Telefono = "3174979143";
            //ContactoE.Nit = "1003383785";
            //ContactoE.RazonSocial = "CocaCola";
            //ContactoE.Correo = "Sara@gmail.com";


            //Datos.RepositorioEmpresarial repositorioEmpresarial = new Datos.RepositorioEmpresarial();
            //Console.WriteLine(repositorioEmpresarial.GuardarE(ContactoE));

            //Console.WriteLine("Id -- Nombre -- Telefono -- Nit -- Razon Social -- Correo");

            //foreach (var item in repositorioEmpresarial.ObtenerTodoE())
            //{
            //    Console.WriteLine($"{item.Id} -- {item.Nombre} -- {item.Telefono} -- {item.Nit} -- {item.RazonSocial} -- {item.Correo}");
            //}


            Console.ReadKey();

        }
    }
}
