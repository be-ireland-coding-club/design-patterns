using StrategyPattern.Interfaces;
using StrategyPattern.Utils;
using System;
using System.Collections.Generic;


namespace StrategyPattern.StrategyAlgorithms
{
    public class WalkAlgorithm : IStrategy
    {
        private List<Route> walkMap = new List<Route>()
        {
            new Route{ Locations = new Points ("A", "D"), RoutePath = "A,B,C,D", Budget=10, TimeInMinutes=50 },
            new Route{ Locations = new Points ("Dundrum", "Clondalkin"), RoutePath = "something,something else", Budget=5, TimeInMinutes=30 },
            new Route{ Locations = new Points ("A1","D1"), RoutePath = "A1,D1", Budget=9, TimeInMinutes=100 },
            new Route{ Locations = new Points ("Abcd", "Dcba"), RoutePath = "Abcd,Bbc,Cda,Dcba", Budget=10, TimeInMinutes=50 }
        };

        public string GetStrategyName {
            get{
                return StrategyNames.Walk_AlgorithmName;
            }
        }
        
        public Route execute(string locationFrom, string locationTo){
            foreach(var route in walkMap){
                if(route.Locations.LocationFrom == locationFrom && route.Locations.LocationTo == locationTo)
                    return route;
            }
            
            foreach(var route in walkMap){
                if(route.Locations.LocationFrom == locationTo && route.Locations.LocationTo == locationFrom)
                    {
                        Route reversedRoute= new Route { Locations = new Points(locationTo,locationFrom), RoutePath="", Budget=route.Budget, TimeInMinutes=route.TimeInMinutes} ;
                        reversedRoute.RoutePath = ReversePath( route.RoutePath);
                        return reversedRoute;
                    }
            }

            throw new EntryPointNotFoundException($"There is no Known route between the given points: {locationFrom} .. to .. {locationTo}");
        }

        private string ReversePath(string routePath){
            var path =routePath.Split(',', StringSplitOptions.RemoveEmptyEntries);
            List<string> reversePath = new List<string>();
            
            for(int i=path.Length-1; i>=0;i--){
                reversePath.Add(path[i]);
            }
            
            return string.Join(",",reversePath);
        }       
    }
}