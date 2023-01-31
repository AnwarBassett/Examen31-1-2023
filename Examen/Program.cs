using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TextWriter archivo;
            //archivo = new StreamWriter("Datos.txt");
            //archivo.Close();
            do
            {
                try
                {
                    Estudiante est=new Estudiante();
                    int opc;
                    double sumatoria = 0;
                    String Nombre;
                    String res;
                    
                    int cont=0;
                    double a, b, c, d;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(est.opc());
                        opc=int.Parse(Console.ReadLine());
                        if (opc <=0 || opc>5)
                        {
                            Console.WriteLine("No puede digitar una opcion negativa o superior al rango");
                        }
                    } while (opc <= 0 || opc>5);
                    switch (opc)
                    {
                        case 1:
                            Console.Clear();
                            TextWriter archivo;
                            archivo = new StreamWriter("Datos.txt");
                            archivo.Close();
                            Console.WriteLine("Archivo Creado");
                            Console.WriteLine("Pulse una tecla para continuar");
                            Console.ReadKey();
                            break;
                        case 2:
                            try
                            {
                                do
                                {
                                    
                                    Console.Clear();
                                    Console.WriteLine("Agregar un estudiantes");
                                    cont++;
                                    double[] vector = new double[cont];
                                    Console.WriteLine("Ingrese su nombre");
                                    Nombre = Console.ReadLine();
                                    do
                                    {
                                        Console.WriteLine("Ingrese la Nota de la Clase de español");
                                        a = double.Parse(Console.ReadLine());
                                        if (a < 0 || a > 100)
                                        {
                                            Console.WriteLine("No puede ingresar datos negativos ni mayores que 100");
                                        }
                                    } while (a < 0 || a > 100);
                                    do
                                    {
                                        Console.WriteLine("Ingrese la Nota de la Clase de Matematica");
                                        b = double.Parse(Console.ReadLine());
                                        if (b < 0 || b > 100)
                                        {
                                            Console.WriteLine("No puede ingresar datos negativos ni mayores que 100");
                                        }

                                    } while (b < 0 || b > 100);
                                    do
                                    {
                                        Console.WriteLine("Ingrese la Nota de la Clase de Fisica");
                                        c = double.Parse(Console.ReadLine());
                                        if (c < 0 || c > 100)
                                        {
                                            Console.WriteLine("No puede ingresar datos negativos ni mayores que 100");
                                        }

                                    } while (c < 0 || c > 100);
                                    do
                                    {
                                        Console.WriteLine("Ingrese la Nota de la Clase de Ingles");
                                        d = double.Parse(Console.ReadLine());
                                        if (d < 0 || d > 100)
                                        {
                                            Console.WriteLine("No puede ingresar datos negativos ni mayores que 100");
                                        }

                                    } while (d < 0 || d > 100);
                                    for (int i = 0; i < 1; i++)
                                    {
                                        vector[i] = (est.Prom(a, b , c , d));
                                    }
                                    for (int i = 0; i < 1; i++)
                                    {
                                        double numeroActual = vector[i];
                                        sumatoria += numeroActual;
                                    }
                                    Console.WriteLine(est.Estu(est.Names = (Nombre), est.Esps = (a), est.Mats = (b), est.Fiss = (c), est.Ings = (d), est.Cnts=(cont), est.Promedios=(sumatoria), est.Sumas=(sumatoria)));
                                    Console.WriteLine("Desea salir?No=n/Si=CualquierTecla");
                                    res = Console.ReadLine();
                                } while (res.ToLower() == "n");

                            }
                            catch(Exception exp)
                            {
                                Console.WriteLine(exp);
                            }

                            break;
                        case 3:
                            Console.Clear();
                            TextReader Leer_texto;
                            Leer_texto = new StreamReader("Datos.txt");
                            Console.WriteLine(Leer_texto.ReadToEnd());
                            Console.WriteLine("Presione cualquier tecla para salir");
                            Console.ReadKey();
                            Leer_texto.Close();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Desea Eliminar el archivo?Si=s/No=CualquierTecla");
                            res = Console.ReadLine();
                            if(res.ToLower() == "s")
                            {
                                File.Delete("Datos.txt");
                                Console.WriteLine("Archivo eliminado");
                                Console.WriteLine("Presione cualquier tecla para salir");
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No existe esa opcion");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}
