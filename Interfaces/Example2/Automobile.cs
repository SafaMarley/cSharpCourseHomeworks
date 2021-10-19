using System;

namespace Example2
{
    public abstract class Automobile
    {
        public int NumberOfWheels()
        {
            return 4;
        }

        public virtual Color DefaultColor()
        {
            return Color.White;
        }

        public abstract Brand WhichBrand();
    }
}