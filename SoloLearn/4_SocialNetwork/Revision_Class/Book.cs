using System;

namespace Revision_Class
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //Constructors 
        //This prevents us from repeating ourselves from assinging title, authoer and pages
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}