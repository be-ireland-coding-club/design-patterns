using System;
using StrategyPattern.Utils;

namespace StrategyPattern 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern Client calls!");

            List<Tuple<TransportTypesEnum,Points>> findRoutes = new List<Tuple<TransportTypesEnum,Points>>{
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Bus, new Points("Dublin", "Cork")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Car, new Points("Dublin", "Donegal")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Car, new Points("Donegal","Dublin")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Bicycle, new Points("Dublin", "Cork")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Walk, new Points("Dundrum", "Clondalkin")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Walk, new Points("Clondalkin","Dundrum")),
                new Tuple<TransportTypesEnum, Points> ( TransportTypesEnum.Walk, new Points("not here","not there"))
            };

            Client c = new Client();
            foreach (var route in findRoutes){
                if(!c.ResolveStrategy(route.Item1))
                    continue;

                Route resultRoute = c.ContextStrategy.ResolveRoute(route.Item2);

                c.ContextStrategy.DisplayRoute(resultRoute, route.Item2);                
            }
        }

    }
}