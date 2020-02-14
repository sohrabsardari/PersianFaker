using System;

namespace PersianFaker.Resources.Helpers.NationalNumber
{
    public class NationalNumberGenerator
    {
        public static string CreateNew()
        {
            char[] result = new char[10];
            long sumOfNumbers = 0;

            for (int i = 10; i > 1; i--)
            {
                var number = new Random().Next(0, 9);
                result[10 - i] = char.Parse(number.ToString());
                sumOfNumbers += (number * i);
            }
            long baghimande = (sumOfNumbers) % 11;

            long addadeAkhar = 0;
            if (baghimande < 2)
            {
                addadeAkhar = baghimande;

                result[9] = char.Parse(addadeAkhar.ToString());
                return new string(result);
            }
            else
            {
                addadeAkhar = 11 - baghimande;

                result[9] = char.Parse(addadeAkhar.ToString());

                return new string(result);
            }
        }
    }
}