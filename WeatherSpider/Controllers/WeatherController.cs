using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherSpider.ReadModels;

namespace WeatherSpider.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Weather()
        {
            // station=14008 --> Kredarica
            // 1991-01-01 --> Se začne pojavljat tavg

            var url = "https://meteostat.p.rapidapi.com/stations/monthly?station=14008&start=2021-01-01&end=2021-12-31";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            request.Headers["X-RapidAPI-Key"] = "79f8dd2ddfmshe4748d1bf435c58p1a8abfjsn9d5b19f14030";
            request.Headers["X-RapidAPI-Host"] = "meteostat.p.rapidapi.com";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();
            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            JObject json = JObject.Parse(data);
            JToken dataToken = json["data"];

            IEnumerable<JToken> year = dataToken.Children();

            List<Data> dataForChart = new List<Data>();
            foreach (var month in year)
            {
                dataForChart.Add(new Data((double)month["tavg"]));
            }

            var rm = new WeatherDataRm(
                chart: new Chart(
                    caption: "Weather on Kredarica",
                    subCaption: "Based on Time periox",
                    numberPrefix: "",
                    theme: "fusion",
                    radarfillcolor: "#ffffff"
                ),
                categories: new List<Catergory>
                {
                    new Catergory(
                        new List<Label>
                        {
                            new Label("Jan"),
                            new Label("Feb"),
                            new Label("Mar"),
                            new Label("Apr"),
                            new Label("May"),
                            new Label("Jun"),
                            new Label("Jul"),
                            new Label("Aug"),
                            new Label("Sep"),
                            new Label("Oct"),
                            new Label("Nov"),
                            new Label("Dec"),
                        }
                    )
                },

                dataset: new List<DataSet>
                {
                    new DataSet(
                        seriesname:"Temperature average",
                        dataForChart
                        )
                }
            );

            return Ok(rm);
        }
    }
}
