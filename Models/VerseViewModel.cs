using System.Collections.Generic;
using System.Linq;

namespace YorubaCatholicHymn.Models
{
    public class VerseViewModel
    {
        public string Number { get; set; }
        public List<string> Lines { get; set; }

        public string FirstLine => Lines != null && Lines.Count > 0 ? Lines[0] : string.Empty;
        public List<string> RemainingLines => Lines != null && Lines.Count > 1 ? Lines.Skip(1).ToList() : new List<string>();
    }
}