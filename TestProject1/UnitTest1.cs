using VIN_LIB;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckVIN_IsTrueResultCorrectVIN1()
        {
            Assert.IsTrue(Class1.CheckVIN("4Y1SL65848Z411439"));
        }

        [TestMethod]
        public void CheckVIN_IsTrueResultCorrectVIN2()
        {
            Assert.IsTrue(Class1.CheckVIN("JH4KA7660RC001542"));
        }

        [TestMethod]
        public void CheckVIN_IsTrueResultCorrectVIN3()
        {
            Assert.IsTrue(Class1.CheckVIN("5T4KP41Y923355338"));
        }

        [TestMethod]
        public void CheckVIN_IsTrueResultCorrectVIN4()
        {
            Assert.IsTrue(Class1.CheckVIN("2HNYD28377H522352"));
        }

        [TestMethod]
        public void CheckVIN_IsTrueResultCorrectVIN5()
        {
            Assert.IsTrue(Class1.CheckVIN("1G4GD5EDXBF330171"));
        }

        [TestMethod]
        public void CheckVIN_IsFalseResultCorrectVIN1()
        {
            Assert.IsFalse(Class1.CheckVIN("14W2Q19110X235661"));
        }

        [TestMethod]
        public void CheckVIN_IsFalseResultCorrectVIN2()
        {
            Assert.IsFalse(Class1.CheckVIN("RQD1D2341212121260"));
        }

        [TestMethod]
        public void CheckVIN_IsFalseResultCorrectVIN3()
        {
            Assert.IsFalse(Class1.CheckVIN("IO30122012188601"));
        }

        [TestMethod]
        public void CheckVIN_IsFalseResultCorrectVIN4()
        {
            Assert.IsFalse(Class1.CheckVIN("O0Y88XT201123842"));
        }

        [TestMethod]
        public void CheckVIN_IsFalseResultCorrectVIN5()
        {
            Assert.IsFalse(Class1.CheckVIN("PTY40125413438DE17"));
        }

        [TestMethod]
        public void GetVINCountry_IsNotNullResultVIN()
        {
            string expected = "Не найдено";
            Assert.IsNotNull(expected, Class1.GetVINCountry("null"));
        }
        [TestMethod]
        public void GetVINCountry_EqualResultVINIncorrectSpecialSymbol()
        {
            string expected = "Не найдено";
            Assert.AreEqual(expected, Class1.GetVINCountry(",0_0>"));
        }

        [TestMethod]
        public void GetVINCountry_NotEqualResultVINBigCountSymbol()
        {
            string expected = "Океания";
            Assert.AreNotEqual(expected, Class1.GetVINCountry("uikefjbendkjfb_365"));
        }
        [TestMethod]
        public void GetVINCountry_EqualResultIncorrectVIN1()
        {
            string expected = "Не найдено";
            Assert.AreEqual(expected, Class1.GetVINCountry("vIn"));
        }

        [TestMethod]
        public void GetVINCountry_NotEqualResultIncorrectVIN2()
        {
            string expected = "Азия";
            Assert.AreNotEqual(expected, Class1.GetVINCountry("AsiaVIN"));
        }

    }
}