namespace MyTaxCalculator.Domain
{
    public interface ITiers
    {
        public double DefineDeduction(double amount);
        public double DefineRate(double amount);
    }
}