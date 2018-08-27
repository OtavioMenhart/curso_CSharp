using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App11_ProjVagas.Banco;
using App11_ProjVagas.iOS.Banco;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace App11_ProjVagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}