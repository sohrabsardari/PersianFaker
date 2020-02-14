using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PersianFaker.Resources.Helpers.NationalNumber
{
    public static class NationalNumberValidator
    {
        public static bool IsValidNationalCode(this string nationalCode)
        {
            if (string.IsNullOrEmpty(nationalCode))
                throw new Exception("لطفا کد ملی را صحیح وارد نمایید");
            if (nationalCode.Length != 10)
                throw new Exception("طول کد ملی باید ده کاراکتر باشد");
            if (!new Regex("\\d{10}").IsMatch(nationalCode))
                throw new Exception("کد ملی تشکیل شده از ده رقم عددی می\x200Cباشد؛ لطفا کد ملی را صحیح وارد نمایید");
            if (((IEnumerable<string>)new string[10]
            {
                "0000000000",
                "1111111111",
                "2222222222",
                "3333333333",
                "4444444444",
                "5555555555",
                "6666666666",
                "7777777777",
                "8888888888",
                "9999999999"
            }).Contains<string>(nationalCode))
                return false;
            char[] charArray = nationalCode.ToCharArray();
            int num1 = Convert.ToInt32(charArray[0].ToString()) * 10;
            int num2 = Convert.ToInt32(charArray[1].ToString()) * 9;
            int num3 = Convert.ToInt32(charArray[2].ToString()) * 8;
            int num4 = Convert.ToInt32(charArray[3].ToString()) * 7;
            int num5 = Convert.ToInt32(charArray[4].ToString()) * 6;
            int num6 = Convert.ToInt32(charArray[5].ToString()) * 5;
            int num7 = Convert.ToInt32(charArray[6].ToString()) * 4;
            int num8 = Convert.ToInt32(charArray[7].ToString()) * 3;
            int num9 = Convert.ToInt32(charArray[8].ToString()) * 2;
            int int32 = Convert.ToInt32(charArray[9].ToString());
            int num10 = (num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9) % 11;
            if (num10 < 2 && int32 == num10)
                return true;
            if (num10 >= 2)
                return 11 - num10 == int32;
            return false;
        }
    }
}