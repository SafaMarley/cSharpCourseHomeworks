using System;

namespace Inheritance
{

    //public sealed class Living //Whole code collapses since sealed keyword doesnt allow class to be parent class.
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

        public virtual void Responding()
        {
            Console.WriteLine("All living creatures react to the stimulus.");
        }
    }
}