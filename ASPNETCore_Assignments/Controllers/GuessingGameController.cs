using ASPNETCore_Assignments.ViewModel;
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
			// on every git request reset the game
			ResetGameState();

			return View();
		}

		[HttpPost]
		public IActionResult Index(int guesingNumber)
		{
			if (HttpContext.Session.GetInt32("TryTimes") == null) ResetGameState();

			var tryies = (int)HttpContext.Session.GetInt32("TryTimes") + 1;
			HttpContext.Session.SetInt32("TryTimes", tryies);

			var correctNumberToBeGuessed = (int)HttpContext.Session.GetInt32("correctNumberToBeGuessed");

			var guessingGameModel = new GuessingGameViewModel(guesingNumber, tryies);
			guessingGameModel.CheckAnswer(correctNumberToBeGuessed);
			if (guessingGameModel.GameResult == GameResult.Succeed)
			{
				var highScore = Request.Cookies["highScore"];
				if (string.IsNullOrWhiteSpace(highScore))
					highScore = tryies.ToString();
				else
					highScore += $",{tryies}".Trim();

				// Update and Save the highScore
				highScore = string.Join(',', Array.ConvertAll(highScore.Split(','), int.Parse)
					.Distinct().OrderBy(c => c).Take(5));
				Response.Cookies.Append("highScore", highScore, new CookieOptions()
				{
					Expires = DateTimeOffset.Now.AddDays(1)
				});

				// Reset the game state
				ResetGameState();
			}
			return View(guessingGameModel);
		}

		/// <summary>
		/// Clear server session that hold the game data state
		/// </summary>
		private void ResetGameState()
		{
			HttpContext.Session.SetInt32("TryTimes", 0);
			HttpContext.Session.SetInt32("correctNumberToBeGuessed", _rand.Next(1, 100));
		}
	}
}
