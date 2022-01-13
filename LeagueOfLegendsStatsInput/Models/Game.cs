using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsStatsInput.Models
{

    public class Game
    {
        public string Role { get; set; }
        public string PlayedAs { get; set; }
        public string Againts { get; set; }
        public string KDA { get; set; }
        public string CS { get; set; }
        public string TeamScore { get; set; }
        public string KP { get; set; }
        public string Duration { get; set; }
        public string Result { get; set; }
        public string FirstBlood { get; set; }
        public string Date { get; set; }
        public string TimeAfterMatch { get; set; }
        public string RiftSide { get; set; }
        public string Herald { get; set; }
        public string Drakes { get; set; }
        public string Baron { get; set; }
        public string Elder { get; set; }
        public string DMGDealt { get; set; }
        public string DMGTaken { get; set; }
        public string RageQuit { get; set; }

        public Game()
        {
            Role = string.Empty;
            PlayedAs = string.Empty;
            Againts = string.Empty;
            KDA = string.Empty;
            CS = string.Empty;
            TeamScore = string.Empty;
            KP = string.Empty;
            Duration = string.Empty;
            Result = string.Empty;
            FirstBlood = string.Empty;
            Date = string.Empty;
            TimeAfterMatch = string.Empty;
            RiftSide = string.Empty;
            Herald = string.Empty;
            Drakes = string.Empty;
            Baron = string.Empty;
            Elder = string.Empty;
            DMGDealt = string.Empty;
            DMGTaken = string.Empty;
            RageQuit = string.Empty;
        }

    }
}