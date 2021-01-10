using System;

namespace Revision_Class
{
    class Movie
    {
        public string title;
        public string director;
        //First step, we make the 'rating' private. 
        private string rating;//only inside Movie class can access it
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //Thirdly, we name assign the argument to the Rating property
        }

        //Secondly, we put the get{} and set{}
        public string Rating
        {
            get { return rating; } //to get the rating
            set //to set the rating 
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR"; //rating that is not G, PG, PG-13, R then it will return Not Rating
                }
            }
        }
    }
}