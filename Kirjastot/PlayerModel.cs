using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kirjastot
{
    public class PlayerModel
    {
        public int PlayerId { get; set; }
        public string NickName { get; set; }

        public bool Token { get; set; }

        public bool PickedStatus { get; set; }

        public string FullName
        {
            get
            {
                return $"{NickName} {PickedStatus}";
            }
        }
    }
}
