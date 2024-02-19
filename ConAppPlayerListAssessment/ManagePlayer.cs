using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPlayerListAssessment
{
    public class ManagePlayer
    {
        private List<Player> players;

        public ManagePlayer() 
        { 
            //Initialize the list of players.

            players = new List<Player>();
            {
                new Player { Id = 1, Name = "Rashmi", Age = 23 };
                new Player { Id = 2, Name = "Priya", Age = 24 };
            };
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public Player? GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
        }


    }
}
