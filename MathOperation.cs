namespace desafio_fundamentos_csharp;

public class MathOperation
{
    public static double Sum(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static (double result, string text) Divide(double a, double b)
    {
        if(a/b == 1)
        {
            return (a/b, "O resultado da divisão é 1");
        }
        return (a/b, "O resultado da divisão é " + a/b);
    }
}
