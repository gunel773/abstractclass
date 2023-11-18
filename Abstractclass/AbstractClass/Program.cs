using AbstractClass.Models;

Calculation calculation = new Calculation();
calculation.Num1=double.Parse(Console.ReadLine());
calculation.Num2 = double.Parse(Console.ReadLine());
double result1= calculation.Multiplication(calculation.Num1, calculation.Num2);
double result2=calculation.Substraction(calculation.Num1, calculation.Num2);
double result3=calculation.Division(calculation.Num1, calculation.Num2);
double result4=calculation.Plus(calculation.Num1,calculation.Num2);
Console.WriteLine($"ededlerin hasili:{result1}");
Console.WriteLine($"ededlerin ferqi:{result2}");
Console.WriteLine($"ededlerin qismeti:{result3}");
Console.WriteLine($"ededlerin cemi:{result4}");

