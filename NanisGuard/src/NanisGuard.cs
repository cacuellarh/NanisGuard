namespace NanisGuard.src
{
    public interface IGuardValidation
    {

    }
    public class NanisGuardV : IGuardValidation
    {
        public static IGuardValidation validation { get; } = new NanisGuardV();
        private NanisGuardV() { }
    }
}
