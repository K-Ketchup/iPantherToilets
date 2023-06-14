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

        public static async Task AddReview(string username, double stars, string text)
        {
            await Init();

            var review = new Review() 
            { 
                Username = username, 
                Stars = stars, 
                Text = text 
            };

            var id = await db.InsertAsync(review);
        }

        public static async Task RemoveReview(int id)
        {
            await Init();

            await db.DeleteAsync<Review>(id);
        }

        public static async Task<IEnumerable<Review>> GetReview()
        {
            await Init();

            var review = await db.Table<Review>().ToListAsync();
            return review;
        }

    }
}
