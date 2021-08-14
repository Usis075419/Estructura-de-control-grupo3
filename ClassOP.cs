using System;
using System.Collections.Generic;
using System.Text;

namespace Estructura_de_constro__Semana_3_C
{
    class ClassOP
    {
        double A, B;

        public ClassOP (double A, double B)
        { this.A = A;
            this.B = B;
        }

        public double opsuma()
        {
            return A + B;
        }

        public double opresta()
        {
            return A - B;
        }
          public double opmultiplicar()
        { 
            return  A *B;
        }

        public double opdividir()
        {
            return A / B;
        }
    }
}
