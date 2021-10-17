using System;

namespace Inheritance
{
    public class Living
    {
        protected void BeFed()
        {
            Console.WriteLine("All living creatures need nutrition.");
        }

        protected void Respiration()
        {
            Console.WriteLine("All living creatures breathe.");
        }

        protected void Excretion()
        {
            Console.WriteLine("All living creatures excrete.");
        }

        protected void Adaptation()
        {
            Console.WriteLine("All living creatures adapt to their surrounding.");
        }
    }
}