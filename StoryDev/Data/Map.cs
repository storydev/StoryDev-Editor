using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class Map : DBObject
    {

        public int ID;
        public string Name;
        public string ImagePath;
        public List<Region> Regions;
        public List<MapPoint> Points;

        public Map()
        {
            Name = "";
            ImagePath = "";
            Regions = new List<Region>();
            Points = new List<MapPoint>();
        }

    }

    class Region
    {

        public string Name;
        public List<Point> Points;

        public Region()
        {
            Name = "";
            Points = new List<Point>();
        }

    }

    class MapPoint
    {

        public string Name;
        public Point Point;

        public MapPoint()
        {

        }

    }

    class Point
    {

        public int X;
        public int Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }

    }
}
