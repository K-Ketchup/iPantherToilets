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
        static async Task Init()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            var db = new SQLiteConnection(databasePath);
        }

        public static async Task AddReview(int stars)
        {

        }

        public static async Task RemoveReview(int id)
        {

        }

        public static async Task GetReview()
        {

        }

    }
}
