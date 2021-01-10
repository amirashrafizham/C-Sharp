using System;

namespace Revision_Class
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        //static attribute, tells us the attribute about the SONG CLASS, not for individual SONG. 
        public static int songCount = 0; //an attribute that tells how many songs that have been created
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songCount += 1; //we can use static attribute to count how many songs have been created
        }
    }
}