using ASPNETCore_Assignments.Model;

namespace ASPNETCore_Assignments.helpers
{
	public class TemperatureConverter
	{
		public static float ConvertTemperature(float temperature, MeasurementUnit unit)
		{
			if (unit == MeasurementUnit.Celsius)
			{
				return (temperature - 32) * 5 / 9;
			}
			else
			{
				return (temperature * 9 / 5) + 32;
			}
		}
	}
}
