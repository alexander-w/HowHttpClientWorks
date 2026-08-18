using System.Collections.Generic;

namespace HowHttpClentWorks.Models
{
    // Simpler POCOs that match JSON property names so System.Text.Json binds without attributes.
    public class WeatherResponse
    {
        public Coord? coord { get; set; }
        public List<WeatherDescription>? weather { get; set; }
        public string? @base { get; set; }
        public Main? main { get; set; }
        public int? visibility { get; set; }
        public Wind? wind { get; set; }
        public Clouds? clouds { get; set; }
        public long? dt { get; set; }
        public Sys? sys { get; set; }
        public int? timezone { get; set; }
        public long? id { get; set; }
        public string? name { get; set; }
        public int? cod { get; set; }
    }

    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int? pressure { get; set; }
        public int? humidity { get; set; }
        public int? sea_level { get; set; }
        public int? grnd_level { get; set; }
    }

    public class WeatherDescription
    {
        public int? id { get; set; }
        public string? main { get; set; }
        public string? description { get; set; }
        public string? icon { get; set; }
    }

    public class Wind
    {
        public double? speed { get; set; }
        public int? deg { get; set; }
        public double? gust { get; set; }
    }

    public class Clouds
    {
        public int? all { get; set; }
    }

    public class Sys
    {
        public int? type { get; set; }
        public int? id { get; set; }
        public string? country { get; set; }
        public long? sunrise { get; set; }
        public long? sunset { get; set; }
    }
}

/*
 {
    "coord": {
        "lon": -0.1257,
        "lat": 51.5085
    },
    "weather": [
        {
            "id": 804,
            "main": "Clouds",
            "description": "overcast clouds",
            "icon": "04n"
        }
    ],
    "base": "stations",
    "main": {
        "temp": 292.11,
        "feels_like": 291.34,
        "temp_min": 289.53,
        "temp_max": 292.64,
        "pressure": 1018,
        "humidity": 49,
        "sea_level": 1018,
        "grnd_level": 1014
    },
    "visibility": 10000,
    "wind": {
        "speed": 3.47,
        "deg": 345,
        "gust": 6.4
    },
    "clouds": {
        "all": 88
    },
    "dt": 1785625934,
    "sys": {
        "type": 2,
        "id": 2075535,
        "country": "GB",
        "sunrise": 1785644725,
        "sunset": 1785700082
    },
    "timezone": 3600,
    "id": 2643743,
    "name": "London",
    "cod": 200
}
 */