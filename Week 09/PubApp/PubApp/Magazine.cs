using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubApp
{
    class Magazine : Publication
    {
        public string Month { get; set; }
        public int Issue { get; set; }

        public Magazine(String title, int year, string month, int issue) : base(title, year)
        {
            Month = month;
            Issue = issue;
        }

        public string PubDate
        {
            get
            {
                string publicationDate = Month + ", " + Year;
                return publicationDate;
            }
        }

        public new string GetInfo()
        {
            string info = base.GetInfo();
            info += "Publication Month: " + Month + "\n";
            info += "Issue: " + Issue + "\n";
            return info;
        }
    }
}
