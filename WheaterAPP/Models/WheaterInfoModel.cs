using System;
using System.Collections.Generic;

namespace WheaterAPP.Models
{
    public class WheaterInfoModel
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }

        public class weather
        {
            public string icon { get; set; }
            public string description { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }

        }

        public class wind
        {
            public double speed { get; set; }
        }

        public class sys
        {
            public string sunrise { get; set; }
            public string sunset { get; set; }
        }

        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            public string name { get; set; }
            public DateTime dateOfCreation { get; set; }
        }
    }
}