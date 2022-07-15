using MyTaxCalculator.Services;

namespace MyTaxCalculator.Presentation.Screens
{
    internal class ScreenFlow : IScreenFlow
    {
        public double Amount { get; set; }
        private readonly ITaxCalculator _calculator;
        public ScreenFlow(ITaxCalculator calculator)
        {
            _calculator = calculator;
        }

        public void GetValue()
        {
            Console.WriteLine("Qual o valor base para cálculo do imposto?");
            Amount = double.Parse(Console.ReadLine());
        }

        public void ReturnValue(double tax)
        {
            Console.WriteLine($"O valor do IR a ser pago é: R${Math.Round(tax, 2)}");
        }

        public void ExecuteFlow()
        {
            double taxValue;
            GetValue();
            taxValue = _calculator.TaxCalculation(Amount);
            ReturnValue(taxValue);
        }
    }
}