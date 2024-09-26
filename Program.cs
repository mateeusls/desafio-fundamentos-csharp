namespace desafio_fundamentos_csharp;
class Program {
    static void Main() {
        // var welcomeUser = new WelcomeUser();
        
        // Console.WriteLine("Digite seu nome:");
        // var name = Console.ReadLine();
        // Console.WriteLine(welcomeUser.Welcome(name));

        // // ----------------------------

        // var concatFirstAndLastName = new ConcatFirstAndLastName();
        // Console.WriteLine("Digite seu primeiro nome:");
        // var firstName = Console.ReadLine();
        // Console.WriteLine("Digite seu sobrenome:");
        // var lastName = Console.ReadLine();
        // Console.WriteLine(concatFirstAndLastName.Concat(firstName: firstName, lastName: lastName));

        // ----------------------------

        // Console.WriteLine("Digite o primeiro número:");
        // var firstNumber = double.Parse(Console.ReadLine());

        // Console.WriteLine("Digite o segundo número:");
        // var secondNumber = double.Parse(Console.ReadLine());

        // Console.WriteLine($"Soma: {MathOperation.Sum(firstNumber, secondNumber)}");
        // Console.WriteLine($"Subtração: {MathOperation.Subtract(firstNumber, secondNumber)}");
        // Console.WriteLine($"Multiplicação: {MathOperation.Multiply(firstNumber, secondNumber)}");
        // var (result, text) = MathOperation.Divide(firstNumber, secondNumber);
        // Console.WriteLine($"Divisão: {result} - {text}");

        // ----------------------------

        // string input = string.Empty;  
        
        // while (string.IsNullOrWhiteSpace(input)) {
        //     Console.WriteLine("Digite um número:");
        //     input = Console.ReadLine();

        //     if (string.IsNullOrWhiteSpace(input)) {
        //         Console.WriteLine("Número inválido, tente novamente.");
        //     }
        // }

        // var number = double.Parse(input);
        // Console.WriteLine($"Número digitado: {number}");

        // ----------------------------

        // Console.WriteLine(CharCount.Count(text: "H"));

        // ----------------------------

        // Console.WriteLine(CarValidation.Validate("1BC1234"));

        // ----------------------------

        Console.WriteLine(FormatDate.Format());
    }
}