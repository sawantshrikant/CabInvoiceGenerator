namespace CabInvoiceGeneratorDemo
{
    public class CabInvoiceGenerator
    {
       
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MINUTE = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double cabFare = 0;
        public double CalculateFare(double distance, double time)
        {
            this.cabFare = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }
    }
}