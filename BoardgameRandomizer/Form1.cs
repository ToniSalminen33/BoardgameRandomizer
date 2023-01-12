using Kirjastot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BoardgameRandomizer
{
    public partial class Form1 : Form
    {
        List<PlayerModel> players = new List<PlayerModel>();
        List<SelectedModel> selectedPlayers = new List<SelectedModel>();
        public Form1()
        {
            InitializeComponent();

            LoadPlayerList();
            
        }

        private void LoadPlayerList()
        {
            players = SqliteDataAccess.LoadPlayers();
            selectedPlayers = SqliteDataAccess.LoadSelectedPlayers();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            PlayerListBox.DataSource = null;
            PlayerListBox.DataSource = players;
            SelectedPlayerListBox.DataSource = null;
            SelectedPlayerListBox.DataSource = selectedPlayers;
            PlayerListBox.DisplayMember = "FullName";
            SelectedPlayerListBox.DisplayMember = "FullName";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadPlayerList();
        }

        private void PlayerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlayerModel player = PlayerListBox.SelectedItem as PlayerModel;
            SqliteDataAccess.SelectPlayer(player);
            LoadPlayerList();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            List<PlayerModel> resetoitavat = players;
            SqliteDataAccess.ResetSelected(resetoitavat);
            LoadPlayerList();
        }

        private void SelectedPlayerListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectedModel selectedPlayer = SelectedPlayerListBox.SelectedItem as SelectedModel;
            SqliteDataAccess.UnSelectPlayer(selectedPlayer);
            LoadPlayerList();
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreatePlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayer frm = new AddPlayer();
            frm.Show();
        }

        private void RemoveSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            PlayerModel player = PlayerListBox.SelectedItem as PlayerModel;
            SqliteDataAccess.RemovePlayer(player);
            LoadPlayerList();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameSession frm = new GameSession();
            frm.Show();
        }
    }
}
