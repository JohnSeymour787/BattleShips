using System;
using System.Collections.Generic;

using SwinGameSDK;

/// <summary>

/// ''' The EndingGameController is responsible for managing the interactions at the end

/// ''' of a game.

/// ''' </summary>

namespace BattleShips
{
	using static UtilityFunctions;
	using static GameController;
	using static HighScoreController;

	static class EndingGameController
	{

		/// <summary>
		///     ''' Draw the end of the game screen, shows the win/lose state
		///     ''' </summary>
		public static void DrawEndOfGame()
		{
			DrawField(ComputerPlayer.PlayerGrid, ComputerPlayer, true);
			DrawSmallField(HumanPlayer.PlayerGrid, HumanPlayer);

			string whatShouldIPrint;
			if (HumanPlayer.IsDestroyed)
				whatShouldIPrint = "YOU LOSE!";
			else
				whatShouldIPrint = "-- WINNER --";

			var toDraw = new Rectangle();
			toDraw.X = 0;
			toDraw.Y = 250;
			toDraw.Width = SwinGame.ScreenWidth();
			toDraw.Height = SwinGame.ScreenHeight();

			SwinGame.DrawText(
				whatShouldIPrint,
				Color.White,
				Color.Transparent,
				GameResources.GameFont("ArialLarge"),
				FontAlignment.AlignCenter,
				toDraw
			);
		}

		/// <summary>
		///     ''' Handle the input during the end of the game. Any interaction
		///     ''' will result in it reading in the highsSwinGame.
		///     ''' </summary>
		public static void HandleEndOfGameInput()
		{
			if (SwinGame.MouseClicked(MouseButton.LeftButton) ||
				SwinGame.KeyTyped(KeyCode.ReturnKey) ||
				SwinGame.KeyTyped(KeyCode.EscapeKey))
			{
				ReadHighScore(HumanPlayer.Score);
				EndCurrentState();
			}
		}
	}
}
