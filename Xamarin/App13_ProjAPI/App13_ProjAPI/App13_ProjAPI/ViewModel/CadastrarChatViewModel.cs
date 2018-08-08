using App13_ProjAPI.Model;
using App13_ProjAPI.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App13_ProjAPI.ViewModel
{
    public class CadastrarChatViewModel : INotifyPropertyChanged
    {
        private string _mensagem { get; set; }

        public string mensagem {
            get { return _mensagem; }
            set { _mensagem = value; OnPropertyChanged("mensagem"); }
        }


        public string nome { get; set; }
        public Command CadastrarCommand { get; set; }

        public CadastrarChatViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);
        }

        

        private void Cadastrar()
        {
            var chat = new Chat() { nome = nome };
            bool ok = ServiceWS.InsertChat(chat);

            if(ok == true)
            {
                ((NavigationPage)App.Current.MainPage).Navigation.PopAsync();

                var nav = (NavigationPage)App.Current.MainPage;
                var chats = (View.Chats)nav.RootPage;
                var viewModel = (ChatsViewModel)chats.BindingContext;
                if (viewModel.AtualizarCommand.CanExecute(null))
                {
                    viewModel.AtualizarCommand.Execute(null);
                }
            }
            else
            {
                mensagem = "Ocorreu erro no cadastro";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
