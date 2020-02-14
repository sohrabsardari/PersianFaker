using PersianFaker.Resources.Helpers.NationalNumber;

namespace PersianFaker
{
    public class NationalNumber
    {
        public static string Create()
        {
            return NationalNumberGenerator.CreateNew();
        }

        public static bool IsValid(string nationalNumber)
        {
            return nationalNumber.IsValidNationalCode();
        }
    }
}