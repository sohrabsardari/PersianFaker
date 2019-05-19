using System;
using System.Collections.Generic;
using System.Linq;
using PersianFaker.Resources.Helpers.Constants;

namespace PersianFaker.Resources.Helpers
{
    public static class RandomGenerator
    {
        public static string Random(this string[] list)
        {
            if(!list.Any())
                throw new Exception(ErrorConstants.ListMustContainsAtLeastOneItem);
            return list[StaticRandom.GetNextRandomNumber(list.Length)];
        }
    }
}