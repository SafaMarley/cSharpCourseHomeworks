using System;

namespace Example2
{
    public class Corolla : IAutomobile
    {
        public Color DefaultColor()
        {
            return Color.Black;
        }

        public int NumberOfWheels()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Toyota;
        }
    }
}