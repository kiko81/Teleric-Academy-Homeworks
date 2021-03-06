﻿namespace Battlefield.Logic.Engines
{
    using Battlefield.Logic.OutputProviders;
    using Battlefield.Logic.Players;

    /// <summary>
    /// An engine class .
    /// </summary>
    public class ConsoleEngine : IEngine
    {
        private const string ChainReactionOn = "Chain Reaction ON";
        private const string BombInversionOn = "Bomb Inversion ON";
        private const string CurrentPlayerAnnouncement = "\n-#- {0}'s turn -#-";

        private IPlayer player1;
        private IPlayer player2;

        public ConsoleEngine(IPlayer player1, IPlayer player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public bool IsGameOver { get; set; }

        /// <summary>
        /// Starting, changing and finishing game.
        /// </summary>
        /// <param name="currentPlayer">The player on turn.</param>
        public void Start(IPlayer currentPlayer)
        {
            while (!this.IsGameOver)
            {
                ConsoleOutput.Print(string.Format(CurrentPlayerAnnouncement, currentPlayer.Name));
                ConsoleOutput.Print(currentPlayer.Field.ToString());

                this.UpdateGame(currentPlayer);

                if (!this.IsGameOver)
                {
                    currentPlayer = this.ChangePlayer(currentPlayer);                    
                }
            }

            ConsoleOutput.PrintWinningMessage(currentPlayer.Name, currentPlayer.ShotCount);
        }

        /// <summary>
        /// Game update method (template).
        /// </summary>
        /// <param name="currentPlayer">The player currently playing.</param>
        private void UpdateGame(IPlayer currentPlayer)
        {
            while (true)
            {
                if (currentPlayer.ChainReactionEnabled)
                {
                    ConsoleOutput.Print(ChainReactionOn);
                }

                if (currentPlayer.Field.InvertExplosion)
                {
                    ConsoleOutput.Print(BombInversionOn);
                }

                var minesDetonated = currentPlayer.TakeAShot();

                currentPlayer.ShotCount++;
                currentPlayer.NumberOfBombs -= minesDetonated;

                ConsoleOutput.Print(currentPlayer.Field.ToString());
                ConsoleOutput.PrintRoundSummary(minesDetonated);

                if (currentPlayer.NumberOfBombs == 0)
                {
                    this.IsGameOver = true;
                    return;
                }

                if (minesDetonated == 0 || minesDetonated > 7)
                {
                    return;
                }

                if (minesDetonated == 4)
                {
                    currentPlayer.Field.InvertExplosion = true;
                }

                if (minesDetonated > 4)
                {
                    currentPlayer.ChainReactionEnabled = true;
                    return;
                }

                ConsoleOutput.Print(string.Format(CurrentPlayerAnnouncement, currentPlayer.Name));
            }
        }

        /// <summary>
        /// Swapping current player with another.
        /// </summary>
        /// <param name="currentPlayer">The player currently playing.</param>
        /// <returns>The other player.</returns>
        private IPlayer ChangePlayer(IPlayer currentPlayer)
        {
            return currentPlayer == this.player1 ? this.player2 : this.player1;
        }
    }
}