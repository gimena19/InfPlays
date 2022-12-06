using AppMovil.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppMovil.Data
{
    public class DataBaseQuery
    {
        readonly SQLiteAsyncConnection _database;
        public DataBaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>().Wait();
        }
        //Insertar
        #region CRUD
        public Task<List<User>> QueryUsers(String query)
        {
            return _database.QueryAsync<User>(query);
        }

        public Task<List<User>> GetUsers()
        {
            return _database.Table<User>().ToListAsync();
        }
        
        //Actualizar
        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }
        //eliminar
        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }

        #endregion


    }
}
