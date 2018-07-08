//From https://github.com/exceptionnotfound/BattleshipModellingPractice
using System;
using System.ComponentModel;
using blazorpong.Shared.Helpers;

namespace blazorpong.Shared.GameObjects
{
    public class Ball
    {
        public Coordinates Coordinates { get; private set; }

        public Ball(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }

        public void Move()
        {

        }
    }
}
