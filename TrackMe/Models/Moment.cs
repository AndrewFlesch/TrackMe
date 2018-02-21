using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackMe.Models
{
    public class Moment
    {
        public int Id { get; set; }
        public string Feeling { get; set; }
        public int FeelStrength { get; set; }
        public string Being { get; set; }
        public string With { get; set; }
        public string Doing { get; set; }
        public int Temp { get; set; }
        public string Weather { get; set; }
        public string Comments { get; set; }
    }
}