using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public int Price { get; set; }

        private static List<Parcel> _instances = new List<Parcel> {};

        public Parcel(string description, int weight, int length, int height, int width)
        {
            Description = description;
            Weight = weight;
            Length = length;
            Height = height;
            Width = width;

            int volume = length * width * height;

            _instances.Add(this);
        }

        public static List<Parcel> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static int CalculatePrice(int volume, int weight, int price)
        {
            if(volume > 400 || weight > 10)
            {
                price = 10;
            }
            else if(volume > 200 || weight > 5)
            {
                price = 5;
            }
            else
            {
                price = 1;
            }
            
            return price;

        }
    }
}