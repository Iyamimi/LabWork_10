using LabLibrary;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Password_PasswordValidation_True()
        {
            string pass = "12345678W";

            bool result = Password.PasswordValidation(pass);

            Assert.True(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_AllButShort()
        {
            string pass = "123Q";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_ShortAndNoLatSymbol()
        {
            string pass = "1234";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_ShortAndNoDigit()
        {
            string pass = "Pass";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_NoDigit()
        {
            string pass = "PasswordW";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_NoLatSymbol()
        {
            string pass = "1234567890122334";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }

        [Fact]
        public void Password_PasswordValidation_False_Nofing()
        {
            string pass = "";

            bool result = Password.PasswordValidation(pass);

            Assert.False(result);
        }
    }
}
