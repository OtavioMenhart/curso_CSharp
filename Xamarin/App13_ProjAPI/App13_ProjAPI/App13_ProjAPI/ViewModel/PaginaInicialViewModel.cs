using App13_ProjAPI.Model;
using App13_ProjAPI.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App13_ProjAPI.ViewModel
{
    public class PaginaInicialViewModel : INotifyPropertyChanged
    {
        private string _nome;
        private string _senha;
        private string _mensagem;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Nome"));
            }
        }


        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Senha"));
            }
        }

        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            set
            {
                _mensagem = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Mensagem"));
            }
        }

        public Command AcessarCommand { get; set; }

        public PaginaInicialViewModel()
        {
            AcessarCommand = new Command(Acessar);
        }

        private void Acessar()
        {
            var user = new Usuario();
            user.nome = Nome;
            user.password = Senha;
            var usuarioLogado = ServiceWS.GetUsuario(user);

            if(usuarioLogado == null)
            {
                Mensagem = "Senha incorreta.";
            }
            else
            {
                Util.UsuarioUtil.SetUsuarioLogado(usuarioLogado);
                //App.Current.Properties["LOGIN"] = JsonConvert.SerializeObject(usuarioLogado);
                App.Current.MainPage = new NavigationPage(new View.Chats()) {BarBackgroundColor = Color.FromHex("#5ED055"), BarTextColor = Color.White };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
