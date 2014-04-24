using System.Text.RegularExpressions;
using FluentValidation;
using WpfFluentValidationExample.ViewModels;

namespace WpfFluentValidationExample.Lib
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .NotEmpty()
                .WithMessage("Please Specify a Name.");

            RuleFor(user => user.Email)
                .EmailAddress()
                .WithMessage("Please Specify a Valid E-Mail Address");

            RuleFor(user => user.Zip)
                .Must(BeAValidZip)
                .WithMessage("Please Enter a Valid Zip Code");

        }

        private static bool BeAValidZip(string zip)
        {
            if (!string.IsNullOrEmpty(zip))
            {
                var regex = new Regex(@"\d{5}");
                return regex.IsMatch(zip);
            }
            return false;
        }
    }
}
