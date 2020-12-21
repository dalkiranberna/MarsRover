using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverHB.BusinessAction.Model
{
    public class Point : GetPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public override Point GetLastPosition(List<int> matrix, Point point, string address)
        {
            if (point.X < 0 || point.X > matrix[0] || point.Y < 0 || point.Y > matrix[1])
            {
                throw new Exception("You exceeded the matrix size you specified. Matrix size is " + matrix[0] + " x " + matrix[1]);
            }
            else
            {
                foreach (var item in address)
                {
                    switch (item)
                    {
                        case 'R':
                            point.Direction = TurnRight(point.Direction);
                            break;
                        case 'L':
                            point.Direction = TurnLeft(point.Direction);
                            break;
                        case 'M':
                            point = GoStraight(point.X, point.Y, point.Direction);
                            break;
                        default:
                            Console.WriteLine(item + " is a invalid character.");
                            break;
                    }
                }
            }
            return point;
        }
    }
}
