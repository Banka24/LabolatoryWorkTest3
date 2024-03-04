using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MyLib.Lab3;

namespace MyLibTest
{
    [TestClass]
    public class Lab3Test
    {
        [TestMethod]
        public void OddDigits_Entry234_Return1()
        {
            const int number = 234;
            const int expected = 1;
            var actual = OddDigits(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddDigits_Entry680_Return0()
        {
            const int number = 680;
            const int expected = 0;
            var actual = OddDigits(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddDigits_Entry357_Return3()
        {
            const int number = 357;
            const int expected = 3;
            var actual = OddDigits(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumbers_Entry1234567890()
        {
            const string number = "1234567890";
            const string expected = "+1(123)456-7890";
            var actual = FormatPhoneNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumbers_EntryAbcd()
        {
            const string number = "Abcd";
            const string expected = "Вы ввели некорректный номер";
            var actual = FormatPhoneNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumbers_EntryWhiteSpace()
        {
            const string number = "";
            const string expected = "Вы ввели пустую строку";
            var actual = FormatPhoneNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTime_Entry151_Return10()
        {
            const int k = 1;
            const int m = 5;
            const int n = 1;

            const double expected = 10;
            var actual = GetTime(k, m, n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetTime_Entry237_Return21()
        {
            const int k = 2;
            const int m = 3;
            const int n = 7;

            const double expected = 21;
            var actual = GetTime(k, m, n);

            Assert.AreEqual(expected, actual);
        }
    }
}
