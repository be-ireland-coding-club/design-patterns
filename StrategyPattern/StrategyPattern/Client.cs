using System;
using StrategyPattern.Utils;
using StrategyPattern.StrategyAlgorithms;

namespace StrategyPattern
{
    public class Client
    {
         public StrategyContext ContextStrategy {get; private set; } 

        public Client()
        {
            ContextStrategy = new StrategyContext();
        }

        public void ResolveStrategyAlgorithms(TransportTypesEnum transportType){
                switch(transportType)
                {
                    case TransportTypesEnum.Bus: 
                        this.ContextStrategy.setStrategy(new PublicAlgorithm());
                        break;
                    case TransportTypesEnum.Car: 
                        this.ContextStrategy.setStrategy(new CarAlgorithm());
                        break;
                    case TransportTypesEnum.Bicycle: 
                        this.ContextStrategy.setStrategy(new BicycleAlgorithm());
                        break;
                    case TransportTypesEnum.Walk: 
                        this.ContextStrategy.setStrategy(new WalkAlgorithm());
                        break;
                    default: 
                        this.ContextStrategy = null;
                        throw new NotSupportedException("The transport type is not supported! Please use an existing transport type.");
                }
        }
    }
}