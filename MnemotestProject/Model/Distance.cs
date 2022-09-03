using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MnemotestProject.Model
{
    public class Distance
    {
        public int[,] DistanceMatrix { get; set; }
        public int[] DistanceCount { get; set; }
        public List<Point>[] DistanceCoordinates { get; set; }
        private int maxDistance = 0;
        private Point startPoint;

        private readonly int size;

        public Distance(int size, Point p)
        {
            this.size = size;
            startPoint = p;
            DistanceMatrix = new int[size, size];
            DistanceCount = new int[(size * 2) - 1];
            DistanceCoordinates = new List<Point>[(size * 2) - 1];
            for (int i = 0; i < DistanceCoordinates.Length; i++)
                DistanceCoordinates[i] = new List<Point>();
            CalcDistance(startPoint);

        }

        private void CalcDistance(Point p)
        {
            DistanceMatrix[p.Y, p.X] = -1;
            maxDistance = 0;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (x != p.X || y != p.Y)
                    {
                        if (DistanceMatrix[y, x] != -1)
                        {
                            int tempDistance = Math.Abs(x - p.X) + Math.Abs(y - p.Y);
                            if (DistanceMatrix[y, x] > tempDistance || DistanceMatrix[y, x] == 0)
                            {
                                if (DistanceMatrix[y, x] != 0)
                                {
                                    var pointToRemove = DistanceCoordinates[DistanceMatrix[y, x]].Single(temp => temp.X == x && temp.Y == y);
                                    DistanceCoordinates[DistanceMatrix[y, x]].Remove(pointToRemove);
                                    DistanceCount[DistanceMatrix[y, x]]--;
                                }
                                DistanceMatrix[y, x] = tempDistance;
                                DistanceCount[DistanceMatrix[y, x]]++;
                                DistanceCoordinates[DistanceMatrix[y, x]].Add(new Point(x, y));
                            }
                            if (DistanceMatrix[y, x] > maxDistance)
                                maxDistance = DistanceMatrix[y, x];

                        }
                    }
                }
            }
        }

        private bool RangeIsOver(int index)
        {
            for (int i = index + 1; i <= maxDistance; i++)
                if (DistanceCoordinates[i].Count != 0)
                    return false;
            return true;
        }


        public Point GetRandomPoint(int index, Random rand)
        {
            
            if (index >=maxDistance)
                index = maxDistance -1;
            int distanceCountIndex = rand.Next(index + 1, maxDistance + 1);

            while (DistanceCoordinates[distanceCountIndex].Count == 0)
            {
                if (RangeIsOver(index))
                    index--;
                distanceCountIndex = rand.Next(index + 1, maxDistance + 1);
            }
            int pointIndex = rand.Next(0, DistanceCoordinates[distanceCountIndex].Count);
            Point returnPoint = DistanceCoordinates[distanceCountIndex][pointIndex];
            DistanceCoordinates[distanceCountIndex].RemoveAt(pointIndex);
            DistanceCount[distanceCountIndex]--;
            CalcDistance(returnPoint);
            return returnPoint;
        }
    }
}
