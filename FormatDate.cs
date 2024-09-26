using System.Globalization;

namespace desafio_fundamentos_csharp;

public class FormatDate
{
    public static string Format()
    {
        DateOnly dateFormatted = DateOnly.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
        var completeDate = dateFormatted.ToString("D", new CultureInfo("pt-BR")) + " " + DateTime.Now.ToString("HH:mm:ss");
        var nowDate = dateFormatted.ToString("dd/MM/yyyy");
        var hourTwentFour = DateTime.Now.ToString("HH:mm");
        var dateForExpansive = dateFormatted.ToString("dddd, dd 'de' MMMM 'de'yyyy", new CultureInfo("pt-BR"));

        return $"Data formatada: {completeDate}\nData atual: {nowDate}\nHora atual: {hourTwentFour}\nData formatada expansiva: {dateForExpansive}";
    }
}
