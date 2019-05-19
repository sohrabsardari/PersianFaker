using System;
using System.Collections.Generic;
using System.Text;
using PersianFaker.Resources;
using PersianFaker.Resources.Helpers;

namespace PersianFaker
{
    public static class Name
    {
        public static string Firstname()
        {
            return Resources.Name.Firstname.Split(Separator.SeparateWithSemicolon).Random().Trim();
        }

        public static string LastName()
        {
            return Resources.Name.Lastname.Split(Separator.SeparateWithSemicolon).Random().Trim();
        }

        public static string FullName()
        {
            var firstname = Resources.Name.Firstname.Split(Separator.SeparateWithSemicolon).Random().Trim();
            var lastname = Resources.Name.Lastname.Split(Separator.SeparateWithSemicolon).Random().Trim();
            return firstname + " " + lastname;
        }
    }
}
