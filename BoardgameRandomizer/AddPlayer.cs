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
    public partial class AddPlayer : Form
    {
        List<PlayerModel> players = new List<PlayerModel>();
        List<SelectedModel> selectedPlayers = new List<SelectedModel>();
        public AddPlayer()
        {
            InitializeComponent();

            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            players = SqliteDataAccess.LoadPlayers();
            selectedPlayers = SqliteDataAccess.LoadSelectedPlayers();
        }



        private void CloseAddPlayerForm_Click(object sender, EventArgs e)
        {
            AddPlayer.ActiveForm.Close();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerModel p = new PlayerModel();

            p.NickName = FirstNameTextBox.Text;

            SqliteDataAccess.SavePlayer(p);

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";

            LoadPlayerList();
        }
    }
}
