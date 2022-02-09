using StrategyPattern.Interfaces;
using StrategyPattern.Utils;
using System;

namespace StrategyPattern.StrategyAlgorithms
{
    public class CarAlgorithm: IStrategy
    {        
        private List<Route> carMap = new List<Route>()
        {
            new Route{ Locations = new Points ("Abc", "Ddd"), RoutePath = "Abc,Bb,Cc,Ddd", Budget=10, TimeInMinutes=50 },
            new Route{ Locations = new Points ("Dublin", "Donegal"), RoutePath = "Dublin,Cavan,Donegal", Budget=9, TimeInMinutes=100 },
        };

        public string GetStrategyName {
            get{
                return StrategyNames.Car_AlgorithmName;
            }
        }
        
       public Route execute(string locationFrom, string locationTo){
            foreach(var route in carMap){
                if(route.Locations.LocationFrom == locationFrom && route.Locations.LocationTo == locationTo)
                    return route;
            }

            throw new EntryPointNotFoundException($"There is no Known route between the given points: {locationFrom} .. to .. {locationTo}");
        }

    }
}