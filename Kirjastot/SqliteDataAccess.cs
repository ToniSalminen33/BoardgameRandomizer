using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace Kirjastot
{
    public class SqliteDataAccess
    {
        public static List<PlayerModel> LoadPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PlayerModel>("select * from Players where PickedStatus = 0", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<SelectedModel> LoadSelectedPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SelectedModel>("select * from Players where PickedStatus = 1", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<SelectedModel> Tokenless()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<SelectedModel>("select * from Players where token = 0", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<BoardGameModel> RandomizeBoardgame()
        {
            int nrOfPlayers = LoadSelectedPlayers().Count;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (nrOfPlayers == 2)
                {
                    var output = cnn.Query<BoardGameModel>("select BoardgameName from Boardgames where MinPlayers = 2", new DynamicParameters());
                    return output.ToList();
                }
                else 
                {
                    var output = cnn.Query<BoardGameModel>($"select BoardgameName from Boardgames where MaxPlayers >= {nrOfPlayers}", new DynamicParameters());
                    return output.ToList();
                }
            }
        }

        public static void SavePlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Players (FirstName, LastName) values (@FirstName, @LastName)", player);
            }
        }

        public static void RemovePlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from Players where PlayerId = { player.PlayerId }", player);
            }
        }

        public static void SelectPlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"update Players set PickedStatus = 1 where PlayerId = { player.PlayerId }", player);
            }
        }
        public static void UnSelectPlayer(SelectedModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"update Players set PickedStatus = 0 where PlayerId = { player.PlayerId }", player);
            }
        }

        public static void ResetSelected(List<PlayerModel> player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"update Players set PickedStatus = 0", player);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
