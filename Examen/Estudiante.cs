using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen
{
    public class Estudiante:Metodos
    {
        
        private string Name;
        private double Esp;
        private double Fis;
        private double Ing;
        private double Mat;
        private int Cnt;
        private double suma;
        private double promedio;
        public Estudiante()
        {
        }
        
        public Estudiante(string LocalName, double LocalEsp, double LocalFis, double LocalIng, double LocalMat, int LocalCnt, double LocalSuma, double LocalPromedio)
        {
            Name = LocalName;
            Esp = LocalEsp;
            Fis = LocalFis;
            Ing = LocalIng;
            Mat = LocalMat;
            Cnt = LocalCnt;
            suma = LocalSuma;
            promedio = LocalPromedio;
        }

        public string Names { get => Name; set => Name = value; }
        public double Esps { get => Esp; set => Esp = value; }
        public double Fiss { get => Fis; set => Fis = value; }
        public double Ings { get => Ing; set => Ing = value; }
        public double Mats { get => Mat; set => Mat = value; }
        public int Cnts { get => Cnt; set => Cnt = value; }
        public double Sumas { get => suma; set => suma = value; }
        public double Promedios { get => promedio; set => promedio = value; }

        public string Estu(string nm, double x, double y, double z, double w, double j, double i, double k)
        {
            String Mensaje = "\n";
            Mensaje += "\n================================================================";
            Mensaje += "\nN#" + j;
            Mensaje += "\nEl estudiante " + Names + " tiene un promedio de: " + Prom(Esp, Fis, Ing, Mat);
            if (Prom(Esp, Fis, Ing, Mat) > 70)
            {
                Mensaje += "\n*Aprobado*";
            }
            else
            {
                Mensaje += "\n*Reprobado*";
            }
            Mensaje += "\nLa nota Mayor es igual: " + NtMayor(Esp, Fis, Ing, Mat);
            Mensaje += "\nLa nota Menor es igual: " + NtMenor(Esp, Fis, Ing, Mat);
            Mensaje += "\nDatos Actuales del Salon:";
            Mensaje += "\nPromedio del salon: "+(Promedios/j);
            Mensaje += "\nSuma del Salon: "+(Sumas);
            Mensaje += "\nLa cantidad de alumnos: " + j;
            Mensaje += "\n================================================================";

            StreamWriter archivo = File.AppendText("Datos.txt");
            String mensaje2;
            mensaje2 = Mensaje;
            archivo.WriteLine(mensaje2);
            archivo.Close();
            return Mensaje;
        }
        public string opc()
        {
            String Mensaje="";
            Mensaje += "\nBienvenido al programa para ingresar datos de estudiantes";
            Mensaje += "\nSi es primera vez que ingresa al programa, Necesita Crear un nuevo Archivo";
            Mensaje += "\nSi el archivo no esta creado, los datos no se podran almacenar";
            Mensaje += "\nSi no es su primera vez en el programa, puede agregar estudiantes";
            Mensaje += "\n==========================================================================";
            Mensaje += "\nIngrese una opcion";
            Mensaje += "\n1.Crear un nuevo archivo";
            Mensaje += "\n2.Agregar estudiante";
            Mensaje += "\n3.Ver Lista de estudiantes";
            Mensaje += "\n4.Eliminar Archivo";
            Mensaje += "\n5.Salir";
            return Mensaje;
        }
    }

}
