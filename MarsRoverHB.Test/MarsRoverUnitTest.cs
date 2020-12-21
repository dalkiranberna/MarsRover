using MarsRoverHB.BusinessAction.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverHB.Test
{
    public class MarsRoverUnitTest
    {
        [Theory]
        [InlineData(3, 8, "S", "LMRMM")]
        public void GetLastPosition(int xPoint, int yPoint, string direction, string address)
        {
            // Arrenge
            Point point = new Point();
            point.X = xPoint;
            point.Y = yPoint;
            point.Direction = (Direction)Enum.Parse(typeof(Direction), direction);
            var matrix = new List<int>() { 5, 5 };

            // Act
            Action act = () => point.GetLastPosition(matrix, point, address);

            // Assert
            Assert.Throws<Exception>(act);
        }

        [Theory]
        [InlineData(3, 3, "E", "MMRMMRMRRM")]
        public void GetLastPosition_MMRMMRMRRMand33E_51E(int xPoint, int yPoint, string direction, string address)
        {
            // Arrenge
            Point point = new Point();
            point.X = xPoint;
            point.Y = yPoint;
            point.Direction = (Direction)Enum.Parse(typeof(Direction), direction);
            var matrix = new List<int>() { 5, 5 };

            // Act
            var result = point.GetLastPosition(matrix, point, address);
            var actual = result.X + " " + result.Y + " " + result.Direction;

            // Assert
            Assert.Equal("5 1 E", actual);
        }

        [Theory]
        [InlineData(1, 2, "N", "LMLMLMLMM")]
        public void GetLastPosition_LMLMLMLMMand12N_13N(int xPoint, int yPoint, string direction, string address)
        {
            // Arrenge
            Point point = new Point();
            point.X = xPoint;
            point.Y = yPoint;
            point.Direction = (Direction)Enum.Parse(typeof(Direction), direction);
            var matrix = new List<int>() { 5, 5 };

            // Act
            var result = point.GetLastPosition(matrix, point, address);
            var actual = result.X + " " + result.Y + " " + result.Direction;

            // Assert
            Assert.Equal("1 3 N", actual);
        }
    }
}
