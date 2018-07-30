using ForcaVendas.Mobile.Data.Dtos;
using ForcaVendas.Mobile.ViewModels.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ForcaVendas.Mobile.Views.Clientes
{
    public partial class ClienteView : ContentPage
    {
        public ClienteView(object parameter = null)
        {
            InitializeComponent();

            BindingContext = new ClienteViewModel((ClienteDto)parameter);

            switch (Device.Idiom)
            {
                case TargetIdiom.Unsupported:
                    break;
                case TargetIdiom.Phone:
                    break;
                case TargetIdiom.Tablet:
                    btnVoltar.FontSize = Device.GetNamedSize(NamedSize.Medium, btnVoltar.GetType());
                    break;
                case TargetIdiom.Desktop:
                    break;
                case TargetIdiom.TV:
                    break;
                default:
                    break;
            }

        }
    }
}