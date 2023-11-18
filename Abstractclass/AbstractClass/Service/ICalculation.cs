using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Service
{
     interface ICalculation
    {
          double Plus(double a, double b);
          double Substraction(double a, double b);
          double Division(double a, double b);
          double Multiplication(double a, double b);

    }
}
