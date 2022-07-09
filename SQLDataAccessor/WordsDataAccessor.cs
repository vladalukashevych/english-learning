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
    public class WordsDataAccessor : IWordsDataAccessor
    {
        private static string sqlConnectionString = @"Server=localhost\SQLEXPRESS01;Database=EnglishLearningDB;Integrated Security=SSPI;";

        public void CreateWord(Word word)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string insertQuery = @"INSERT INTO[dbo].[Words]([Term], [Definition], [SetId]) VALUES(@Term, @Definition, @SetId)";

                connection.Execute(insertQuery,
                    new
                    {
                        word.Term,
                        word.Definition,
                        word.SetId
                    });
            }
        }

        public void DeleteWord(int id)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string deleteQuery = @"DELETE FROM [dbo].[Words] WHERE Id = @Id";

                connection.Execute(deleteQuery, new { id });
            }
        }

        public void EditWord(Word word)
        {
            using (var connection = new SqlConnection(sqlConnectionString))
            { 
                string updateQuery = @"UPDATE [dbo].[Words] SET Term = @Term, Definition = @Definition WHERE Id = @Id";

                var result = connection.Execute(updateQuery, new
                {
                    word.Term,
                    word.Definition,
                    word.Id
                });
            }
        }

        public Word GetWordById(int id)
        {
            Word word = new Word();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Words] WHERE Id = @Id";

                word = connection.Query<Word>(selectQuery, new { id }).FirstOrDefault();
            }
            return word;
        }

        public List<Word> GetWordsFromSet(int id)
        {
            List<Word> words = new List<Word>();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Words] WHERE SetId = @id";

                words = connection.Query<Word>(selectQuery, new { id }).ToList();
            }
            return words;
        }
    }
}
