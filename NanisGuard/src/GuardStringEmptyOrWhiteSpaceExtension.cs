using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static string Empty<T>(this IGuardValidation guardValidation,
            string input,
            Exception customException = null,
            string message = null,
            [CallerArgumentExpression("input")] string? parameterName = null
            ) where T : struct 
        {
            if (input.Length == 0 || input == string.Empty)
            {
                throw customException ?? new ArgumentException(message ?? $"La propiedad {parameterName} no pude esta vacia.");
            }

            return input;
        }

        public static string WhiteSpace<T>(this IGuardValidation guardValidation,
            string input,
            Exception customException = null,
            string message = null,
            [CallerArgumentExpression("input")] string? parameterName = null
            ) where T : struct
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw customException ?? new ArgumentException($"El campo {parameterName} contiene un espacio en blanco no permitido.");
            }

            return input;
        }
    }
}
