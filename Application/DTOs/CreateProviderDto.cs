public class CreateProviderDto
{
    public string BusinessName { get; set; } = default!;
    public string TradeName { get; set; } = default!;
    public string TaxId { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Website { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Country { get; set; } = default!;
    public decimal AnnualBillingUSD { get; set; }
}
