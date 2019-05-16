namespace Delegates.Score
{
    public static class ScoreManager
    {
        public static void ManageScores()
        {
            PlayerStats[] playerStats = new PlayerStats[]
            {
                new PlayerStats(){Name = "Most Kills Name", Deaths = 5, FlagsCaptured = 5, Kills = 10},
                new PlayerStats(){Name = "Most Flags Name", Deaths = 5, FlagsCaptured = 10, Kills = 5},
                new PlayerStats(){Name = "Less Deaths Name", Deaths = 1, FlagsCaptured = 5, Kills = 5},
                new PlayerStats(){Name = "None", Deaths = 5, FlagsCaptured = 5, Kills = 5},
                new PlayerStats(){Name = "None 2", Deaths = 5, FlagsCaptured = 5, Kills = 5}
            };
            var displayNames = new DisplayPlayerNames();
            displayNames.OnGameOver(playerStats);
        }
    }
}