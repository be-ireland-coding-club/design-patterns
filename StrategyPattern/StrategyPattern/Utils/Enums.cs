namespace StrategyPattern.Utils
{
    public enum TransportTypesEnum
    {
        Car,
        Walk,
        Bus,
        Bicycle,
        Unknown
    }

    public class StrategyNames
    {
        public const string Car_AlgorithmName = "CarAlgorithm Strategy";
        public const string Walk_AlgorithmName = "WalkAlgorithm Strategy";
        public const string Public_AlgorithmName = "PublicAlgorithm Strategy";
        public const string Bicycle_AlgorithmName = "BicycleAlgorithm Strategy";
    }
}