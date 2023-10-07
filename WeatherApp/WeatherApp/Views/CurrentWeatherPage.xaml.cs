using Acr.UserDialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WeatherApp.Helper;
using WeatherApp.Init;
using WeatherApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentWeatherPage : ContentPage
    {
        public static string OpenWeatherApiKey = "9f61f3b193730e9b42366ace8843efc8";
        //default
        public static string Location = "Cao Lanh";
    public CurrentWeatherPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
            GetWeatherInfo(Location);

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {

                    DateTime time = DateTime.Now;
                    timeTxt.Text = time.ToString("HH:mm:ss");
                    if(time.Hour % 3 == 0 && time.Second == 0 && time.Minute == 0)
                    {
                        GetWeatherInfo(Location);
                    }
                });
                return true;
            });
        }
        public List<WeatherDay> WeatherDays { get; set; }
        public async void GetWeatherInfo(string location)
        {
            Location = location;
            loading(true);

            var url = $"https://api.openweathermap.org/data/2.5/weather?q={location},VN&appid={OpenWeatherApiKey}&units=metric";

            var result = await ApiCaller.Get(url);
            if (result.Successful)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.Response);
                    bgImg.Source = Areas.areasMapperImg[location];
                    string des = Description.DescriptionMapper[weatherInfo.weather[0].id];
                    if (des != null)
                    {
                        descriptionTxt.Text = des.ToUpper();
                    }
                    else descriptionTxt.Text = weatherInfo.weather[0].description.ToUpper();
                    iconImg.Source = $"w{weatherInfo.weather[0].icon}";
                    cityTxt.Text = Areas.areasMapper[weatherInfo.name].ToUpper();
                    temperatureTxt.Text = weatherInfo.main.temp.ToString("0");
                    humidityTxt.Text = $"{weatherInfo.main.humidity}%";
                    pressureTxt.Text = $"{weatherInfo.main.pressure} hpa";
                    windTxt.Text = $"{weatherInfo.wind.speed} m/s";
                    cloudinessTxt.Text = $"{weatherInfo.clouds.all}%";

                    //var dt = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.dt).DateTime; 
                    // dateTxt.Text = string.Format("{0} ngày {1:dd/MM}", GetDay(dt), dt).ToUpper();
                    
                    DateTime dateTimeUtc = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.dt).UtcDateTime;

                    // Việt Nam (+07:00)
                    TimeSpan vietnamOffset = TimeSpan.FromHours(7);

                    // transform
                    DateTime dt = dateTimeUtc + vietnamOffset;
                    dateTxt.Text = string.Format("{0} ngày {1:dd/MM}", GetDay(dt), dt).ToUpper();

                    GetForecastInfo(location);

                }
                catch (Exception ex) {
                    loading(false);
                    await DisplayAlert("Thông tin thời tiết", ex.Message, "OK");
                }
            }
            else
            {
                loading(false);
                await DisplayAlert("Thông tin thời tiết", "Không tìm thấy thông tin thời tiết", "OK");
            }
        }
        private void OpenFlyoutButton_Clicked(object sender, EventArgs e)
        {
            if (App.Current.MainPage is FlyoutPage flyoutPage)
            {
                flyoutPage.IsPresented = true; // display
            }
        }

        private async void GetForecastInfo(string location)
        {
            var tempList = new List<WeatherDay>();
            var url = $"https://api.openweathermap.org/data/2.5/forecast?q={location},VN&appid={OpenWeatherApiKey}&units=metric";

            var result = await ApiCaller.Get(url);

            if(result.Successful)
            {
                try
                {
                    var forcastInfo = JsonConvert.DeserializeObject<ForecastInfo>(result.Response);

                    List<List> allList = new List<List>();

                    foreach(var list in forcastInfo.list)
                    {
                        var date = DateTime.Parse(list.dt_txt);
                        
                      if(date > DateTime.Now)
                            allList.Add(list);
                    }
                    List<WeatherDay> allDay = new List<WeatherDay>();
                    foreach(var item in allList)
                    {
                        WeatherDay day = new WeatherDay();  
                        day.Icon = $"w{item.weather[0].icon}";
                        var date = DateTime.Parse(item.dt_txt);
                        day.Date = date.ToString("HH:mm")+" "+GetDay(date);
                        day.Temp = item.main.temp.ToString("0");
                        allDay.Add(day);
                    }
                    WeatherForecastList.ItemsSource = allDay;
                    loading(false);
                }
                catch (Exception ex)
                {
                    loading(false);
                    await DisplayAlert("Thông tin thời tiết", ex.Message, "OK");
                }
            }
            else
            {
                loading(false);
                await DisplayAlert("Thông tin thời tiết", "Không tìm thấy thông tin thời tiết", "OK");
            }
        }
        private string FormatVietnameDate(DateTime date)
        {
            string[] monthNames = new string[]
            {
             "tháng 1", "tháng 2", "tháng 3", "tháng 4", "tháng 5", "tháng 6",
             "tháng 7", "tháng 8", "tháng 9", "tháng 10", "tháng 11", "tháng 12"
            };
            return string.Format("ngày {0} {1}", date.Day, monthNames[date.Month - 1]);
        }
        private string GetDay(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Thứ 2";
                case DayOfWeek.Tuesday:
                    return "Thứ 3";
                case DayOfWeek.Wednesday:
                    return "Thứ 4";
                case DayOfWeek.Thursday:
                    return "Thứ 5";
                case DayOfWeek.Friday:
                    return "Thứ 6";
                case DayOfWeek.Saturday:
                    return "Thứ 7";
                case DayOfWeek.Sunday:
                    return "Chủ Nhật";
                default:
                    return "";
            }
        }
        private void loading(bool isLoading)
        {
            if(isLoading)
            {
                UserDialogs.Instance.ShowLoading("Chờ xíu...");
            }
            else
            {
                UserDialogs.Instance.HideLoading();
            }
        }
    }
}