using ASPNETCore_Assignments.helpers;
using ASPNETCore_Assignments.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Assignments.Controllers
{
	public class TemperatureController : Controller
	{
		[HttpGet("/FeverCheck")]
		public IActionResult FeverCheck(Temperature temperature)
		{
			if (temperature.TemperatureValue > 0)
			{
				var temperatureInCelsius = temperature.TemperatureValue;
				var isCelsius = true;
				if (temperature.MeasurementUnit == MeasurementUnit.Fahrenheit)
				{
					temperatureInCelsius = TemperatureConverter.ConvertTemperature(temperatureInCelsius, MeasurementUnit.Celsius);
					isCelsius = false;
				}
				
				if (temperatureInCelsius < 37)
					temperature.Message = "You have a hypothermia";
				else if (temperatureInCelsius > 38)
					temperature.Message = "You have a fever";
				else
					temperature.Message = "Your temperature is normal";

				temperature.Message += $" {temperature.TemperatureValue} {(isCelsius ? "Celsius." : "Fahrenheit." )}";
			}
			return View(temperature);
		}
	}
}
