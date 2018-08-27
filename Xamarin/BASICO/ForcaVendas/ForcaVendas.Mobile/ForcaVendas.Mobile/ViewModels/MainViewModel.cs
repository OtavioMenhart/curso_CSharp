using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private string _ApelidoNomeFantasia;
        public string ApelidoNomeFantasia
        {
            get => _ApelidoNomeFantasia;
            set
            {
                _ApelidoNomeFantasia = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        private string _NomeCompletoRazaoSocial;
        public string NomeCompletoRazaoSocial
        {
            get => _NomeCompletoRazaoSocial;
            set
            {
                _NomeCompletoRazaoSocial = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        private string _CPFCPNJ;
        public string CPFCPNJ
        {
            get => _CPFCPNJ;
            set
            {
                _CPFCPNJ = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }
        }

        private Command _SalvarCommand;
        public Command SalvarCommand => _SalvarCommand ?? (_SalvarCommand = new Command(async () => await SalvarCommandExecute(), () => SalvarCommandCanExecute()));

        private bool SalvarCommandCanExecute()
            => !string.IsNullOrWhiteSpace(ApelidoNomeFantasia)
            && !string.IsNullOrWhiteSpace(NomeCompletoRazaoSocial)
            && !string.IsNullOrWhiteSpace(CPFCPNJ);
        
        private async Task SalvarCommandExecute()
        {
            try
            {
                //throw new ArgumentException("Apelido/Nome fantasia não informado");

                await App.Current.MainPage.DisplayAlert("Opa", "Salvou!", "Ok");
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
    }
}
