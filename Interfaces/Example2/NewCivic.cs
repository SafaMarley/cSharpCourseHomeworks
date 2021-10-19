using System;

namespace Example2
{
    public class NewCivic:Automobile
    {
        public override Brand WhichBrand()
        {
            return Brand.Honda;
        }

        public override Color DefaultColor()
        {
            return Color.Black;
        }
    }
}