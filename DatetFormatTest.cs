using NUnit.Framework;

namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChangeFormat_ShouldBeYMD()
        {
            //Arrange
            string actualT1 = "16/11/1999";
            string expectedT1 = "1999-11-16";

            //Act - Assert
            Assert.AreEqual(expectedT1, Library.DateFormat.ChangeFormat(actualT1));
        }

        [Test]
        public void AmericanOrder_ShouldBeMDY()
        {
            //Arrange
            string actualT2 = "16/11/1999";
            string expectedT2 = "11-16-1999";

            //Act - Assert
            Assert.AreEqual(expectedT2, Library.NewFormat.AmericanOrder(actualT2));
        }
    }
}