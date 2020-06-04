using System;

namespace Beverages.Models 
{
    public class Water : Drink
    {
        public Water(double volume, string color, int temp, bool isC) : base(volume, color, temp, isC)
        {
        }
        public override void Imbibe()
        {
            if (Temperature <100)
            {
                Console.WriteLine("sip sip sip");
            }else if(Temperature > 100){
                Console.WriteLine("siAAAAAAAAGH");
            }
        }
    }
}