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
        public CurrentWeatherPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            GetWeatherInfo("Cao Lanh");
        }

        public async void GetWeatherInfo(string location)
        {
            loading(true);

            var url = $"https://api.openweathermap.org/data/2.5/weather?q={location},VN&appid=9f61f3b193730e9b42366ace8843efc8&units=metric";

            var result = await ApiCaller.Get(url);
            if (result.Successful)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.Response);
                    bgImg.Source = Areas.areasMapperImg[location];
                    descriptionTxt.Text = weatherInfo.weather[0].description.ToUpper();
                    iconImg.Source = $"w{weatherInfo.weather[0].icon}";
                    cityTxt.Text = Areas.areasMapper[weatherInfo.name].ToUpper();
                    temperatureTxt.Text = weatherInfo.main.temp.ToString("0");
                    humidityTxt.Text = $"{weatherInfo.main.humidity}%";
                    pressureTxt.Text = $"{weatherInfo.main.pressure} hpa";
                    windTxt.Text = $"{weatherInfo.wind.speed} m/s";
                    cloudinessTxt.Text = $"{weatherInfo.clouds.all}%";

                    var dt = DateTimeOffset.FromUnixTimeSeconds(weatherInfo.dt).DateTime; 
                    dateTxt.Text = string.Format("{0} ngày {1:dd/MM}", GetDay(dt), dt).ToUpper();

                    GetForecastInfo(location);
                    loading(false);

                }
                catch (Exception ex) {
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
                flyoutPage.IsPresented = true; // Hiển thị Flyout
            }
        }

        private async void GetForecastInfo(string location)
        {
            var url = $"https://api.openweathermap.org/data/2.5/forecast?q={location},VN&appid=9f61f3b193730e9b42366ace8843efc8&units=metric";

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
                        
                        if(date > DateTime.Now && date.Hour == 0 && date.Minute == 0 && date.Second == 0)
                            allList.Add(list);  
                    }

                    dayOneTxt.Text = GetDay(DateTime.Parse(allList[0].dt_txt));
                    dateOneTxt.Text = FormatVietnameDate(DateTime.Parse(allList[0].dt_txt));
                    iconOneImg.Source = $"w{allList[0].weather[0].icon}";
                    tempOneTxt.Text = allList[0].main.temp.ToString("0");

                    dayTwoTxt.Text = GetDay(DateTime.Parse(allList[1].dt_txt));
                    dateTwoTxt.Text = FormatVietnameDate(DateTime.Parse(allList[1].dt_txt));
                    iconTwoImg.Source = $"w{allList[1].weather[0].icon}";
                    tempTwoTxt.Text = allList[1].main.temp.ToString("0");

                    dayThreeTxt.Text = GetDay(DateTime.Parse(allList[2].dt_txt));
                    dateThreeTxt.Text = FormatVietnameDate(DateTime.Parse(allList[2].dt_txt));
                    iconThreeImg.Source = $"w{allList[2].weather[0].icon}";
                    tempThreeTxt.Text = allList[2].main.temp.ToString("0");

                    dayFourTxt.Text = GetDay(DateTime.Parse(allList[3].dt_txt));
                    dateFourTxt.Text = FormatVietnameDate(DateTime.Parse(allList[3].dt_txt));
                    iconFourImg.Source = $"w{allList[3].weather[0].icon}";
                    tempFourTxt.Text = allList[3].main.temp.ToString("0");

                }
                catch (Exception ex)
                {
                    await DisplayAlert("Thông tin thời tiết", ex.Message, "OK");
                }
            }
            else
            {
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