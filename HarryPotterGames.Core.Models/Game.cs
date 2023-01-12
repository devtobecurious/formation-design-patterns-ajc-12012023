using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGames.Core.Models
{
    public class Game
    {
        #region Fields
        #endregion

        #region Constructors
        public Game(Player player)
        {
            this.CurrentPlayer = player;
        }
        #endregion

        #region Properties
        public Player CurrentPlayer { get; init; }
        #endregion
    }
}
