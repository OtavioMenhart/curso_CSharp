﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App11_ProjVagas.Banco;
using App11_ProjVagas.Droid.Banco;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caminho))]
namespace App11_ProjVagas.Droid.Banco
{
   public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}