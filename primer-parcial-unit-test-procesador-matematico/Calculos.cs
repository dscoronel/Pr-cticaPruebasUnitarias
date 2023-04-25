using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class Calculos
    {
        int resultado;

        public void CalcularMayor(int primerNumero, int segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                this.resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                this.resultado = segundoNumero;
            }
            else
            {
                this.resultado = segundoNumero;
            }
        }







    }
}
