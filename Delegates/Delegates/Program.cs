using Delegates.Actions;
using Delegates.Score;
using Delegates.VideoEncoder;
using System;

namespace Delegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VideoEncoderManager.EncodeVideos(); // nice sample from "Programming with Mosh"

            ScoreManager.ManageScores();

            var tookDamage = new Character() { Defense = 5, Attack = 3, Name = "User 1" };
            var DealtDamage = new Character() { Defense = 5, Attack = 6, Name = "User 2" };

            tookDamage.DamageTakenEventHandler += DisplayDamageTaken;

            tookDamage.Combat(DealtDamage);

            void DisplayDamageTaken(object sender, ActionEvent e)
            {
                var took = (Character)sender;
                Console.WriteLine($"{took.Name} took damage from {e.Responsible.Name}. Action: {e.ActionName}");
            }
        }
    }
}