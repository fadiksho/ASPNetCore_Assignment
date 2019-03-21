using ASPNETCore_Assignments.helpers;
using ASPNETCore_Assignments.Model;
using Xunit;
namespace ASPNETCore_Assignments_Test.helpers
{
	public class TemperatureConverter_Test
	{
		[Theory]
		[InlineData(0, 32)]
		[InlineData(-10, 14)]
		[InlineData(34, 93.2)]
		[InlineData(37, 98.6)]
		[InlineData(37.8, 100.04)]
		[InlineData(40, 104)]
		public void ConvertTemperatureFromCelsiusToFahrenheit(float inCelesius, float inFahrenheit)
		{
			// Arrange
			// Act
			var expected = TemperatureConverter.ConvertTemperature(inCelesius, MeasurementUnit.Fahrenheit);
			// Assert
			Assert.Equal(expected, inFahrenheit, 2);
		}
		[Theory]
		[InlineData(32, 0)]
		[InlineData(14, -10)]
		[InlineData(93.2, 34)]
		[InlineData(98.6, 37)]
		[InlineData(100.04, 37.8)]
		[InlineData(104, 40)]
		public void ConvertTemperatureFromFahrenheitToCelsius(float inFahrenheit, float inCelesius)
		{
			// Arrange
			// Act
			var expected = TemperatureConverter.ConvertTemperature(inFahrenheit, MeasurementUnit.Celsius);
			// Assert
			Assert.Equal(expected, inCelesius, 2);
		}
	}
}
