using System;

namespace Beverages.Models {
    public class Coffee : Drink, ICaffeinated {

        public int CaffeineAmt { get; set; }
        public string BeanType {get;set;}

        public Coffee (double volume, string color, int temp, int cAmt, string bean) : base (volume, color, temp, false) 
        {
            if (cAmt <= 0) {
                throw new Exception ("This Coffie must have caffeine in it!");
            };

            BeanType = bean;
            CaffeineAmt = cAmt;}

            public override void Imbibe () {
                if (Temperature < 100) {
                    Console.WriteLine ("sip sip sip");
                } else if (Temperature > 100) {
                    Console.WriteLine ("siAAAAAAAAGH");
                }
            }
        }
    }
