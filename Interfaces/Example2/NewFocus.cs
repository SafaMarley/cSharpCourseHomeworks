using System;

namespace Example2
{
    public class NewFocus:Automobile
    {
        public override Brand WhichBrand()
        {
            return Brand.Ford;
        }

        public override Color DefaultColor()
        {
            return Color.Gray;
        }
    }
}
