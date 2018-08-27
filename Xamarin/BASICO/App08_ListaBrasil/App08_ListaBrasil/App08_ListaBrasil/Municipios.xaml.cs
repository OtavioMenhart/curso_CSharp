using App08_ListaBrasil.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App08_ListaBrasil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Municipios : ContentPage
    {
        private List<Municipio> listaInternaMunicipio { get; set; }
        private List<Municipio> listaFiltradaMunicipio { get; set; }

        public Municipios(Estado estado)
        {
            InitializeComponent();
            listaInternaMunicipio = Servico.Servico.GetMunicipio(estado.id);
            ListaMunicipios.ItemsSource = listaInternaMunicipio;

        }

        private void BuscaRapida(object sender, TextChangedEventArgs args)
        {
            listaFiltradaMunicipio = listaInternaMunicipio.Where(a => a.nome.Contains(args.NewTextValue)).ToList();
            ListaMunicipios.ItemsSource = listaFiltradaMunicipio;
        }

    }
}