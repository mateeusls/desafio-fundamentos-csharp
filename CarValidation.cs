using System;
using System.Linq;

namespace desafio_fundamentos_csharp;

public class CarValidation {
    public static bool Validate(string plate) {
        var plateTrim = plate.Trim();
        bool hasLetter = plateTrim.Any(char.IsLetter);
        bool hasNumber = plateTrim.Any(char.IsDigit);
        bool theeFirstLetters = plateTrim.Substring(0, 3).All(char.IsLetter);
        bool theLastFourNumbers = plateTrim.Substring(3, 4).All(char.IsDigit);

        if(plateTrim.Length != 7 || !hasLetter || !hasNumber || !theeFirstLetters || !theLastFourNumbers) {
            return false;
        }

        return true;
    }
}
