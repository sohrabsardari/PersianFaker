using System;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Threading;
using FsCheck.Xunit;
using NFluent;
using Xunit;
using Check = NFluent.Check;

namespace PersianFaker.Tests
{
    public class NameTests
    {
        [Property(MaxTest = 1)]
        public void firstName_should_create_new_firstname_from_resource_file()
        {
            var name = Name.Firstname();

            var nameExistOnResourceFile = Resources.Name.Firstname.Contains(name);

            Check.That(Regex.IsMatch(name, @"\w")).IsTrue();
            Check.That(nameExistOnResourceFile).IsTrue();
        }

        [Fact]
        public void lastname_should_create_new_lastname_from_resource_file()
        {

            var lastname = Name.LastName();


            var lastnameExistOnResourceFile = Resources.Name.Lastname.Contains(lastname);

            Check.That(Regex.IsMatch(lastname, @"\w")).IsTrue();
            Check.That(lastnameExistOnResourceFile).IsTrue();
        }

        [Fact]
        public void fullname_should_create_name_with_firstName_and_lastname()
        {

            var fullname = Name.FullName();
            var name = fullname.Split(" ")[0];
            var lastname = fullname.Split(" ")[1];

            var nameExistOnResourceFile = Resources.Name.Firstname.Contains(name);
            var lastnameExistOnResourceFile = Resources.Name.Lastname.Contains(lastname);


            Check.That(Regex.IsMatch(fullname, @"\w \w"));
            Check.That(nameExistOnResourceFile).IsTrue();
            Check.That(lastnameExistOnResourceFile).IsTrue();



        }
    }
}