using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Finance.Models;
using System.Threading.Tasks;

namespace Finance.Data
{
    public class FinanceDB
    {
        readonly SQLiteAsyncConnection db;
        public FinanceDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);

            db.CreateTableAsync<Cost>().Wait();
        }

        public Task<List<Cost>> GetCostsAsync()
        {
            return db.Table<Cost>().ToListAsync();
        }

        public Task<Cost> GetCostAsync(int id)
        {
            return db.Table<Cost>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveCostAsunc(Cost cost)
        {
            if (cost.Id != 0)
            {
                return db.UpdateAsync(cost);
            }
            else
            {
                return db.InsertAsync(cost);
            }
        }
        public Task<int> DeleteCostAsync(Cost cost)
        {
            return db.DeleteAsync(cost);
        }
    }
}
