using Calc_Geometrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuras_geometricas
{
    public class Elipse:FigurasGeometricas
    {
        double radio_menor {  get; set; }
        double radio_mayor { get; set; }

        public Elipse(double radio_menor, double radio_mayor)
        {
            this.radio_menor = radio_menor;
            this.radio_mayor = radio_mayor;
        }

        public override double CalcularArea()
        {
            return 3.141592*radio_menor*radio_mayor;
        }
    }
}
