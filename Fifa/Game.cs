using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    internal class Game
    {
        private Team teamA;
        private Team teamB;
        private Referee referee;
        private List<Referee> assistantReferees;
        private List<Goals> goals;
        private int teamAGoals, teamBGoals;

        public Game()
        {
            teamAGoals = 0;
            teamBGoals = 0;
            assistantReferees = new List<Referee>();
            goals = new List<Goals>();
        }

        public Team TeamA
        {
            get { return teamA; }
            set
            {
                if (value.Players.Count != 11)
                    throw new ArgumentException("Squad must start with 11 players!");
                else
                    teamA = value;
            }
        }

        public Team TeamB
        {
            get { return teamB; }
            set
            {
                if (value.Players.Count != 11)
                    throw new ArgumentException("Squad must start with 11 players!");
                else
                    teamB = value;
            }
        }

        public Referee Referee
        {
            get { return referee; }
            set { referee = value; }
        }

        public List<Referee> AssistantReferees
        {
            get { return assistantReferees; }
        }

        public List<Goals> Goals
        {
            get { return goals; }
        }

        public string GameResult()
        {
            foreach (var goal in goals)
            {
                if (TeamA.Players.Contains(goal.Player))
                    teamAGoals++;
                else if (TeamB.Players.Contains(goal.Player))
                    teamBGoals++;
            }
            return $"The result is: {teamAGoals} - {teamBGoals}";
        }

        public string Winner()
        {
            if (teamAGoals > teamBGoals)
                return "Team A";
            else if (teamAGoals == teamBGoals)
                return "Draw";
            else
                return "Team B";
        }
    }
}
