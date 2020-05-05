using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListGroup : ContentPage
    {
        private List<GameList> _listOfGames;
        public List<GameList> ListOfGamex { get { return _listOfGames; } set { _listOfGames = value; base.OnPropertyChanged(); } }


        public ListGroup()
        {
            InitializeComponent();
            var dList = new GameList()
            {
                new Game() { Name = "Dota2", Mod = "MOBA" },
                new Game() { Name  = "Left4Dead", Mod = "Survival" }
            };
            dList.Heading = "S";

            var rList = new GameList()
            {
                new Game() { Name = "Smite", Mod = "MOBA" }
            };
            rList.Heading = "R";

            var pList = new GameList()
            {
                new Game() { Name = "Resident Evil", Mod = "Survival" }
            };
            pList.Heading = "Personality";

            var list = new List<GameList>()
            {
                dList,
                rList,
                pList
            };
            Console.WriteLine(list);
            ListOfGamex = list;
        }
    }
}