using System;
using System.Collections.Generic;

namespace P6___Áreas
{
    public static class Calculator
    {
        public static string Cuadrado(decimal ladoCuadrado1, decimal ladoCuadrado2)
        {

            if (ladoCuadrado1 != ladoCuadrado2)
            {
                return "Error";
            }

            if (ladoCuadrado1 <= 0 || ladoCuadrado2 <= 0)
            {
                return "Error";
            }

            else
            {
                decimal resultadoAreaCuadrado = decimal.Round((ladoCuadrado1 * ladoCuadrado2), 2);
                return resultadoAreaCuadrado.ToString();
            }

        }

        public static string Triangulo(decimal baseTriangulo, decimal alturaTriangulo)
        {
            if (baseTriangulo <= 0 || alturaTriangulo <= 0)
            {
                return "Error";
            }
            else
            {
                decimal resultadoAreaTriangulo = decimal.Round(((baseTriangulo * alturaTriangulo) / 2), 2);
                return resultadoAreaTriangulo.ToString();
            }


        }

        public static string Rectangulo(decimal ladoRectangulo1, decimal ladoRectangulo2)
        {

            if (ladoRectangulo1 == ladoRectangulo2)
            {
                return "Error";
            }

            if (ladoRectangulo1 <= 0 || ladoRectangulo2 <= 0)
            {
                return "Error";
            }

            else
            {
                decimal resultadoAreaRectangulo = decimal.Round((ladoRectangulo1 * ladoRectangulo2), 2);
                return resultadoAreaRectangulo.ToString();
            }
        }
        public static string Pentagono(decimal perimetroPentagono, decimal apotemaPentagono)
        {
            decimal numeroLados = 5;
            decimal ladoPentagono = perimetroPentagono / numeroLados;
            double angulo = 36 * Math.PI / 180.0;
            decimal tangenteAngulo = Convert.ToDecimal(Math.Tan(angulo));
            decimal apotema = decimal.Round(ladoPentagono / (2 * tangenteAngulo), 2);


            if (apotemaPentagono != apotema)
            {
                return "Error";

            }

            if (perimetroPentagono < apotemaPentagono)
            {
                return "Error";
            }

            if (perimetroPentagono == apotemaPentagono)
            {
                return "Error";
            }

            if (perimetroPentagono <= 0 || apotemaPentagono <= 0)
            {
                return "Error";
            }

            else
            {
                decimal resultadoAreaPentagono = decimal.Round(((perimetroPentagono * apotemaPentagono) / 2), 2);
                return resultadoAreaPentagono.ToString();
            }

        }

        public static string Circulo(decimal radio)
        {
            double radioDoble = Convert.ToDouble(radio);
            decimal radioCuadrado = Convert.ToDecimal(Math.Pow(radioDoble, 2));
            decimal pi = Convert.ToDecimal(Math.PI);

            if (radio <= 0)
            {
                return "Error";
            }

            else
            {
                decimal resultadoAreaCirculo = decimal.Round((pi * radioCuadrado), 2);
                return resultadoAreaCirculo.ToString();

            }

        }

    }
}
