using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actvidad_2.Clases
{
    public class clsOperacion
    {
        public int Multiplicar(int numa, int numb)
        {
            int resultado;
            resultado = numa * numb;
            return resultado;
        }
        public int Sumar(int numa, int numb)
        {
            int resultado;
            resultado = numa + numb;
            return resultado;
        }
        public int Restar(int numa, int numb)
        {
            int resultado;
            resultado = numa - numb;
            return resultado;
        }
        public float Dividir(int numa, int numb)
        {
            float resultado;
            resultado = numa / numb;
            return resultado;
        }

    }
}
