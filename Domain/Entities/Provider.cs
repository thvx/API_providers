namespace DiligenciaProveedores.Domain.Entities;
using DiligenciaProveedores.Domain.Enums;

public class Provider
{
    public Guid Id { get; set; }
    public string BusinessName { get; set; } = default!;
    public string TradeName { get; set; } = default!;
    public string TaxId { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Website { get; set; } = default!;
    public string Address { get; set; } = default!;
    public Country Country { get; set; }
    public decimal AnnualBillingUSD { get; set; }
    public DateTime LastModified { get; set; }

    public void UpdateLastModified() => LastModified = DateTime.UtcNow;
}
