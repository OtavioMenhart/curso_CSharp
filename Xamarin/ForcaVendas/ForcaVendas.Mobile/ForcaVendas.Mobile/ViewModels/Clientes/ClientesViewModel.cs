using ForcaVendas.Mobile.Data;
using ForcaVendas.Mobile.Data.Dtos;
using ForcaVendas.Mobile.Services.Navigation;
using ForcaVendas.Mobile.Views.Clientes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile.ViewModels.Clientes
{
    sealed class ClientesViewModel
    {
        public ClientesViewModel()
        {
        }

        public ObservableCollection<ClienteCellViewModel> Clientes { get; private set; } = new ObservableCollection<ClienteCellViewModel>();

        private Command _AdicionarCommand;
        public Command AdicionarCommand => _AdicionarCommand ?? (_AdicionarCommand = new Command(async () => await AdicionarCommandExecute()));

        private async Task AdicionarCommandExecute()
        {
            SubscribeAndRefresh();

            await NavigationService.Current.PushAsync(new ClienteView());
        }


        private Command<object> _SelecionarCommand;
        public Command<object> SelecionarCommand => _SelecionarCommand ?? (_SelecionarCommand = new Command<object>(async (parameter) => await SelecionarCommandExecute(parameter)));

        private async Task SelecionarCommandExecute(object parameter)
        {
            SubscribeAndRefresh();

            var cliente = await MobileDatabase.Current.Get<ClienteDto>(((ClienteCellViewModel)parameter).Id);

            await NavigationService.Current.PushAsync(new ClienteView(cliente));
        }

        private void SubscribeAndRefresh()
        {
            MessagingCenter.Subscribe<ClienteViewModel>(this,
                            ForcaVendasMessageKeys.ClientesAtualizados,
                            async (sender) =>
                            {
                                Clientes.Clear();

                                foreach (var item in await MobileDatabase.Current.GetClientesAll())
                                {
                                    Clientes.Add(item);
                                }
                                MessagingCenter.Unsubscribe<ClienteViewModel>(this, ForcaVendasMessageKeys.ClientesAtualizados);

                                await NavigationService.Current.PopAsync();
                            });
        }
    }
}
