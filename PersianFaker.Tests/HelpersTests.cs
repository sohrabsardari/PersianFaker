using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using PersianFaker.Resources;
using PersianFaker.Resources.Helpers;
using PersianFaker.Resources.Helpers.Constants;
using Xunit;

namespace PersianFaker.Tests
{
    public class HelpersTests
    {
        [Fact]
        public void string_should_separate_with_semicolon_when_use_separator()
        {
            var stringValue = "iran;tehran";
            var expectedValue = new string[] {"iran","tehran"};

            var result = stringValue.Split(Separator.SeparateWithSemicolon);

            Check.That(result).Equals(expectedValue);
        }

        [Fact]
        public void Random_should_throw_when_list_is_empty()
        {
            var emptyList = new string[]{};

            Action randomItemInList = () =>  emptyList.Random();

            Check.ThatCode(randomItemInList).Throws<Exception>().WithMessage(ErrorConstants.ListMustContainsAtLeastOneItem);
        }
    }
}
