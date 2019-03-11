namespace ASPNETCore_Assignments.Model
{
	public class GuessingGameModel
	{
		public GuessingGameModel(int tryCount)
		{
			this.TryCount = tryCount;
		}

		public string Message { get; set; }

		public int TryCount { get; private set; }

		public GameResult GameResult { get; set; }
	}
}
