using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Metodos
    {
        
        private double NT1, NT2, NT3, NT4, cn;

        public Metodos()
        {
        }

        public Metodos(double nT1, double nT2, double nT3, double nT4, double CN)
        {
            NT1 = nT1;
            NT2 = nT2;
            NT3 = nT3;
            NT4 = nT4;
            cn = CN;
        }
        public double NT11 { get => NT1; set => NT1 = value; }
        public double NT21 { get => NT2; set => NT2 = value; }
        public double NT31 { get => NT3; set => NT3 = value; }
        public double NT41 { get => NT4; set => NT4 = value; }
        public double Cn { get => cn; set => cn = value; }

        public double Prom(double nT1, double nT2, double nT3, double nT4)
        {
            double z = nT1 + nT2 + nT3 + nT4;
            return (z / 4);
        }
        
        public double NtMayor(double nT1, double nT2, double nT3, double nT4)
        {
            double[] array = new double[4];
            array[0] = nT1;
            array[1] = nT2;
            array[2] = nT3;
            array[3] = nT4;
            double z = array.Max();
            return z;
        }
        public double NtMenor(double nT1, double nT2, double nT3, double nT4)
        {
            double[] array = new double[4];
            array[0]= nT1;
            array[1]= nT2;
            array[2]= nT3;
            array[3]= nT4;
            double z = array.Min();
            return z;
        }
    }
}
