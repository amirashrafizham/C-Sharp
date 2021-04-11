using System;

namespace SupernaturalInheritance
{
    class Mage : Pupil  //Mid rank and inherit from Pupil
    {
        public Mage(string title) : base(title)
        {
            this.Title = title;
        }

        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }

    }
}