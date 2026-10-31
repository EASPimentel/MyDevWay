namespace Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        short option;
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");
            while (!short.TryParse(Console.ReadLine(), out option) || option < 1 || option > 5)
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
            }
            switch (option)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multiplication(); break;
                case 4: Division(); break;
                case 5: Console.Clear(); Console.WriteLine("Saindo..."); System.Environment.Exit(0); break;         
            }
        } while (option != 5);
    }
    static void Sum()
    {
        Console.Clear();
        double n1 = GetNumber("primeiro");
        double n2 = GetNumber("segundo");
        Console.WriteLine($"Resultado: {n1 + n2}");
        Console.ReadKey();
    }
    static void Subtraction()
    {
        Console.Clear();
        double n1 = GetNumber("primeiro");
        double n2 = GetNumber("segundo");
        Console.WriteLine($"Resultado: {n1 - n2}");
        Console.ReadKey();
    }
    static void Multiplication()
    {
        Console.Clear();
        double n1 = GetNumber("primeiro");
        double n2 = GetNumber("segundo");
        Console.WriteLine($"Resultado: {n1 * n2}");
        Console.ReadKey();
    }
    static void Division()
    {
        Console.Clear();
        double n1 = GetNumber("primeiro");
        double n2 = GetNumber("segundo");
        if (n2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine($"Resultado: {n1 / n2}");
        Console.ReadKey();
    }

    static double GetNumber(string order)
    {
        double number;
        Console.WriteLine($"Digite o {order} número:");
        while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Opção inválida. Digite novamente:");
            }
        return number;
    }

}