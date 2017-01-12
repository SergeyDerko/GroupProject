namespace CurrencyRateServiceLibrary
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyDescription { get; set; }
        public double Purchase { get; set; }
        public double Sale { get; set; }

    }
}
