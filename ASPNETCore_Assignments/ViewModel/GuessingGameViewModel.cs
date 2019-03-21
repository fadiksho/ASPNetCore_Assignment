namespace ASPNETCore_Assignments.ViewModel
{
	public class GuessingGameViewModel
	{
		public GuessingGameViewModel(int guessedNumber, int tryCount)
		{
			this.TryCount = tryCount;
			this.GuessedNumber = guessedNumber;
		}

		public string Message { get; private set; }

		public int TryCount { get; private set; }

		public GameResult GameResult { get; private set; }

		public int GuessedNumber { get; private set; }

		public void CheckAnswer(int correctNumber)
		{
			if (this.GuessedNumber == correctNumber)
			{
				this.GameResult = GameResult.Succeed;
				this.Message = "You guessed it successfully";
			}
			else
			{
				this.GameResult = GameResult.Faild;
				this.Message = $"you faild guessing try a {(this.GuessedNumber > correctNumber ? "smaller" : "larger")} number";
			}
		}
	}

	public enum GameResult
	{
		Succeed,
		Faild
	}
}
