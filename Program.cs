using System;

class Program
{
  static void Main()
  {

    // Exercicio01();
    // Exercicio02();
    // Exercicio03();
    // Exercicio04();
    // Exercicio05();
    Exercicio06();
    static void Exercicio01()
    {
      Console.WriteLine("Digite o seu nome:");
      string nomeUsuario = Console.ReadLine() ?? "Nome desconhecido";
      Console.WriteLine("Olá, " + nomeUsuario + "! Seja muito bem-vindo(a).");
    }

    static void Exercicio02()
    {
      Console.WriteLine("Digite o seu nome:");
      string nome = Console.ReadLine() ?? "Primeiro Nome";
      Console.WriteLine("Digite o seu sobrenome:");
      string sobrenome = Console.ReadLine() ?? "Sobrenome";
      Console.WriteLine("O seu nome completo é: " + nome + " " + sobrenome);
    }

    static void Exercicio03()
    {
      Console.WriteLine("Digite o primeiro número:");
      double primeiroNumero = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      double segundoNumero = Convert.ToDouble(Console.ReadLine());


      OperacoesMatematicas(primeiroNumero, segundoNumero);
    }

    static void OperacoesMatematicas(double number1, double number2)
    {
      Console.WriteLine($"A soma dos dois números é: {number1 + number2}");
      Console.WriteLine($"A subtração dos dois números é: {number1 - number2}");
      Console.WriteLine($"A multiplicação dos dois números é: {number1 * number2}");
      Console.WriteLine($"A média dos dois números é: {(number1 + number2) / 2}");
      if (number2 != 0)
      {
        Console.WriteLine($"A divisão dos dois números é: {number1 / number2}");
      }
      else
      {
        Console.WriteLine("Erro: Não é possível dividir por zero.");
      }
    }

    static void Exercicio04()
    {
      Console.WriteLine("Digite uma ou mais palavras:");
      string palavrasDigitadas = Console.ReadLine() ?? "Palavra Teste";
      Console.WriteLine("A quantidade de caracteres é: " + palavrasDigitadas.Replace(" ", "").Length);
    }

    static void Exercicio05()
    {
      Console.WriteLine("Digite a placa de um veículo:");
      string placa = Console.ReadLine() ?? "AAA1234";
      if (placa.Length == 7 && placa.Substring(0, 3).All(char.IsLetter) && placa.Substring(3, 4).All(char.IsDigit))
      {
        Console.WriteLine("Placa válida");
      }
      else
      {
        Console.WriteLine("Placa inválida");

      }
    }

    static void Exercicio06()
    {
      Console.WriteLine("Solicite a exibição da data atual");
      Console.WriteLine("Escolha as opções de formato:");
      Console.WriteLine("Formato Completo: 1 - Formato 01/03/2024: 2 - Formato de 24 horas: 3  - Formato data com o mês por extenso: 4");
      string? opcaoDigitada = Console.ReadLine() ?? "01/01/2024";
      bool entradaValida = int.TryParse(opcaoDigitada , out int formatoData);
      switch (formatoData)
    {
        case 1:
            Console.WriteLine(DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss")); // sexta-feira, 15 de novembro de 2024, 11:00:42
            break;
        case 2:
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy")); // 15/11/2024
            break;
        case 3:
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")); // 15/11/2024 11:01:14
            break;
        case 4:
            Console.WriteLine(DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy")); // 15 de novembro de 2024
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 4.");
            break;
    }
    }
  
  
  }

}
