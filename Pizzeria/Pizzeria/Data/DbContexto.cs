using Pizzeria.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Data
{
    public class DbContexto
    {
        public readonly SQLiteAsyncConnection cnx;

        public DbContexto(string data)
        {
            cnx = new SQLiteAsyncConnection(data);
            cnx.CreateTableAsync<Personas>().Wait();
        }
        public async Task<int> ingresar(Personas registro)
        {
            return await cnx.InsertAsync(registro);
        }
        public async Task<int> eliminar(Personas registro)
        {
            return await cnx.DeleteAsync(registro);
        }
        public async Task<List<Personas>> GetPersonas()
        {
            return await cnx.Table<Personas>().ToListAsync();
        }
        public async Task<int> modificar(Personas registro)
        {
            return await cnx.UpdateAsync(registro);

        }

    }
}
