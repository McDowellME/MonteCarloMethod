using System;
using System.Collections.Generic;
using System.Text;

namespace MonteCarloMethod
{
    public struct Coordinates
    {
        public double x;
        public double y;
        public Coordinates(double inputX, double inputY)
        {
            x = inputX;
            y = inputY;
        }

        public Coordinates(Random randomGenerator)
        {
            x = randomGenerator.NextDouble();
            y = randomGenerator.NextDouble();
        }
    }
}
