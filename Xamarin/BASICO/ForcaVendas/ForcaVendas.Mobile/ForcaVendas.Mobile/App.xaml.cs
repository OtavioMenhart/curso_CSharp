using ForcaVendas.Mobile.Clients;
using ForcaVendas.Mobile.Data;
using ForcaVendas.Mobile.Data.Dtos;
using ForcaVendas.Mobile.Views;
using ForcaVendas.Mobile.Views.Clientes;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace ForcaVendas.Mobile
{
    public partial class App : Application
    {
        bool TimerIniciado { get; set; } = false;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ClientesView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Sincronizar();

                return false;
            });
        }

        async Task Sincronizar()
        {
            foreach (var item in await MobileDatabase.Current.GetClientesSincronizar())
            {
                var cliente = await ForcaVendaHttpClient.Current.PostJsonAsync<ClienteDto>("cliente", item);

                cliente.Sincronizado = DateTime.UtcNow;

               await MobileDatabase.Current.Save<ClienteDto, Guid>(cliente);
            }

            if (!TimerIniciado)
            {
                Device.StartTimer(TimeSpan.FromMinutes(10), () =>
                {
                    Sincronizar();

                    return true;
                });

                TimerIniciado = true;
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
