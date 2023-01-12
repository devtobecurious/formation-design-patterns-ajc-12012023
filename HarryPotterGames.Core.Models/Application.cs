using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterGames.Core.Models
{
    public class Application
    {
        #region Singleton
        private static readonly Application singleton = new Application();
        private Application() { }
        public static Application Instance => singleton;
        #endregion

        #region Fields
        private readonly List<Game> gameList = new();
        #endregion

        #region Properties
        public List<Game> GameList => gameList;
        #endregion
    }
}
