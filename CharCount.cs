namespace desafio_fundamentos_csharp;

public class CharCount
{
    public static int Count(string text)
    {
        var count = 0;
        var textTrim = text.Trim().Replace(" ", "");
        foreach (var c in textTrim)
        {
            count++;
        }

        return count;
    }
}
