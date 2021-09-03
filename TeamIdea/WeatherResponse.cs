using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamIdea
{
    public class WeatherResponse
    {
        public string Timezone {get;set;}
        public DailyResponse[] Daily { get; set; }
    }
    public class DailyResponse
    {
        public TempResponse Temp { get; set; }
        public FeelsResponse Feels_like { get; set; }
        public double dt { get; set; }
        public double Sunrise { get; set; }
        public double Sunset { get; set; }

    }
    public class TempResponse
    {
        public double Day { get; set; }
        public double Night { get; set; }
    }
    public class FeelsResponse
    {
        public double Day { get; set; }
        public double Night { get; set; }
    }

}
