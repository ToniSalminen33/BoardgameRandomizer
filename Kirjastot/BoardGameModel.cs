using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjastot
{
    public class BoardGameModel
    {
        public int BoardgameId { get; set; }

        public string BoardgameName { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

    }
}
