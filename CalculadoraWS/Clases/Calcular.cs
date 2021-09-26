using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWS.Clases
{
    public class Calcular
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public decimal areacuadrado()
        {
            return numero1 * numero2;
        }


        public decimal areatriangulo()
        {
            return numero1 * numero2 /2;
        }

        public double areacirculo()
        {
          
            double pi;
            double area;
            var  res= numero1 * numero1;

            pi = Convert.ToDouble(3.1416);
            area = Convert.ToDouble(res);

            return pi * area;
        }
    }
}