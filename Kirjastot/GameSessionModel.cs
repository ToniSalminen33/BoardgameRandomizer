using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjastot
{
    public class GameSessionModel
    {
        public int nrOfPlayers { get; set; }

        public List<PlayerModel> playersInSession { get; set; }
    }
}
