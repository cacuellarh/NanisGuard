using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static int ValidateParseStringToInt(this IGuardValidation guardValidation,
            string input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null)
        {
            if (!int.TryParse(input, out int intParce))
            {
                throw customException ?? 
                    new FormatException(message ??
                    $"El valor ingresado {input} no contiene un formato valido para convertir a la propiedad {parameterName} de tipo int.");
            }

            return intParce;
        }

        public static long ValidateParseStringToLong(this IGuardValidation guardValidation,
            string input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null)
        {
            if (!long.TryParse(input, out long parsedValue))
            {
                throw customException ??
                    new FormatException(message ??
                    $"El valor ingresado {input} no contiene un formato valido para convertir a la propiedad {parameterName} de tipo Long.");
            }

            return parsedValue;
        }

        public static DateTime ValidateParseStringToDate(this IGuardValidation guardValidation,
            string input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null)
        {
            if (!DateTime.TryParse(input, out DateTime dateParse))
            {
                throw customException ??
                    new FormatException(message ??
                    $"El valor ingresado {input} no contiene un formato valido para convertir a la propiedad {parameterName} de tipo fecha.");
            }

            return dateParse;
        }
    }
}
