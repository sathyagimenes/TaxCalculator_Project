namespace MyTaxCalculator.Services
{
    public interface ITiers
    {
        public double DefineDeduction(double amount);
        public double DefineRate(double amount);
    }
}