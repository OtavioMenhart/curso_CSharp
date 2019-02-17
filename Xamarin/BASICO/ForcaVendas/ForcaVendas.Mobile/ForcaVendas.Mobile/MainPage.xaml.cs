using ForcaVendas.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            BindingContext = new MainViewModel();
		}

        //private void txtNomeCompletoRazaoSocial_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        //private async void btnSalvar_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(txtApelidoNomeFantasia.Text))
        //            throw new ArgumentException                        ("Apelido/Nome fantasia não informado");

        //    }
        //    catch (ArgumentException ex)
        //    {
        //        await DisplayAlert("Ooops", ex.Message, "Ok");
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}
    }
}
