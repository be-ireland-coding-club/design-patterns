using System;
using System.Text;
using StrategyPattern;
using StrategyPattern.Interfaces;
using StrategyPattern.StrategyAlgorithms;

namespace StrategyPattern.Utils
{
    public static class Extensions
    {
        public static bool ResolveStrategy(this Client c, TransportTypesEnum transportType)
        {
            try{
                c.ResolveStrategyAlgorithms(transportType);
                
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(" - There was an error trying to resolve the algorithm.");
                Console.WriteLine($" - Error: {ex.Message}");
            }
            return false;
        }

        public static Route ResolveRoute(this StrategyContext c, Points p)
        {
            try{
                return c.getRoute(p.LocationFrom, p.LocationTo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(" - There was an error trying to get the route.");
                Console.WriteLine($" - Error: {ex.Message}");
            }
            return null;
        }

        public static void DisplayRoute(this StrategyContext c, Route r, Points p){
            try{
            Console.WriteLine("--------------------------------");
            if(c is null){
                Console.WriteLine("The Context is null. We could not resolve the algorithm!");
                return;
            }

           Console.WriteLine($"The algorithm is {c.getStrategyName}");

            if(r is null){
                Console.WriteLine($"The route is null. There is no route between {p.LocationFrom} and {p.LocationTo} !");
                return;
            }

            Console.WriteLine($"Between {p.LocationFrom} and {p.LocationTo} with {r.Budget.ToString()}euro you will get in {r.TimeInMinutes.ToString()} minutes");

            var s = new StringBuilder();
            Console.WriteLine($"The route is:{r.RoutePath}");

            Console.WriteLine("--------------------------------");
            }
            catch(Exception ex)
            {
                Console.WriteLine(" - There was an error trying to display the result.");
                Console.WriteLine($" - Error: {ex.Message}");
            }
        }
    }
}