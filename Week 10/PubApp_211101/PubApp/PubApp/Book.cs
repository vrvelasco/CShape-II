using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp
{
    class Book : Publication
    {
      public string Author { get; set; }
        public string Genre { get; set; }

        public Book(String t, int y, string a, string g) : base(t,y)
        {
            Author = a;
            Genre = g;
        }

        public override string GetInfo()
        {
            string info = base.GetInfo();
            info += "Author: " + Author + "\n";
            info += "Genre: " + Genre + "\n";
            return info;
        }
    }
}
