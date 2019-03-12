using ASPNETCore_Assignments.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ASPNETCore_Assignments.Controllers
{
	public class GuessingGameController : Controller
	{
		private Random _rand;

		public GuessingGameController()
		{
			_rand = new Random();
		}
		public IActionResult Index()
		{
			HttpContext.Session.SetInt32("TryTimes", 0);
			HttpContext.Session.SetInt32("RandomNamber", _rand.Next(1, 100));

			var highScore = Request.Cookies["highScore"];

			return View();
		}

		[HttpPost]
		public IActionResult Index(int guesingNumber)
		{
			if (HttpContext.Session.GetInt32("TryTimes") != null)
			{
				var tryies = (int)HttpContext.Session.GetInt32("TryTimes") + 1;
				HttpContext.Session.SetInt32("TryTimes", tryies);
				var randomNumber = (int)HttpContext.Session.GetInt32("RandomNamber");
				var model = new GuessingGameModel(tryies);
				if (randomNumber == guesingNumber)
				{
					model.GameResult = GameResult.Succeed;
					model.Message = "You guessed it successfully";
					HttpContext.Session.SetInt32("TryTimes", 0);
					HttpContext.Session.SetInt32("RandomNamber", _rand.Next(1, 100));
					var highScore = Request.Cookies["highScore"];
					if (string.IsNullOrWhiteSpace(highScore))
						highScore = tryies.ToString();
					else
					{
						highScore += $",{tryies}".Trim();
						highScore = string.Join(',', Array.ConvertAll(highScore.Split(','), int.Parse).Distinct().OrderBy(c => c).Take(5));

					}
						
					Response.Cookies.Append("highScore", highScore, new CookieOptions()
					{
						Expires = DateTimeOffset.Now.AddDays(1)
					});

				}
				else
				{
					model.GameResult = GameResult.Faild;
					model.Message += $"you faild guessing try a {(guesingNumber > randomNumber ? "smaller" : "larger")} number";
				}
				return View(model);
			}
			return View();
		}
	}
}
