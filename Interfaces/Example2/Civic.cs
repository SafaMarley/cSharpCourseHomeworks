using System;

namespace Example2
{
    public class Civic : IAutomobile
    {
        public Color DefaultColor()
        {
            return Color.Gray;
        }

        public int NumberOfWheels()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Honda;
        }
    }
}