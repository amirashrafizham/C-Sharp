using System;

namespace ActiveRecall
{
    class Movie
    {
        public string name;
        public string director;
        private string rating;

        public Movie(string aName, string aDirector, string aRating)
        {
            name = aName;
            director = aDirector;
            Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NA";
                }
            }
        }

    }
}