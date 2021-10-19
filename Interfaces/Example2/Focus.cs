using System;

namespace Example2
{
    public class Focus : IAutomobile
    {
        public Color DefaultColor()
        {
            return Color.White;
        }

        public int NumberOfWheels()
        {
            return 4;
        }

        public Brand WhichBrand()
        {
            return Brand.Ford;
        }
    }
}