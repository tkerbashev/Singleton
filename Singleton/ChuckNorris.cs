namespace Singleton
{
    internal class ChuckNorris : IFighter
    {
        // There can be only one Chuck Norris!
        private static readonly Lazy<ChuckNorris> _instance = new Lazy<ChuckNorris>(() => new ChuckNorris());
        
        public static ChuckNorris Instance => _instance.Value;

        public string? Name => "Carlos Ray Norris";

        public int Strength => int.MaxValue;
    }
}
