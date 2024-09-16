using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        public static T Null<T>(this IGuardValidation guardValidation,
            T? input,
            string message = null,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null
            ) where T : struct
        {
            if (input is null)
            { 
                throw customException ?? new ArgumentNullException(parameterName);
            }

            return input.Value;
        }

    }
}
