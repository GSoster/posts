using System;

namespace Delegates.Score
{
    public class DisplayPlayerNames
    {
        private delegate int ScoreDelegate(PlayerStats stats);

        public void OnGameOver(PlayerStats[] allPlayerStats)
        {
            string topKills = GetPlayerTopScore(allPlayerStats, stats => stats.Kills);
            Console.WriteLine($"TopKills: {topKills}");
            string topFlags = GetPlayerTopScore(allPlayerStats, stats => stats.FlagsCaptured);
            Console.WriteLine($"TopFlags: {topFlags}");
        }

        private string GetPlayerTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalculator)
        {
            int bestScore = 0;
            string name = string.Empty;
            foreach (var stats in allPlayerStats)
            {
                var score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.Name;
                }
            }
            return name;
        }
    }
}