using AbstractClass.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    public class Calculation:ICalculation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

            public double Division(double a, double b)
            {
                 Num1 = a;
                 Num2 = b;
                 return a / b;
            }

            public double Multiplication(double a, double b)
            {
                     Num1 = a;
                     Num2 = b;
                     return a * b;
             }

            public double Plus(double a, double b)
            {
                     Num1 = a;
                     Num2 = b;
                 return a + b;
            }
            
            public double Substraction(double a, double b)
            {
                  Num1 = a;
                  Num2 = b;
                 return a - b;
        }

                
    }
}
