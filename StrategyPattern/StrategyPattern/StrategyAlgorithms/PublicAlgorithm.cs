using StrategyPattern.Interfaces;
using StrategyPattern.Utils;
using System;

namespace StrategyPattern.StrategyAlgorithms
{
    public class PublicAlgorithm: IStrategy
    {
        public string GetStrategyName {
            get{                
                return StrategyNames.Public_AlgorithmName;
            }
        }

        public Route execute(string locationFrom, string locationTo){
            throw new NotImplementedException("The PublicAlgorithm strategy is not implemented yet!");
        }        
    }
}