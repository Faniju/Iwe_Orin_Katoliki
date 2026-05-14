using System.Collections.Generic;

namespace YorubaCatholicHymn.Models
{
    public class Hymn
    {
        public string Number { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public List<string> Chorus { get; set; }
        public List<Verse> Verses { get; set; }
        public string Snippet
        {
            get
            {
                if (Chorus != null && Chorus.Count > 0)
                    return Chorus.FirstOrDefault();

                if (Verses != null && Verses.Count > 0 && Verses[0].Lines?.Count > 0)
                    return Verses[0].Lines.FirstOrDefault();

                return string.Empty;
            }
        }
    }

    public class Verses
    {
        public string Number { get; set; }
        public List<string> Lines { get; set; }
    }
}