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
    public class PresentacionFamiliar
    {

        Logica.ServicioImpCF servicioCF = new Logica.ServicioImpCF();
        int Contador = 1;

        public void AgregarFamiliar(int l, int t)
        {
            
            Familiar ContactoF = new Familiar();
            ContactoF.Id = Contador;
            Contador++;

            Console.Clear();
            Console.SetCursorPosition(l, t - 4);
            Console.WriteLine("CONTACTOS FAMILIARES");

            //Validación de nombre ------------------------------------------------------------------------
            while (true)
            {
                Console.SetCursorPosition(l, t - 2);
                Console.WriteLine("Digite el nombre del contacto: ");
                Console.SetCursorPosition(l + 31, t - 2);
                ContactoF.Nombre = Console.ReadLine();

                if (Regex.IsMatch(ContactoF.Nombre, @"^[a-zA-Z]+$"))
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(l, t + 0);
                    Console.WriteLine("El nombre está vacío o contiene letras, ingreselo nuevamente.");
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
                    ContactoF.Telefono = TelefonoAux.ToString();
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

            //int dia, mes, año;
            //Console.SetCursorPosition(l, t + 0);
            //Console.WriteLine("Digite el día de nacimiento: ");
            //do
            //{
            //    Console.SetCursorPosition(l + 29, t + 0);
            //    if (int.TryParse(Console.ReadLine(), out dia))
            //    {

            //        Console.SetCursorPosition(l + 29, t + 0);
            //        dia = int.Parse(Console.ReadLine());    
            //    }
            //    else
            //    {
            //        Console.SetCursorPosition(l + 29, t + 0);
            //        Console.WriteLine("           ");
            //        Console.SetCursorPosition(l, t + 2);
            //        Console.WriteLine("El día ingresado está vacío o incorrecto, ingreselo nuevamente.");
            //        Console.SetCursorPosition(l + 29, t + 0);
            //        Console.WriteLine("           ");
            //    }
            //} while ((dia <= 0) || (dia > 31));
            //Console.SetCursorPosition(l, t + 2);
            //Console.WriteLine("                                                                    ");

            int dia, mes, año;
            Console.SetCursorPosition(l, t + 0);
            Console.WriteLine("Digite el día de nacimiento: ");
            do
            {
                Console.SetCursorPosition(l + 29, t + 0);
                Console.WriteLine("    ");
                Console.SetCursorPosition(l + 29, t + 0);
                dia = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(l, t + 2);
                Console.WriteLine("Día incorrecto, ingreselo nuevamente.");
            } while ((dia <= 0) || (dia > 31));
            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("                                            ");


            Console.SetCursorPosition(l, t + 1);
            Console.WriteLine("Digite el mes de nacimiento: ");
            do
            {
                Console.SetCursorPosition(l + 29, t + 1);
                Console.WriteLine("    ");
                Console.SetCursorPosition(l + 29, t + 1);
                mes = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(l, t + 3);
                Console.WriteLine("Mes incorrecto, ingreselo nuevamente.");
            } while ((mes <= 0) || (mes > 12));
            Console.SetCursorPosition(l, t + 3);
            Console.WriteLine("                                            ");

            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("Digite el año de nacimiento: ");
            do
            {
                Console.SetCursorPosition(l + 29, t + 2);
                Console.WriteLine("    ");
                Console.SetCursorPosition(l + 29, t + 2);
                año = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(l, t + 4);
                Console.WriteLine("Año incorrecto, ingreselo nuevamente.");
            } while (año <= 0);
            Console.SetCursorPosition(l, t + 4);
            Console.WriteLine("                                            ");

            ContactoF.FechaNacimiento = new DateTime(año, mes, dia);

            Console.SetCursorPosition(l, t + 5);
            Console.WriteLine(servicioCF.AgregarF(ContactoF));




            Console.SetCursorPosition(l, t + 12);
            Console.ReadKey();

        }

        public void MostrarFamiliar(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 4);
            Console.WriteLine("CONTACTOS FAMILIARES");
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l + 8, t - 2);
            Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(l + 20, t - 2);
            Console.WriteLine("TELÉFONO");
            Console.SetCursorPosition(l + 34, t - 2);
            Console.WriteLine("FECHA DE NACIMIENTO");
            foreach (var ContactoF in servicioCF.ObtenerTodoF())
            {
                Console.SetCursorPosition(l, t + 0);
                Console.WriteLine(ContactoF.Id);
                Console.SetCursorPosition(l + 8, t + 0);
                Console.WriteLine(ContactoF.Nombre);
                Console.SetCursorPosition(l + 20, t + 0);
                Console.WriteLine(ContactoF.Telefono + "\t");
                Console.SetCursorPosition(l + 34, t + 0);
                Console.WriteLine(ContactoF.FechaNacimiento.ToString("dd-MM-yyyy"));
                t++;
            }
            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();
        }

        public void BorrarFamiliar(int l, int t)
        {
            
            Console.Clear();
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Ingrese el número de telefono del contacto a borrar: ");
            Console.SetCursorPosition(l + 53, t - 2);
            String Telefono = Console.ReadLine();

            foreach (var ContactoF  in servicioCF.ObtenerTodoF())
            {
                if(ContactoF.Telefono == Telefono)
                {
                    Console.SetCursorPosition(l, t + 0);
                    Console.WriteLine("ID");
                    Console.SetCursorPosition(l + 8, t + 0);
                    Console.WriteLine("NOMBRE");
                    Console.SetCursorPosition(l + 20, t + 0);
                    Console.WriteLine("TELÉFONO");
                    Console.SetCursorPosition(l + 34, t + 0);
                    Console.WriteLine("FECHA DE NACIMIENTO");

                    Console.SetCursorPosition(l, t + 1);
                    Console.WriteLine(ContactoF.Id);
                    Console.SetCursorPosition(l + 8, t + 1);
                    Console.WriteLine(ContactoF.Nombre);
                    Console.SetCursorPosition(l + 20, t + 1);
                    Console.WriteLine(ContactoF.Telefono + "\t");
                    Console.SetCursorPosition(l + 34, t + 1);
                    Console.WriteLine(ContactoF.FechaNacimiento.ToString("dd-MM-yyyy"));

                    bool continuar = true;
                    char opcion;
                    while (continuar)
                    {
                        Console.SetCursorPosition(l, t + 3);
                        Console.WriteLine("Desea eliminar este contacto? - [S/N] - : ");
                        Console.SetCursorPosition(l + 42, t + 3);
                        opcion = Console.ReadKey().KeyChar;
                        opcion = Char.ToUpper(opcion);
                        if (opcion == 'S')
                        {
                            continuar = true;
                            servicioCF.BorrarF(ContactoF);
                            Console.SetCursorPosition(l, t + 5);
                            Console.WriteLine("Contacto eliminado correctamente");
                            break;
                        }
                        else if (opcion == 'N')
                        {
                            continuar = false;
                            Console.SetCursorPosition(l, t + 4);
                            Console.WriteLine("Presione una tecla para regresar al menú anterior.");
                            break;
                        }
                        else
                        {
                            Console.SetCursorPosition(l, t + 4);
                            Console.WriteLine("La opción ingresada no es válida");
                            Console.SetCursorPosition(l + 42, t + 3);
                            Console.WriteLine("          ");
                        }

                    }

                    break;
                }
            }

            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();

        }

        public void BuscarPorTelefonoFamiliar(int l, int t)
        {
            Console.Clear();
            Console.SetCursorPosition(l, t - 2);
            Console.WriteLine("Ingrese el número de telefono del contacto a borrar: ");
            Console.SetCursorPosition(l + 53, t - 2);
            String Telefono = Console.ReadLine();

            Console.SetCursorPosition(l, t + 0);
            Console.WriteLine("CONTACTOS FAMILIARES");
            Console.SetCursorPosition(l, t + 2);
            Console.WriteLine("ID");
            Console.SetCursorPosition(l + 8, t + 2);
            Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(l + 20, t + 2);
            Console.WriteLine("TELÉFONO");
            Console.SetCursorPosition(l + 34, t + 2);
            Console.WriteLine("FECHA DE NACIMIENTO");

            foreach (var ContactoF in servicioCF.ObtenerTodoF())
            {
                if (ContactoF.Telefono == Telefono)
                {
                    Console.SetCursorPosition(l, t + 3);
                    Console.WriteLine(ContactoF.Id);
                    Console.SetCursorPosition(l + 8, t + 3);
                    Console.WriteLine(ContactoF.Nombre);
                    Console.SetCursorPosition(l + 20, t + 3);
                    Console.WriteLine(ContactoF.Telefono + "\t");
                    Console.SetCursorPosition(l + 34, t + 3);
                    Console.WriteLine(ContactoF.FechaNacimiento.ToString("dd-MM-yyyy"));
                    break;
                }
                else
                {
                    Console.SetCursorPosition(l, t + 0);
                    Console.WriteLine("El contacto no se encuentra en su agenda.");
                    Console.SetCursorPosition(l, t + 2);
                    Console.WriteLine("                                                        ");
                }
            }

            Console.SetCursorPosition(l, t + 10);
            Console.ReadKey();

        }

    }
}
