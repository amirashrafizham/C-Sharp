using System;

namespace SupernaturalInheritance
{
    class Pupil  //Lowest rank
    {
        public string Title { get; protected set; }

        public Pupil(string title)
        {
            this.Title = title;
        }

        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }
    }
}
