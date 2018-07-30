using ForcaVendas.Mobile.ViewModels.Clientes;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcaVendas.Mobile.Views.Clientes
{
    public partial class ClientesView : ContentPage
    {
        ClientesViewModel ViewModel { get => (ClientesViewModel)BindingContext; }

        public ClientesView()
        {
            InitializeComponent();

            BindingContext = new ClientesViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            ViewModel.SelecionarCommand.Execute(e.Item);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
