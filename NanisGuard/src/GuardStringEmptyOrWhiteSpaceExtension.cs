using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static string Empty(this IGuardValidation guardValidation,
            string input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Func<Exception>? customException = null,
            string? message = null
            )
        {

            if (input.Length == 0 || input == string.Empty)
            {
                throw customException?.Invoke() ??
                    new ArgumentException(message ?? $"La propiedad {parameterName} no pude esta vacia.");
            }

            return input;
        }

        public static string WhiteSpace(this IGuardValidation guardValidation,
            string input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Func<Exception>? customException = null,
            string? message = null
            )
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                throw customException?.Invoke() ??
                    new ArgumentException(message ?? $"El campo {parameterName} contiene un espacio en blanco no permitido.");
            }

            return input;
        }

        public static T NotNullOrEmpty<T>(this IGuardValidation guardValidation,
            T input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Func<Exception>? customException = null,
            string? messageException = null
            )
        {
            NanisGuardV.validation.NotNull(input, parameterName,customException,messageException);
            NanisGuardV.validation.Empty(input.ToString()!, parameterName, customException, messageException);
            NanisGuardV.validation.WhiteSpace(input.ToString()!, parameterName, customException, messageException);
            return input;
        }
    }
}
