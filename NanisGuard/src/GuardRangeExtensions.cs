using System.Numerics;
using System.Runtime.CompilerServices;
using NanisGuard.src;

namespace NanisGuard
{
    public static partial class GuardExtensions
    {
        //Min - Max length validations

        public static T DigitMaxLength<T>(this IGuardValidation guardValidation,
            T input,
            int maxLength,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            ) where T : IConvertible
        {
            string intToString = input.ToString()!;

            if (intToString.Length > maxLength)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ?? $"El valor ingresado ({input}) excede el rango maximo de ({maxLength}) para la propiedad {parameterName}.");
            }

            return input;
        }
        public static int IntMaxLength(this IGuardValidation guardValidation,
            int input,
            int maxLength,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            string intToString = input.ToString();

            if (intToString.Length > maxLength)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ?? $"El valor ingresado ({input}) excede el rango maximo de ({maxLength}) para la propiedad {parameterName}.");
            }

            return input;
        }

        public static int IntMinLength(this IGuardValidation guardValidation,
            int input,
            int minLegth,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            string intToString = input.ToString();
            if (intToString.Length < minLegth)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ?? $"El valor ingresado ({input}) no tiene un rango minimo de ({minLegth}) para la propiedad {parameterName}.");
            }

            return input;
        }
        public static string StringMinLength(this IGuardValidation guardValidation,
            string input,
            int minLegth,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            if (input.Length < minLegth)
            {
                throw customException ?? 
                    new ArgumentOutOfRangeException(message ?? $"El valor ingresado ({input}) no tiene un rango minimo de ({minLegth}) para la propiedad {parameterName}.");
            }

            return input;
        }

        public static string StringMaxLength(this IGuardValidation guardValidation,
            string input,
            int maxLegth,
            [CallerArgumentExpression("input")] string parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            if (input.Length > maxLegth)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ?? $"El valor ingresado ({input}) excede el rango maximo de ({maxLegth}) para la propiedad {parameterName}.");
            }

            return input;
        }

        //Required length

        public static string StringRequiredLength(this IGuardValidation guardValidation,
            string input,
            int requiredLength,
            [CallerArgumentExpression("input")] string parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            if (input.Length != requiredLength)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El valor ingresado ({input}) no contiene el numero de caracteres permitidos ({requiredLength}) para la propiedad ({parameterName}).");
            }

            return input;
        }

        public static int IntRequiredLength(this IGuardValidation guardValidation,
            int input,
            int requiredLength,
            [CallerArgumentExpression("input")] string parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            string intParseToInt = input.ToString();
            if (intParseToInt.Length != requiredLength)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El valor ingresado ({input}) no contiene el numero de digitos permitidos ({requiredLength}) para la propiedad ({parameterName}).");
            }

            return input;
        }

        //Ranges

        public static string StringLengthRange(this IGuardValidation guardValidation,
            string input,
            int minLegth,
            int maxLegth,
            [CallerArgumentExpression("input")] string parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            NanisGuardV.validation.StringMinLength(input, minLegth, parameterName,customException,message);
            NanisGuardV.validation.StringMaxLength(input, maxLegth, parameterName, customException, message);

            return input;
        }

        public static int IntLengthRange(this IGuardValidation guardValidation,
            int input,
            int minLegth,
            int maxLegth,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            )
        {
            NanisGuardV.validation.IntMinLength(input, minLegth, parameterName, customException, message);
            NanisGuardV.validation.IntMaxLength(input, maxLegth, parameterName, customException, message);

            return input;
        }

        public static T NumberRange<T>(this IGuardValidation guardValidation,
            T input,
            int min,
            int max,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            ) where T : INumber<T>
        {
            if (input < T.CreateChecked(min) || input > T.CreateChecked(max))
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El valor ingresado ({input}) no cumple con el rango establecido ({min} - {max}) para la propiedad ({parameterName}).");
            }
            return input;
        }

        public static T NumberMin<T>(this IGuardValidation guardValidation,
            T input,
            int minValue,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            ) where T : INumber<T>
        {
            if (input > T.CreateChecked(minValue))
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El valor ingresado ({input}) no cumple con el valor minimo ({minValue}) para la propiedad ({parameterName}).");
            }

            return input;
        }

        public static T NumberMax<T>(this IGuardValidation guardValidation,
            T input,
            int maxValue,
            [CallerArgumentExpression("input")] string? parameterName = null,
            Exception? customException = null,
            string? message = null
            ) where T : INumber<T>
        {
            if (input > T.CreateChecked(maxValue))
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El valor ingresado ({input}) excede el valor permitido ({maxValue}) para la propiedad ({parameterName}).");
            }

            return input;
        }
    }
}
