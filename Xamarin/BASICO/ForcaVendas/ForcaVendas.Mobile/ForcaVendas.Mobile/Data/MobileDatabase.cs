using ForcaVendas.Mobile.Data.Dtos;
using ForcaVendas.Mobile.ViewModels.Clientes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ForcaVendas.Mobile.Data
{
    class MobileDatabase
    {
        private static Lazy<MobileDatabase> _Lazy = new Lazy<MobileDatabase>(() => new MobileDatabase());
        private readonly SQLiteConnection _SQLiteConnection;

        public static MobileDatabase Current { get => _Lazy.Value; }

        private MobileDatabase()
        {
            var databasePath = DependencyService.Get<IMobileDatabaseProvider>()
                .DatabasePath;

            _SQLiteConnection = new SQLiteConnection(databasePath);
            _SQLiteConnection.CreateTable<ClienteDto>();
        }

        //Insert
        //Update

        public Task<bool> Save<TDto, TPrimaryKey>(TDto dto)
            where TDto : DtoBase<TPrimaryKey>
            where TPrimaryKey : struct
        => Task.Factory.StartNew(() =>
        {
            dto.Sincronizado = null;

            return _SQLiteConnection.InsertOrReplace(dto) > 0;
        });

        //Get
        public Task<List<TDto>> Get<TDto>()
            where TDto : new()
        => Task.Factory.StartNew(() => _SQLiteConnection.Table<TDto>().ToList());

        //Get(Id)
        public Task<TDto> Get<TDto>(object primaryKey)
            where TDto : new()
        => Task.Factory.StartNew(() => _SQLiteConnection.Get<TDto>(primaryKey));

        //Delete
        public Task<bool> Delete<TDto>(object primaryKey)
            where TDto : new()
        => Task.Factory.StartNew(() => _SQLiteConnection.Delete<TDto>(primaryKey) > 0);

        public Task<List<ClienteCellViewModel>> GetClientesAll()
        {
            return Task.Factory.StartNew(() =>
            {
                var sql = new StringBuilder();
                sql.Append(" SELECT ");
                sql.Append(" Cliente.Id, ");
                sql.Append(" Cliente.ApelidoNomeFantasia, ");
                sql.Append(" Cliente.NomeCompletoRazaoSocial ");
                sql.Append(" FROM ");
                sql.Append(" Cliente ");

                //sql.Append(" WHERE ");
                //sql.Append(" .... = ? ");

                return _SQLiteConnection.Query<ClienteCellViewModel>(sql.ToString());
            });
        }

        //
        public Task<List<ClienteDto>> GetClientesSincronizar()
        {
            return Task.Factory.StartNew(() =>
            {
                return _SQLiteConnection.Table<ClienteDto>().Where(lbda => lbda.Sincronizado == null).ToList();
            });
        }
    }
}
