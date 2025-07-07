using FluentValidation;

public class UpdateProviderValidator : AbstractValidator<UpdateProviderDto>
{
    public UpdateProviderValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.BusinessName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.TradeName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.TaxId).NotEmpty().Length(11).Matches(@"^\d{11}$");
        RuleFor(x => x.PhoneNumber).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Website).MaximumLength(250).When(x => !string.IsNullOrWhiteSpace(x.Website));
        RuleFor(x => x.Country).NotEmpty();
        RuleFor(x => x.AnnualBillingUSD).GreaterThanOrEqualTo(0);
    }
}
