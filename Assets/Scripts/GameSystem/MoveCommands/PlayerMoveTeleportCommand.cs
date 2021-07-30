﻿using BoardSystem;
using GameSystem.Models;
using GameSystem.Utils;
using MoveSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.MoveCommands
{
    [MoveCommand(Name)]
    public class PlayerMoveTeleportCommand : AbstractMoveCommand
    {
        public const string Name = "TeleportMove";
        public override List<Tile> Tiles(Board<Piece, Card> board, Card card)
        {
            var validtiles = new List<Tile>();

            return validtiles;
        }
    }
}
