using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WatcherDB.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string WatchedTitle { get; set; }
        public string Summary { get; set; }
        public string Source { get; set; }
        public DateTime Year { get; set; }
        public string Type { get; set; }

        public Title()
        {

        }

    }
}
