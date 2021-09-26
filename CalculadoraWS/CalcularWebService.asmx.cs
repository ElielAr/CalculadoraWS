using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CalculadoraWS.Clases;

namespace CalculadoraWS
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Bienvenida()
        {
            return "Hola a todos";
        }

        [WebMethod(Description="Este servicio web calcula el area de un cuadrado")]
        public decimal AreaCuadrado(int valor1, int valor2)
        {
            Calcular calcula = new Calcular();
            calcula.numero1 = valor1;
            calcula.numero2 = valor2;
            return calcula.areacuadrado();

        }

        [WebMethod(Description = "Este servicio web calcula el area de un triangulo")]
        public decimal AreaTriangulo(int Base, int Altura)
        {
            Calcular calcula = new Calcular();
            calcula.numero1 = Base;
            calcula.numero2 = Altura;
            return calcula.areatriangulo();

        }

        [WebMethod(Description = "Este servicio web calcula el area de un circulo")]
        public double AreaCirculo(int radio)
        {
            Calcular calcula = new Calcular();
            calcula.numero1 = radio;
          
            return calcula.areacirculo();

        }

    }
}
