using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossTravailInterfaces
{
    internal class Salarie
    {
        public event Action<FichierDeCode> TravailFini;

        private readonly ILogger loggerParDefaut;

        public Salarie(ILogger loggerParDefaut)
        {
            this.loggerParDefaut = loggerParDefaut;
            if (this.loggerParDefaut == null)
            {
                throw new ArgumentNullException(nameof(loggerParDefaut));
            }
        }

        public void Travailler(ILogger? logger = null)
        {
            ILogger vraiLogger = this.loggerParDefaut;

            if (logger != null)
            {
                vraiLogger = logger;
            }

            // vraiLogger ??= logger;

            vraiLogger.Log("Moi je travaille bien voyons !");

            //////////
            ///
            this.TravailFini?.Invoke(new FichierDeCode() { Content = "<html><head /> </html>" });
        }
    }
}
