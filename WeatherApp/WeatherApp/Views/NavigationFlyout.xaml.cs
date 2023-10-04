using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Init;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationFlyout : ContentPage
    {
        public ListView ListView;

        public NavigationFlyout()
        {
            InitializeComponent();

            BindingContext = new NavigationFlyoutViewModel();
            ListView = MenuItemsListView;
        }
       
        class NavigationFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<NavigationFlyoutMenuItem> MenuItems { get; set; }
            
            public NavigationFlyoutViewModel()
            {
                NavigationFlyoutMenuItem[] items = new NavigationFlyoutMenuItem[Areas.areasMapper.Count];
                int i = 0;
                foreach (var pair in Areas.areasMapper)
                {
                    items[i] = new NavigationFlyoutMenuItem { Id = i, Title = pair.Value, Key = pair.Key };
                    i++;
                }
                MenuItems = new ObservableCollection<NavigationFlyoutMenuItem>(items);
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}