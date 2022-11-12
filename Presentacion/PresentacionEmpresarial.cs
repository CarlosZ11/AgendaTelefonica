using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionEmpresarial
    {
        
        Logica.ServicioImpCE servicioCE = new Logica.ServicioImpCE();
        int Contador = 1;
        public void AgregarEmpresarial(int l, int t)
        {
            Empresarial ContactoE = new Empresarial();
            ContactoE.Id = Contador;
            Contador++;

            Console.Clear();
            Console.SetCursorPosition(l, t - 4);
            Console.WriteLine("CONTACTOS EMPRESARIALES");

            //Validación de nombre ------------------------------------------------------------------------
            while (true)
            {
                Console.SetCursorPosition(l, t - 2);
                Console.WriteLine("Digite el nombre del contacto: ");
                Console.SetCursorPosition(l + 31, t - 2);
                ContactoE.Nombre = Console.ReadLine();

                if (Regex.IsMatch(ContactoE.Nombre, @"^[a-zA-Z]+$"))
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(l, t + 0);
                    Console.WriteLine("El nombre solo puede contener letras, ingreselo nuevamente.");
                    Console.SetCursorPosition(l + 31, t - 2);
                    Console.WriteLine("                    ");
                }
            }
            Console.SetCursorPosition(l, t + 0);
            Console.WriteLine("                                                           ");
            //--------------------------------------------------------------------------------------------

            //Validación de telefono ---------------------------------------------------------------------
            String TelefonoAux;
            bool validacion = true;

            while (validacion)
            {
                Console.SetCursorPosition(l, t - 1);
                Console.WriteLine("Digite el telefono del contacto: ");
                Console.SetCursorPosition(l + 33, t - 1);
                TelefonoAux = Console.ReadLine();

                bool resultado = uint.TryParse(TelefonoAux, out uint num);

                if (resultado)
                {
                    validacion = false;
                    ContactoE.Telefono = TelefonoAux.ToString();
                }
                else
                {
                    Console.SetCursorPosition(l, t + 2);
                    Console.WriteLine("El número ingresado es incorrecto, ingreselo nuevamente");
                    Console.SetCursorPosition(l + 33, t - 1);
                    Console.WriteLine("                       ");
                }
            }
            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("                                                                    ");
            //---------------------------------------------------------------------------------------------

            Console.SetCursorPosition(l, t + 0);
            Console.WriteLine("Digite el nit del contacto: ");
            Console.SetCursorPosition(l + 28, t + 0);
            ContactoE.Nit = Console.ReadLine();

            Console.SetCursorPosition(l, t + 1);
            Console.WriteLine("Digite la razon social del contacto: ");
            Console.SetCursorPosition(l + 37, t + 1);
            ContactoE.RazonSocial = Console.ReadLine();

            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("Digite el correo del contacto: ");
            Console.SetCursorPosition(l + 31, t + 2);
            ContactoE.Correo = Console.ReadLine();

            Console.SetCursorPosition(l, t + 5);
            Console.WriteLine(servicioCE.AgregarE(ContactoE));

            Console.SetCursorPosition(l, t + 7);
            Console.ReadKey();

        }

        public void MostrarEmpresarial(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 4);
            Console.WriteLine("CONTACTOS EMPRESARIALES");
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l + 6, t - 2);
            Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(l + 17, t - 2);
            Console.WriteLine("TELEFONO");
            Console.SetCursorPosition(l + 31, t - 2);
            Console.WriteLine("NIT");
            Console.SetCursorPosition(l + 45, t - 2);
            Console.WriteLine("RAZÓN SOCIAL");
            Console.SetCursorPosition(l + 61, t - 2);
            Console.WriteLine("CORREO");
            foreach (var ContactoE in servicioCE.ObtenerTodoE())
            {
                Console.SetCursorPosition(l, t + 1);
                Console.WriteLine(ContactoE.Id);
                Console.SetCursorPosition(l + 6, t + 1);
                Console.WriteLine(ContactoE.Nombre);
                Console.SetCursorPosition(l + 17, t + 1);
                Console.WriteLine(ContactoE.Telefono);
                Console.SetCursorPosition(l + 31, t + 1);
                Console.WriteLine(ContactoE.Nit);
                Console.SetCursorPosition(l + 45, t + 1);
                Console.WriteLine(ContactoE.RazonSocial);
                Console.SetCursorPosition(l + 61, t + 1);
                Console.WriteLine(ContactoE.Correo);
                t++;
            }
            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();
        }

        public void BorrarEmpresarial(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Ingrese el número de telefono del contacto a borrar: ");
            Console.SetCursorPosition(l + 53, t - 2);
            String Telefono = Console.ReadLine();

            foreach (var ContactoE in servicioCE.ObtenerTodoE())
            {
                if (ContactoE.Telefono == Telefono)
                {
                    servicioCE.BorrarE(ContactoE);
                    Console.SetCursorPosition(l, t + 1);
                    Console.WriteLine("Contacto eliminado correctamente");
                    break;
                }
            }
            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();

        }

        public void BuscarPorTelefonoEmpresarial(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Ingrese el número de telefono del contacto a borrar: ");
            Console.SetCursorPosition(l + 53, t - 2);
            String Telefono = Console.ReadLine();

            Console.SetCursorPosition(l, t + 0);
            Console.WriteLine("CONTACTOS EMPRESARIALES");
            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l + 6, t + 2);
            Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(l + 17, t + 2);
            Console.WriteLine("TELEFONO");
            Console.SetCursorPosition(l + 31, t + 2);
            Console.WriteLine("NIT");
            Console.SetCursorPosition(l + 45, t + 2);
            Console.WriteLine("RAZÓN SOCIAL");
            Console.SetCursorPosition(l + 61, t + 2);
            Console.WriteLine("CORREO");

            foreach (var ContactoE in servicioCE.ObtenerTodoE())
            {
                if (ContactoE.Telefono == Telefono)
                {
                    Console.SetCursorPosition(l, t + 3);
                    Console.WriteLine(ContactoE.Id);
                    Console.SetCursorPosition(l + 6, t + 3);
                    Console.WriteLine(ContactoE.Nombre);
                    Console.SetCursorPosition(l + 17, t + 3);
                    Console.WriteLine(ContactoE.Telefono + "\t");
                    Console.SetCursorPosition(l + 31, t + 3);
                    Console.WriteLine(ContactoE.Nit);
                    Console.SetCursorPosition(l + 45, t + 3);
                    Console.WriteLine(ContactoE.RazonSocial);
                    Console.SetCursorPosition(l + 61, t + 3);
                    Console.WriteLine(ContactoE.Correo);
                    break;
                }
                else
                {
                    Console.SetCursorPosition(l, t + 0);
                    Console.WriteLine("El contacto no se encuentra en su agenda.");
                    Console.SetCursorPosition(l, t + 2);
                    Console.WriteLine("                                                                       ");
                }
            }

            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();

        }

    }
}
