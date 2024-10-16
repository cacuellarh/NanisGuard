using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static T NotNull<T>(this IGuardValidation guardValidation,
            T input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Func<Exception>? customException = null,
            string? message = null
            )
        {
           
            if (input is null)
            {
                throw customException?.Invoke() ??
                    new ArgumentNullException(message ?? parameterName);
            }

            return input;
        }

    }
}
