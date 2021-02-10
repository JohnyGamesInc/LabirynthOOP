﻿using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public interface IEnemy : IEnemyMove
    {
        event Action<int> OnTriggerEnterChange;
    }
}