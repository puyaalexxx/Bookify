namespace Bookify.Domain.Apartments
{
    public record Currency
    {
        public string Code { get; init; }

        public static readonly Currency None = new("");
        public static readonly Currency Usd = new("USD");
        public static readonly Currency Eur = new("EUR");

        private Currency(string code) => Code = code;

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code)
                   ?? throw new ApplicationException("The currency code is invalid");
        }

        public static readonly IReadOnlyCollection<Currency> All = new[]
        {
            Usd,
            Eur
        };
    }
}
