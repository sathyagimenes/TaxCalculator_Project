namespace MyTaxCalculator.Presentation.Screens
{
    internal interface IScreenFlow
    {
        public double Amount { get; set; }
        public void GetValue();
        public void ReturnValue(double tax);
        public void ExecuteFlow();
    }
}