using System.Numerics;
using System.Runtime.CompilerServices;

namespace NanisGuard.src
{
    public static partial class GuardExtension
    {
        public static T DigitNotBeNegative<T>(this IGuardValidation guardValidation,
            T input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            ) where T : INumber<T>
        {
            if (input < T.Zero)
            { 
                throw customException ??  new 
                    ArgumentException(message ?? $"El valor introducido ({input}) no puede ser negativo para la propiedad ({parameterName})");
            }
            return input;
        }

    }
}
