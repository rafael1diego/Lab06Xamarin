using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab06
{
    public class Game
    {
        public string Name { get; set; }
        public string Mod { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{Name}, {Mod}";
            }
        }
    }

    public class GameList : List<Game>
    {
        public string Heading { get; set; }
        public List<Game> Games => this;
    }


}