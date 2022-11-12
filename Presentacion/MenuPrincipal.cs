using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        PresentacionFamiliar presentacionFamiliar = new PresentacionFamiliar();
        PresentacionEmpresarial presentacionEmpresarial = new PresentacionEmpresarial();
        public void VerPrincipal(int l, int t)
        {
             

            int op;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();

                Console.SetCursorPosition(l + 65, t + 22);
                Console.WriteLine("ING. CARLOS ZAMBRANO PADILLA");

                Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU PRINCIPAL DE AGENDA TELEFÓNICA");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. AGREGAR CONTACTO");
                Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. VER LISTA DE CONTACTOS");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. BUSCAR CONTACTO");
                Console.SetCursorPosition(l, t + 5); Console.WriteLine("4. MOFICICAR CONTACTO");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("5. ELIMINAR CONTACTO");
                Console.SetCursorPosition(l, t + 7); Console.WriteLine("6. SALIR");
                Console.SetCursorPosition(l, t + 9); Console.WriteLine("Digite una opcion: ");
                Console.SetCursorPosition(l + 19, t + 9); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int opc;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE CONTACTOS");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. AGREGAR CONTACTO FAMILIAR");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. AGREGAR CONTACTO EMPRESARIAL");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opc = int.Parse(Console.ReadLine());

                            switch(opc)
                            {
                                case 1:
                                    presentacionFamiliar.AgregarFamiliar(15, 5);
                                    break;
                                case 2:
                                    presentacionEmpresarial.AgregarEmpresarial(15, 5);
                                    break;
                            }


                        } while (opc != 3);  //Menu selector para agregar contactos

                        break;
                    case 2:
                        int opci;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU VISUALIZADOR DE CONTACTOS");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. VER CONTACTOS FAMILIARES");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. VER CONTACTOS EMPRESARIALES");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opci = int.Parse(Console.ReadLine());

                            switch (opci)
                            {
                                case 1:
                                    presentacionFamiliar.MostrarFamiliar(15,5);
                                    break;
                                case 2:
                                    presentacionEmpresarial.MostrarEmpresarial(15, 5);
                                    break;
                            }


                        } while (opci != 3); //Menu selector para ver contactos

                        break;
                    case 3:
                        int opcB;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU BUSCADOR DE CONTACTOS");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. BUSCAR CONTACTOS FAMILIARES");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. BUSCAR CONTACTOS EMPRESARIALES");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opcB = int.Parse(Console.ReadLine());

                            switch (opcB)
                            {
                                case 1:
                                    presentacionFamiliar.BuscarPorTelefonoFamiliar(15, 5);
                                    break;
                                case 2:
                                    presentacionEmpresarial.BuscarPorTelefonoEmpresarial(15, 5);
                                    break;
                            }


                        } while (opcB != 3); //Menu selector para buscar contactos
                        break;
                    case 4:

                        break;
                    case 5:
                        int opcion;

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.SetCursorPosition(l, t - 2); Console.WriteLine("MENU DE ELIMINACIÓN DE CONTACTOS");
                            Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. ELIMINAR CONTACTO FAMILIAR");
                            Console.SetCursorPosition(l, t + 3); Console.WriteLine("2. ELIMINAR CONTACTO EMPRESARIAL");
                            Console.SetCursorPosition(l, t + 4); Console.WriteLine("3. REGRESAR AL MENU ANTERIOR");
                            Console.SetCursorPosition(l, t + 6); Console.WriteLine("Digite una opcion: ");
                            Console.SetCursorPosition(l + 19, t + 6); opcion = int.Parse(Console.ReadLine());

                            switch (opcion)
                            {
                                case 1:
                                    presentacionFamiliar.BorrarFamiliar(15, 5);
                                    break;
                                case 2:
                                    presentacionEmpresarial.BorrarEmpresarial(15, 5);
                                    break;
                            }


                        } while (opcion != 3); //Menu selector para eliminar contactos

                        break;
                    case 6:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("GRACIAS, VUELVA PRONTO");
                        Console.SetCursorPosition(l + 22, t - 2); Console.ReadKey();
                        break;
                }

            } while (op != 6);
        }
    }
}
