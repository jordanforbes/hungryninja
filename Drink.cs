using System;

namespace Beverages.Models
{
    public abstract class Drink 
    {
        public double Volume {get;set;}
        public string Color {get;set;}
        public int Temperature {get;set;}
        public bool IsCarbonated {get;set;}

        /// <summary>
        /// This is my own description of the constructor
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="color"></param>
        /// <param name="temp"></param>
        /// <param name="isC"></param>
        public Drink(double volume, string color, int temp, bool isC)
        {
            Volume = volume;
            Color = color;
            Temperature = temp;
            IsCarbonated = isC;

        }
        public virtual void Imbibe()
        {
            Console.WriteLine("GLUG GLUG GLUG");
        }
    }
}