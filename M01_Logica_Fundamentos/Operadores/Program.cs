/*
- Aritmeticos
()
math.Pow() e Math.Sqrt()
/, *, %
+, -
obs: não existe operador de potenciação e raiz quadrada, mas podemos usar a classe Math para isso -> math.Pow() e Math.Sqrt()

- Atribuição
 atribuição simples: =
 atribuição composta: +=, -=, *=, /=, %=

 - Incremento e Decremento
 incremento: ++
 decremento: --

 - Comparação
 ==, !=, >, <, >=, <=

 - Lógicos
 &&, ||, !

 - Bitwise
 &, |, ^, ~, <<, >> (usado para analise de bits, não é muito usado)

 - Ternário
 condição ? valor1 : valor2

 - condicional
 if, else, else if, switch, case, default
 
 - Laços de repetição
 for, while, do while, foreach
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        double firstNumber = EnterNumber();
        double secondNumber = EnterNumber();
        double thirdNumber = EnterNumber();

        CalcBaskara(firstNumber, secondNumber, thirdNumber);
    }

    static double EnterNumber()
    {
        Console.WriteLine("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        return num;
    }

    static double CalcBaskara(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("O valor de 'a' não pode ser zero.");
            return double.NaN;
        }
        double delta = Math.Pow(b,2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Não existem raízes reais.");
            return double.NaN;
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"As raízes são: x1 = {x1}, x2 = {x2}");
            return delta;
        }
    }
}