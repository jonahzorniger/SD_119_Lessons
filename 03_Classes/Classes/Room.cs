using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes.Classes
{
    public class Room
    {
        private double _length;
        private double _width;
        private double _height;

        public Room(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        //CHALLENGE 
        // Create 3 properties (with getter only):
        // SquareFootage  1
        // WallSurfaceArea  2
        // Volume  3

        //1
        //This is a method
        public double GetSquareFootage()
        {
            return _length * _width;
        }

        //This is a PROPERTY
        public double SquareFootage
        {
            get { return _length * _width; }
        }



        //2
        public double WallSurfaceArea
        {
            get {return (2 * _width * _height + 2 * _length * _height); }
        }

        //3
        public double Volume
        {
            get { return _length * _width * _height; }
        }
    }
}
