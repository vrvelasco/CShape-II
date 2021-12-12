using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp
{
    class Publication
    {
        public string Title { get; set; }
        public bool Read { get; set; }
        public int Year { get; set; }

        public Publication(String t, int y)
        {
            Title = t;
            Year = y;
            Read = false;
        }

        public string GetInfo()
        {
            string info = string.Empty;
            info += "Title: " + Title + "\n";
            info += "Publication Year: " + Year + "\n";
            info += "Read: " + Read + "\n";
            return info;
        }

    }
}
