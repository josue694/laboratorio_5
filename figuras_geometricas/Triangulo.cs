using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Geometrica
{
    public class Triangulo: FigurasGeometricas
    {
        double altura {  get; set; }
        double base_triangulo { get; set; }

        public Triangulo(double altura, double base_triangulo)
        {
            this.altura = altura;
            this.base_triangulo = base_triangulo;
        }

        public override double CalcularArea()
        {
            return altura * base_triangulo / 2;
        }


    }
}
