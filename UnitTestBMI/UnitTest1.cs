using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;
using System.Diagnostics.CodeAnalysis;

namespace BMIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
	[ExcludeFromCodeCoverage]
	[TestMethod]
		public void TestMethod1()
		{
			BMI bmi = new BMI() {WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10};
			Assert.AreEqual(bmi.BMICategory, BMICategory.Normal);
		}
    }
}
