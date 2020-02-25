namespace PersianFaker.Resources.Helpers
{
    public class EmailHelper
    {
        public static string GetPublicEmailFromResourceFile()
        {
            return Name.LatinFirstName + Name.LatinLastName + "@" +Resources.Email.PublicEmails.Split(Separator.SeparateWithSemicolon).Random().Trim();
        }

        public static string GetPublicEmailFromResourceFile(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return GetPublicEmailFromResourceFile();
            }

            return name + "@" + Resources.Email.PublicEmails.Split(Separator.SeparateWithSemicolon).Random().Trim();
        }
    }
}