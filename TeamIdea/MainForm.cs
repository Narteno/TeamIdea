using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TeamIdea
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string url = "https://api.openweathermap.org/data/2.5/onecall?lat=56.5&lon=84,9667&exclude=current,minutely,hourly,alerts&units=metric&lang=ru&appid=e26aeb1038ad39dfa05422c61475591d",
                response = "";
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();

            using (StreamReader reader = new StreamReader(webresponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            var json = JsonConvert.DeserializeObject<WeatherResponse>(response);
            lbCity.Text = json.Timezone;
            lbDay.Text = "Днем " + Math.Round(json.Daily[0].Temp.Day,1).ToString() + "℃" +
                ". Ощущается как " + Math.Round(json.Daily[0].Feels_like.Day, 1).ToString() + "℃";
            lbNight.Text = "Ночью " + Math.Round(json.Daily[0].Temp.Night,1).ToString() + "℃" +
                ". Ощущается как " + Math.Round(json.Daily[0].Feels_like.Night, 1).ToString() + "℃";
            TimeSpan MaxLengthOfTheDay = new TimeSpan(0, 0, 0);
            for (int i = 0; i < 5; i++)
            { 
                DailyResponse DR = json.Daily[i];
                var LengthOfTheDay = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(DR.Sunset).AddHours(7).TimeOfDay - 
                    (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(DR.Sunrise).AddHours(7).TimeOfDay;
                if (LengthOfTheDay > MaxLengthOfTheDay)
                {
                    MaxLengthOfTheDay = LengthOfTheDay;
                    lbLongDay.Text = "Максимальная продолжительность светового дня наблюдается "+((new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(DR.dt).AddHours(7)).ToShortDateString()+
                        " числа, и будет составлять " + Math.Round(MaxLengthOfTheDay.TotalHours,1).ToString() + " часов";
                }
            }
        }
    }
}
