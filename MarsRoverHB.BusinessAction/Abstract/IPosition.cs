using MarsRoverHB.BusinessAction.Model;
using System;
using System.Collections.Generic;

namespace MarsRoverHB.BusinessAction.Abstract
{
    public interface IPosition
    {
        public Direction TurnRight(Direction direction);
        public Direction TurnLeft(Direction direction);
        public Point GoStraight(int X, int Y, Direction direction);
    }
}
