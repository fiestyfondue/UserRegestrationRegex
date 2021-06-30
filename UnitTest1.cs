using NUnit.Framework;
using REGEX;

namespace UserValidation
{
    public class Tests
    {
        bool firstName;
        bool lastName;
        bool email;
        bool mobile;
        bool password;
        [SetUp]
        public void Setup()
        {
            RegexValidation regex = new RegexValidation();
            firstName = regex.Name("Bruce");
            lastName = regex.Name("Wayne");
            email = regex.Email("Batmobile23@gmail.com");
            mobile = regex.PhoneNo("91 9876843244");
            password = regex.Password("T@pdog24");


        }

        [Test]
        public void Test1()
        {
            if (firstName && lastName && email && mobile && password)
                Assert.Pass("Saved successfully");
            else
                Assert.Fail("Entry failed");
        }
    }
}