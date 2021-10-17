using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PlantsWithSeeds tomato = new PlantsWithSeeds();
            /*
            tomato.BeFed();
            tomato.Autotrophs();
            */
            tomato.breedWithSeeds();

            Birds parrot = new Birds();
            /*
            parrot.Adaptation();
            */
            parrot.Heterotrophs();
            parrot.Movement();
        }
    }
}
