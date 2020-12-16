using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Models;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        BMIViewModel model = new BMIViewModel();
        [TestMethod]
        public void Test_BMI()
        {
            //Arrange
            int currentWeight = 160;
            int height = 71;
            double expected = 23;
            //Act
            double actual = model.calculateBMI(currentWeight, height);
            //Assert
            Assert.AreEqual(expected, actual, 1);
        }

        [TestMethod]
        public void Test_Progress()
        {
            //Arrange
            int currentWeight = 160;
            int goalWeight = 155;
            double expected = 96.875;
            //Act
            double actual = model.calculateProgress(currentWeight, goalWeight);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Category()
        {
            //Arrange
            int bmi = 22;
            string expected = "normal weight";
            //Act
            string actual = model.category(bmi);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
