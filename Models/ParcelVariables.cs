using System;
namespace Parcels.Models
{
    public class ParcelVariables
    {
        private int _length;
        private int _width;
        private int _height;
        private int _weight;
        private int _volume;
        private int _costMultiplyer = 2;

        public ParcelVariables (int length, int width, int height, int weight)
        {
            if ((length > 0) || (width > 0) || (height > 0) || (weight > 0))
            {
                _length = length;
                _width = width;
                _height = height;
                _weight = weight;
                _volume = ((_length * _width * _height)/_weight);
            }
            else {
                Console.WriteLine("Please enter valid numbers.");
                return;
            }
        }
        public int GetResult()
        {
            return _volume;
        }
        public int CostToShip()
        {
            return (_volume * _costMultiplyer);
        }
        public int GetLength()
        {
            return _length;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetWeight()
        {
            return _weight;
        }
    }
}