using ForcaVendas.Mobile.Data;
using ForcaVendas.Mobile.Data.Dtos;
using ForcaVendas.Mobile.Services.Navigation;
using ForcaVendas.Mobile.Views.Clientes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile.ViewModels.Clientes
{
    sealed class ClienteViewModel : ViewModelBase
    {
        public ClienteDto Cliente { get; private set; }

        public ClienteViewModel(ClienteDto dto = null)
        {
            if (dto is null)
                dto = new ClienteDto() { Id = Guid.NewGuid() };

            Cliente = dto;
        }

        public string Title { get => Cliente.Id == Guid.Empty ? "Novo" : "Editar"; }

        public string ApelidoNomeFantasia
        {
            get => Cliente.ApelidoNomeFantasia;
            set
            {
                Cliente.ApelidoNomeFantasia = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        public string NomeCompletoRazaoSocial
        {
            get => Cliente.NomeCompletoRazaoSocial;
            set
            {
                Cliente.NomeCompletoRazaoSocial = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        public string CPFCNPJ
        {
            get => Cliente.CPFCNPJ;
            set
            {
                Cliente.CPFCNPJ = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        private Command _SalvarCommand;
        public Command SalvarCommand => _SalvarCommand ?? (_SalvarCommand = new Command(async () => await SalvarCommandExecute(), () => SalvarCommandCanExecute()));

        private bool SalvarCommandCanExecute()
            => !string.IsNullOrWhiteSpace(Cliente.ApelidoNomeFantasia)
            && !string.IsNullOrWhiteSpace(Cliente.NomeCompletoRazaoSocial)
            && !string.IsNullOrWhiteSpace(Cliente.CPFCNPJ);

        private async Task SalvarCommandExecute()
        {
            try
            {
                await MobileDatabase.Current.Save<ClienteDto, Guid>(Cliente);

                MessagingCenter.Send(this, ForcaVendasMessageKeys.ClientesAtualizados);
            }
            catch (ArgumentException ex)
            {
                await App.Current.MainPage.DisplayAlert("Ooops", ex.Message, "Ok");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private Command _AdicionarCommand;
        

        public Command AdicionarCommand => _AdicionarCommand ?? (_AdicionarCommand = new Command(async () => await AdicionarCommandExecute()));

        private Task AdicionarCommandExecute()
            => NavigationService.Current.PushAsync(new ClienteView());
    }
}
