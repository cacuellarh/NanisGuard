namespace NanisGuard.src
{
    public static partial class GuardExtensions
    {
        public static TimeSpan ValidateTryParseStringToTimeSpan(this IGuardValidation guardValidation,
            string input,
            Exception? customException = null,
            string? message = null
            )
        {
            if (!TimeSpan.TryParse(input, out TimeSpan hourParsed))
            {
                throw customException ?? 
                    new FormatException(message ?? $"El valor ingresado ({input}) no es un formato valido para convertir a una hora");
            }

            return hourParsed;
        }
    }
}
