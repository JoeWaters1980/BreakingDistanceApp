using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingDistanceApp
{
    public enum WeatherType { Dry, Wet, Snow }
    class WeatherCon
    {
        // Properties
        public string WeatherCondition { get; set; }
        // Constructors
        public WeatherCon()
        { }


        public WeatherCon(string wetherCon)
        {
            WeatherCondition = wetherCon;
        }
        // Methods
        public override string ToString()
        {
            return $"{WeatherCondition}";
        }
    }
}

