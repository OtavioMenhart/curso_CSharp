using ForcaVendas.Mobile.Data;
using ForcaVendas.Mobile.iOS.Providers;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(MobileDatabaseProvider))]

namespace ForcaVendas.Mobile.iOS.Providers
{
    class MobileDatabaseProvider : IMobileDatabaseProvider
    {
        public MobileDatabaseProvider()
        {

        }

        public string DatabasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", "ForcaVendas.db3");
    }
}