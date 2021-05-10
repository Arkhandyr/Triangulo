using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        private readonly double a, b, c;
        private string resultadoValidacao = "";

        public Triangulo (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string MostrarTipo()
        {
            ValidarTriangulo();
            return $"O triângulo ({a}, {b}, {c}) é um triângulo {resultadoValidacao}.";
        }

        #region Métodos privados
        private string ValidarTriangulo()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                resultadoValidacao += "INVÁLIDO";
            else
            {
                if (this.a == this.b && this.b == this.c)
                    resultadoValidacao += "equilátero";
                else if (a == b || a == c || b == c)
                    resultadoValidacao += "isósceles";
                else
                    resultadoValidacao += "escaleno";
            }

            return resultadoValidacao;
        }
        #endregion
    }
}
