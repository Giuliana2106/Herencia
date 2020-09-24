using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculo_IVA
{
    class Operacion
    {
        public IVA iv = new IVA();
        public double n = 0;

        public string Resultado(char t)
        {
            double total = 0;

            char op = 's';

            while (op != 'n')
            {
                if (t == 's')
                {
                    total = Operacion.Iva(total, Pedir());
                }

                else()
            }
        }

    }
}
