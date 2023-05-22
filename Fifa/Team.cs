using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    internal class Team
    {
        private List<FootballPlayer> players;
        private Coach coach;

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            if (players.Count < 11 || players.Count > 22)
                throw new ArgumentException("Players count must be between 11 and 22. ");
            else
                this.players = players;
        }

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public List<FootballPlayer> Players
        {
            get { return players; }
        }

        public double AverageAge()
        {
            return Math.Floor(players.Average(x => x.Age));
        }
    }
}
