using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Init;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigation : FlyoutPage
    {
        public Navigation()
        {
            InitializeComponent();
            FlyoutPage.ListView.ItemSelected += ListView_ItemSelected;

            // Khởi tạo currentWeatherPage
            currentWeatherPage = new CurrentWeatherPage();
            // Đặt trang CurrentWeatherPage làm trang ban đầu
            Detail = currentWeatherPage;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as NavigationFlyoutMenuItem;
            if (item == null)
                return;

            // Gọi phương thức GetWeather từ CurrentWeatherPage với tham số item.Title
            currentWeatherPage.GetWeatherInfo(item.Key);

            IsPresented = false;

            FlyoutPage.ListView.SelectedItem = null;
        }
    }
}