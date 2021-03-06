﻿using System;
using System.Collections;
using System.Collections.Generic;
using WebServiceDemo.Entities;

namespace WebServiceDemo.Repositories
{
    public interface IPlayerRepository
    {
        public IEnumerable<Player> GetPlayers();
        public Player GetPlayer(int playerId);
    }
}
