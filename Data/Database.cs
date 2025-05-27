using System.Collections.Generic;
using System.Data.SQLite;
using ProductionRequestManager.Models;

namespace ProductionRequestManager.Data
{
    public static class Database
    {
        private const string ConnectionString = "Data Source=requests.db;Version=3;";

        public static void Initialize()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Requests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Client TEXT,
                    Description TEXT,
                    Status TEXT
                )";
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Request> GetAllRequests()
        {
            var list = new List<Request>();
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT * FROM Requests", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Request
                    {
                        Id = reader.GetInt32(0),
                        Client = reader.GetString(1),
                        Description = reader.GetString(2),
                        Status = reader.GetString(3)
                    });
                }
            }
            return list;
        }

        public static void AddRequest(Request r)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("INSERT INTO Requests (Client, Description, Status) VALUES (@c, @d, @s)", conn);
                cmd.Parameters.AddWithValue("@c", r.Client);
                cmd.Parameters.AddWithValue("@d", r.Description);
                cmd.Parameters.AddWithValue("@s", r.Status);
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateRequest(Request r)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("UPDATE Requests SET Client = @c, Description = @d, Status = @s WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@c", r.Client);
                cmd.Parameters.AddWithValue("@d", r.Description);
                cmd.Parameters.AddWithValue("@s", r.Status);
                cmd.Parameters.AddWithValue("@id", r.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteRequest(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Requests WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
