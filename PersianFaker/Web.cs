using PersianFaker.Resources.Helpers;

namespace PersianFaker
{
    public static class Web
    {
        public static string UserName()
        {
            return Name.LatinFirstName() + StaticRandom.GetNextRandomNumber(999);
        }

        public static string UserName(string name, int maxStringLength = 30)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = Name.LatinFirstName();
            }
            if (maxStringLength - name.Length > 3)
            {
                return name + StaticRandom.GetNextRandomNumber(999);
            }
            return name;
        }

        public static string Email()
        {
            return Name.LatinFirstName() + Name.LatinLastName() +"@" +
                   Resources.Email.PublicEmails.Split(Separator.SeparateWithSemicolon).Random().Trim();
        }

        public static string Email(string name)
        {
            return EmailHelper.GetPublicEmailFromResourceFile(name);
        }
    }
}