using Kirjastot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardgameRandomizer
{
    public partial class GameSession : Form
    {
        List<PlayerModel> players = new List<PlayerModel>();
        List<SelectedModel> selectedPlayers = new List<SelectedModel>();
        List<SelectedModel> tokenlessPlayers = new List<SelectedModel>();
        List<BoardGameModel> boardGames = new List<BoardGameModel>();
        int k = 0;
        string[] usedBoardgame = new string[100];
        Random randomBoardgame = new Random();
        
        public GameSession()
        {
            InitializeComponent();
            LoadBoardgames();
            LoadPlayerList();
        }
        private void LoadPlayerList()
        {
            players = SqliteDataAccess.LoadPlayers();
            selectedPlayers = SqliteDataAccess.LoadSelectedPlayers();
            tokenlessPlayers = SqliteDataAccess.Tokenless();

            WireUpPeopleList();
        }
        private void LoadBoardgames()
        {
            boardGames = SqliteDataAccess.RandomizeBoardgame();
        }

        private void WireUpPeopleList()
        {
            PlayersWithTokenListBox.DataSource = null;
            PlayersWithTokenListBox.DataSource = selectedPlayers;
            PlayersWithTokenListBox.DisplayMember = "FullName";
            if (PlayersWithTokenListBox.Items.Contains(tokenlessPlayers))
            {
                PlayersWithTokenListBox.Items.Remove(tokenlessPlayers);
            }
        }
        private void BoardgameRollButton_Click(object sender, EventArgs e)
        {
            int randomIndex = randomBoardgame.Next(boardGames.Count);
            string boardGame = boardGames[randomIndex].BoardgameName.ToString();
            foreach (var games in boardGames)
            {
                if (usedBoardgame.Contains(boardGame))
                {
                    break;
                }
            }
            usedBoardgame[k] = boardGame;
            k++;
            BoardgameLabel.Text = boardGame;


        }
    }
}
