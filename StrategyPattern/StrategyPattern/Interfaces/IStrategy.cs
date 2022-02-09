using StrategyPattern.Utils;

namespace StrategyPattern.Interfaces
{
    public interface IStrategy
    {
        string GetStrategyName { get; }
        Route execute(string locationFrom, string locationTo);
    }
}