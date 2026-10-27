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
        QuadraticEquation();
    }

    static double EnterNumber()
    {
        Console.WriteLine("Digite um número: ");
        double? enterValue = null;
        double num;
        while (!enterValue.HasValue)
        {
            enterValue = double.TryParse(Console.ReadLine(), out num) ? num : null;
            if (!enterValue.HasValue) Console.WriteLine("Entrada inválida. Digite um número válido: ");
        }
        return enterValue.Value;
    }
    static (double x1, double x2) CalcBaskhara(double a, double b, double c)
    {
        double x1, x2;
        if (a == 0)
        {
            return (double.NaN, double.NaN);
        }
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Não existem raízes reais.");
            return (double.NaN, double.NaN);
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        }
        return (x1, x2);
    }
    static (double x1, double x2) QuadraticEquation()
    {
        Console.WriteLine("Digite os coeficientes da equação quadrática (ax² + bx + c = 0):");
        
        var a = EnterNumber();
        while(a == 0)
        {
            Console.WriteLine("O coeficiente 'a' não pode ser zero. Digite um valor diferente de zero para 'a':");
            a = EnterNumber();
        }        
        var b = EnterNumber();
        var c = EnterNumber();
        var (x1, x2) = CalcBaskhara(a, b, c);
        if (double.IsNaN(x1) || double.IsNaN(x2))
        {
            Console.WriteLine("Não foi possível calcular as raízes.");
            return (double.NaN, double.NaN);
        }
        if (x1 > x2)
        {
            Console.WriteLine($"O Conjunto solução da equação é: ({x2:f2}, {x1:f2})");
            return (x2, x1);
        }         
        else
        {
            Console.WriteLine($"O Conjunto solução da equação é: ({x1:f2}, {x2:f2})");
            return (x1, x2);
        }
    }

}