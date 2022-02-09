using StrategyPattern.Interfaces;
using StrategyPattern.Utils;

namespace StrategyPattern
{
    public class StrategyContext
    {
        IStrategy strategy; 

        public string getStrategyName {
            get{
                return this.strategy.GetStrategyName;
            }
        }

        public void setStrategy(IStrategy paramStrategy){
            this.strategy = paramStrategy;
        }

        public Route getRoute(string locationFrom, string locationTo){
            return this.strategy.execute(locationFrom, locationTo);
        }
    }
}