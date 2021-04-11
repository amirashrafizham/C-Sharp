using System;

namespace SupernaturalInheritance
{
    class Archmage : Mage  //Highest rank and inherit from Pupil
    {
        public Archmage(string title) : base(title)
        {
            this.Title = title;
        }
        public override Storm CastRainStorm()
        {
            return new Storm("rain", true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }

    }
}