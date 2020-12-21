using MarsRoverHB.BusinessAction.Abstract;
using MarsRoverHB.BusinessAction.Model;
using System;
using System.Collections.Generic;

namespace MarsRoverHB.BusinessAction
{
    public abstract class GetPosition : IPosition
    {
        public abstract Point GetLastPosition(List<int> matrix, Point point, string address);
        public Direction TurnRight(Direction direction)
        {
            switch (direction)
            {
                case Direction.E:
                    direction = Direction.S;
                    break;
                case Direction.S:
                    direction = Direction.W;
                    break;
                case Direction.W:
                    direction = Direction.N;
                    break;
                case Direction.N:
                    direction = Direction.E;
                    break;
                default:
                    break;
            }
            return direction;
        }

        public Direction TurnLeft(Direction direction)
        {
            switch (direction)
            {
                case Direction.E:
                    direction = Direction.N;
                    break;
                case Direction.S:
                    direction = Direction.E;
                    break;
                case Direction.W:
                    direction = Direction.S;
                    break;
                case Direction.N:
                    direction = Direction.W;
                    break;
                default:
                    break;
            }
            return direction;
        }

        public Point GoStraight(int X, int Y, Direction direction)
        {
            Point point = new Point();
            switch (direction)
            {
                case Direction.E:
                    X += 1;
                    break;
                case Direction.S:
                    Y -= 1;
                    break;
                case Direction.W:
                    X -= 1;
                    break;
                case Direction.N:
                    Y += 1;
                    break;
                default:
                    break;
            }
            point.X = X;
            point.Y = Y;
            point.Direction = direction;
            return point;
        }

    }
}
