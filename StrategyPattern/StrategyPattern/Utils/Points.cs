namespace StrategyPattern.Utils
{
    public class Points
    {        
        public string LocationFrom {get; }
        public string LocationTo {get; }

        public Points(string locationFrom, string locationTo)
        {
            this.LocationFrom = locationFrom;
            this.LocationTo=locationTo;
        }
    }
}