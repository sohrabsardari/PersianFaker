
using NFluent;
using PersianFaker.Resources.Helpers.NationalNumber;
using Xunit;

namespace PersianFaker.Tests
{
    public class NationalNumberTests
    {
        [Fact]
        public void should_create_valid_national_number()
        {
            var nationalNumber = NationalNumber.Create();

            var isValid = nationalNumber.IsValidNationalCode();
            Check.That(isValid).IsTrue();
        }

        [Theory]
        [InlineData("0440561988")]
        [InlineData("0660200326")]
        [InlineData("0296522654")]
        public void should_return_false_in_validate_invalid_nationalCode(string nationalCode)
        {
            var isValidNationalNumber = NationalNumber.IsValid(nationalCode);

            Check.That(isValidNationalNumber).IsFalse();
        }
        [Fact]
        public void should_return_true_in_validate_valid_nationalCode()
        {
            var isValidNationalNumber = NationalNumber.IsValid(NationalNumber.Create());

            Check.That(isValidNationalNumber).IsTrue();
        }
    }
}