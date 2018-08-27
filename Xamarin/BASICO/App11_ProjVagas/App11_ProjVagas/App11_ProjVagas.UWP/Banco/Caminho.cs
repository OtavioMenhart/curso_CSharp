using App11_ProjVagas.Banco;
using App11_ProjVagas.UWP.Banco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace App11_ProjVagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}
