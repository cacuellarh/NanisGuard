namespace NanisGuard.src
{
    public static partial class GuardExtensions
    {
        public static int EnumerableLengthRequired(this IGuardValidation guardValidation,
            int currentLength,
            int requiredLegth,
            Exception? customException = null,
            string? message = null
            )
        {
            if (currentLength != requiredLegth)
            {
                throw customException ??
                    new ArgumentOutOfRangeException(message ??
                    $"El numero de elementos actuales ({currentLength}), no cumple con el numero de elementos requeridos ({requiredLegth})");
            }

            return requiredLegth;
        }
    }
}
