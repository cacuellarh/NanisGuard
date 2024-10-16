using System.Runtime.CompilerServices;

namespace NanisGuard.src
{
    public static partial class GuardExtensions
    {
        public static IEnumerable<T> EnumerableNotEmpty<T>(this IGuardValidation guardValidation,
            IEnumerable<T> input,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Func<Exception>? customException = null,
            string? message = null
            )
        {

            NanisGuardV.validation.NotNull(input,parameterName,customException,message);

            if (input.Count() == 0 || !input.Any())
            {
                throw customException?.Invoke() ??
                    throw new ArgumentException(message ?? $"La lista ingresada no puede estar vacia para el parametro {parameterName}");
            }

            return input;
        }

        public static bool EnumerableCompareLength<T,K>(this IGuardValidation guardValidation,
            IEnumerable<T> input,
            IEnumerable<K> compareTo,
            [CallerArgumentExpression("input")] string? parameterName = null,
            [CallerArgumentExpression("compareTo")] string? parameterEnumerableCompare = null,
            Func<Exception>? customException = null,
            string? message = null
            )
        {

            NanisGuardV.validation.NotNull(input, parameterName, customException, message);
            NanisGuardV.validation.NotNull(compareTo, parameterEnumerableCompare, customException, message);

            if (input.Count() != compareTo.Count())
            {
                throw customException?.Invoke() ?? 
                    new InvalidOperationException(message ?? $"El numero de elementos del la matriz {parameterName} ({input.Count()}) " +
                    $"es diferente al numero de elementos de la matriz {parameterEnumerableCompare} ({compareTo.Count()})");
            }

            return true;
        }
    }
}
