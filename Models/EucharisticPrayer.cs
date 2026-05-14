using System.Collections.Generic;

namespace YorubaCatholicHymn.Models
{
    public class Preface
    {
        public string PrayerNumber { get; set; } // Eucharistic Prayer number (null for general prefaces)
        public string Season { get; set; }      // Liturgical season
        public string Title { get; set; }       // Preface title
        public string Comment { get; set; }     // Optional comment
        public string Text { get; set; }        // Preface text
    }
    public class EucharisticPrayer
    {
        public string Number { get; set; }              // e.g. "I", "II"
        public string Title { get; set; }               // e.g. "Àdúrà Yukaristí kìnní"
        public string Season { get; set; }              // e.g. "Christmas", "Easter"
        public string Comment { get; set; }             // Optional comment
        public string Text { get; set; }                // Full prayer text
        public List<Communicantes> CommunicantesList { get; set; } // Only for Prayer I
        public bool HasOwnPrefaceOnly { get; set; } = false;
        public bool HasOwnPrefaceButCanUseOthers { get; set; } = false;
        public string DefaultPrefaceSeason { get; set; }
        public List<string> AllowedPrefaceSeasons { get; set; } = new();
        public Preface OwnPreface { get; set; }
    }

    public class Communicantes
    {
        public string Season { get; set; }   // e.g. "Christmas", "Epiphany"
        public string Text { get; set; }     // Communicantes prayer text
        public string Comment { get; set; }             // Optional comment
    }
    public class Gloria
    {
        public string Season { get; set; }
        public string Text { get; set; }
    }
}