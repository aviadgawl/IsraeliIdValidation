using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidationLibraryTests
{
    [TestClass]
    public class IsValidIsraeliIdNumberTests
    {
        [TestMethod]
        public void ShouldReturnValid_InputValidId_223667577()
        {
            Assert.IsTrue(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("223667577"));
        }

        [TestMethod]
        public void ShouldReturnValid_InputValidId_112276()
        {
            Assert.IsTrue(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("112276"));
        }

        [TestMethod]
        public void ShouldReturnValid_InputValidId_000112276()
        {
            Assert.IsTrue(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("000112276"));
        }

        [TestMethod]
        public void ShouldReturnValid_InputValidId_7390002199()
        {
            Assert.IsTrue(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("7390002199"));
        }

        [TestMethod]
        public void ShouldReturnValid_InputValidId_07390002199()
        {
            Assert.IsTrue(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("07390002199"));
        }

        [TestMethod]
        public void ShouldReturnNotValid_InputNotValidId_0030175337()
        {
            Assert.IsFalse(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("0030175337"));
        }

        [TestMethod]
        public void ShouldReturnNotValid_InputNotValidId_30175337()
        {
            Assert.IsFalse(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("30175337"));
        }

        [TestMethod]
        public void ShouldReturnNotValid_InputNotValidId_7390002192()
        {
            Assert.IsFalse(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("7390002192"));
        }

        [TestMethod]
        public void ShouldReturnNotValid_InputNotValidId_07390002192()
        {
            Assert.IsFalse(IsraeliIdValidation.Validation.IsValidIsraeliIdNumber("07390002192"));
        }
    }
}
