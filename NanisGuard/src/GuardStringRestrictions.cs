using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static string StringAsOnlyContainsLetters(this IGuardValidation guarValidation,
            string input,
            Exception? customException = null,
            string? message = null,
            [CallerArgumentExpression("input")] string? parameterName = null)
        {

            if (!input.All(char.IsLetter))
            {
                throw customException ?? new ArgumentException($"El campo {parameterName} tiene que contar con solo letras.");
            }

            return input;
        }

        public static string StringAsOnlyContainsDigits(this IGuardValidation guarValidation,
            string input,
            Exception customException = null,
            string? message = null,
            [CallerArgumentExpression("input")] string? parameterName = null)
        {

            if (!input.All(char.IsNumber))
            {
                throw customException ?? new ArgumentException($"El campo {parameterName} tiene que contar con solo digitos.");
            }

            return input;
        }

        public static string StringAsValidEmailFormat(this IGuardValidation guarValidation,
            string input,
            Exception? customException = null,
            string? message = null,
            [CallerArgumentExpression("input")] string? parameterName = null)
        {

            if (!input.Contains("@"))
            {
                throw customException ?? new FormatException($"El valor ingreasdo {input} no contiene un formato valido para la propiedad {parameterName}");
            }

            return input;
        }
    }
}
