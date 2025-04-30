using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldApp.Tests
{
    [TestClass]
    public class HelloWorldAppTest
    {
        [TestMethod]
        public void TestHelloWorldOutput()
        {
            // Arrange
            var expectedOutput = "Hello, World!";

            // Act
            var actualOutput = HelloWorldApp.GetGreeting();

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput, "The greeting message is not as expected.");
        }

        [TestMethod]
        public void TestGreetingNotNullOrEmpty()
        {
            // Act
            var actualOutput = HelloWorldApp.GetGreeting();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(actualOutput), "The greeting message should not be null or empty.");
        }
    }
}