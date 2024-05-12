using System.Collections.Generic;

namespace WheaterAPP.Models
{
    public class WheaterForcastModel
    {

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

        public class city
        {
            public string name { get; set; }
           public string sunrise { get; set; }
           public string sunset { get; set;}
        }
        public class list
        {
            public string dt_txt { get; set; }
            public List<weather> weather { get; set; }
            public wind wind { get; set; }
            public main main { get; set; }
           
        }

        public class WheaterForcast
        {
            public city city { get; set; }
            public List<list> list { get; set; }
        }
    }
}
    