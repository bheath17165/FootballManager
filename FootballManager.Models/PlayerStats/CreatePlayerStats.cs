﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Models.PlayerStats
{
    public class CreatePlayerStats
    {
        public int PlayerStatsID { get; set; }

        [Required]
        public int PlayerID { get; set; }
        [Required]
        public int PassingYards { get; set; }
        [Required]
        public int PassingTouchdowns { get; set; }
        [Required]
        public int InterceptionThrown { get; set; }
        [Required]
        public int RushingYards { get; set; }
        [Required]
        public int RushingAttempts { get; set; }
        [Required]
        public int RushingTouchDowns { get; set; }
        [Required]
        public int ReceivingYards { get; set; }
        [Required]
        public int Catches { get; set; }
        [Required]
        public int ReceivingTouchDowns { get; set; }
        [Required]
        public int Fumbles { get; set; }
        [Required]
        public int Tackles { get; set; }
        [Required]
        public double Sacks { get; set; }
        [Required]
        public int Interceptions { get; set; }
        [Required]
        public int ForcedFumbles { get; set; }
        [Required]
        public int FumbleRecovery { get; set; }
        [Required]
        public int Safety { get; set; }
        [Required]
        public int BlockedKick { get; set; }
        [Required]
        public int ReturnTouchDown { get; set; }
    }
}
