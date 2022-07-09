using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Business.DataAccessors;
using Business.Entities;

namespace SQLDataAccessor
{
    public class SetsDataAccessor : ISetsDataAccessor
    {
        private static string sqlConnectionString = @"Server=localhost\SQLEXPRESS01;Database=EnglishLearningDB;Integrated Security=SSPI;";

        public int CreateSet(Set set)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string insertQuery = @"INSERT INTO[dbo].[Sets]([Title]) OUTPUT INSERTED.Id VALUES(@Title)";

                id = connection.QuerySingle<int>(insertQuery, new { set.Title});
            }
            return id;
        }

        public void DeleteSet(int id)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string deleteQuery = @"DELETE FROM [dbo].[Sets] WHERE Id = @Id";

                connection.Execute(deleteQuery, new { id });
            }
        }

        public void EditSet(Set set)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string updateQuery = @"UPDATE [dbo].[Sets] SET Title = @Title WHERE Id = @Id";

                var result = connection.Execute(updateQuery, new { set.Title, set.Id});
            }
        }

        public Set GetSetById(int id)
        {
            Set set = new Set();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Sets] WHERE Id = @Id";

                set = connection.Query<Set>(selectQuery, new { id }).FirstOrDefault();
            }
            return set;
        }

        public List<Set> GetSets()
        {
            List<Set> sets = new List<Set>();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Sets]";

                sets = connection.Query<Set>(selectQuery).ToList();
            }
            return sets;
        }

        public int SetCount()
        {
            int count;
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Sets]";

                count = (Int32)connection.ExecuteScalar(selectQuery);
            }
            return count;
        }

        public int WordsCountInSet(int id)
        {
            int count;
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Words] WHERE SetId = @id";

                count = (Int32)connection.ExecuteScalar(selectQuery, new { id });
            }
            return count;
        }
    }
}
