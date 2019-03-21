using ASPNETCore_Assignments.ViewModel;
using Xunit;

namespace ASPNETCore_Assignments_Test.ViewModel
{
	public class GuessingGameViewModelTesting
	{
		[Fact]
		public void GameResultShouldBeFailureWhenGuessedNumberNotEqualTheAnswer()
		{
			// Arrange
			var model = new GuessingGameViewModel(20, 1);
			// Act
			model.CheckAnswer(40);
			// Assert
			Assert.Equal(GameResult.Faild, model.GameResult);
		}
		[Fact]
		public void GameResultShouldBeSuccessWhenGuessedNumberEqualTheAnswer()
		{
			// Arrange
			var model = new GuessingGameViewModel(20, 1);
			// Act
			model.CheckAnswer(20);
			// Assert
			Assert.Equal(GameResult.Succeed, model.GameResult);
		}
	}
}
