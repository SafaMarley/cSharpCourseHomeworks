using System;

namespace Inheritance
{
    public class Plants:Living
    {
        public Plants()
        {
            base.BeFed();
            base.Excretion();
            base.Adaptation();
            base.Respiration();
        }
        protected void Autotrophs()
        {
            Console.WriteLine("Most plants must produce their own food by chemicals.");
        }
    }

    public class PlantsWithSeeds:Plants
    {
        public PlantsWithSeeds()
        {
            base.Autotrophs();
        }

        public void breedWithSeeds()
        {
            Console.WriteLine("Plants with seeds use their seeds to breed.");
        }
    }

    public class PlantsWithoutSeeds:Plants
    {
        public PlantsWithoutSeeds()
        {
            base.Autotrophs();
        }

        public void breedWitouthSeeds()
        {
            Console.WriteLine("Plants without seeds use their spores to breed.");
        }
    }
}