namespace MyTaxCalculator.Domain
{
    public class Tiers : ITiers
    {
        public double DefineRate(double amount)
        {
            double taxRate;
            if (amount <= 22847.76)
                taxRate = 0;
            else if (amount > 22847.76 && amount <= 33919.80)
                taxRate = 0.075;
            else if (amount > 33919.80 && amount <= 45012.60)
                taxRate = 0.150;
            else if (amount > 45012.60 && amount <= 55976.16)
                taxRate = 0.225;
            else
                taxRate = 0.275;
            return taxRate;
        }

        public double DefineDeduction(double amount)
        {
            double deduction;
            if (amount <= 22847.76)
                deduction = 0;
            else if (amount > 22847.76 && amount <= 33919.80)
                deduction = 1713.58;
            else if (amount > 33919.80 && amount <= 45012.60)
                deduction = 4257.57;
            else if (amount > 45012.60 && amount <= 55976.16)
                deduction = 7633.51;
            else
                deduction = 10432.32;
            return deduction;
        }
    }
}