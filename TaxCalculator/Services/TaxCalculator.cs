using System;

namespace MyTaxCalculator.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        private readonly ITiers _tier;
        public TaxCalculator(ITiers tier)
        {
            _tier = tier;
        }

        public double TaxCalculation(double value)
        {
            double tax;
            tax = _tier.DefineRate(value) * value - _tier.DefineDeduction(value);
            return tax;
        }
    }
}