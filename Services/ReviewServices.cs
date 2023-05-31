using iPantherToilets.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPantherToilets.Services
{
    public static class ReviewServices
    {
        static SQLiteAsyncConnection db;

        static async Task Init()
        {
            if(db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Review>();
        }

        public static async Task AddReview(int stars)
        {
            await Init();
        }

        public static async Task RemoveReview(int id)
        {
            await Init();
        }

        public static async Task GetReview()
        {
            await Init();
        }

    }
}
