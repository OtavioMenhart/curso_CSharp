using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile.Services.Navigation
{
    class NavigationService
    {
        private static Lazy<NavigationService> _Lazy = new Lazy<NavigationService>(() => new NavigationService());

        public static NavigationService Current { get => _Lazy.Value; }

        private NavigationService()
        {

        }

        INavigation _Navigation { get => ((NavigationPage)App.Current.MainPage).Navigation; }

        public Task PushAsync(Page page, bool animated = true) =>
            _Navigation.PushAsync(page, animated);

        public Task PopAsync(bool animated = true) =>
            _Navigation.PopAsync(animated);
    }
}
