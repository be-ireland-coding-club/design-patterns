using StrategyPattern.Interfaces;
using StrategyPattern.Utils;
using System;

namespace StrategyPattern.StrategyAlgorithms
{
    public class BicycleAlgorithm: IStrategy
    {
        public string GetStrategyName {
            get{
                    return StrategyNames.Bicycle_AlgorithmName;
            }
        }

        public Route execute(string locationFrom, string locationTo){
            throw new NotImplementedException("The BicycleAlgorithm strategy is not implemented yet!");
        }
    }
}