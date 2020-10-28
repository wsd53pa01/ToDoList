using Dapper;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Npgsql;
using ToDoList.Models;
using Microsoft.Extensions.Configuration;

namespace ToDoList.Repository
{
    public class ToDoRepository: IRepository<ToDo>
    {
        private readonly string connectionString;
        public ToDoRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
        }
        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }

        public IEnumerable<ToDo> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ToDo>("SELECT * FROM TODOLIST ORDER BY @seq");
            }
        }

        public ToDo FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<ToDo>("SELECT * FROM TODOLIST WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public void Add(ToDo job)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO TODOLIST (seq, title) VALUES(@Seq, @Title)", job);
            }
        }

        public void Update(ToDo job)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("UPDATE TODOLIST SET seq= @Seq, title= @Title WHERE id= @Id", job);
            }
        }

        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("UPDATE TODOLIST SET seq= 0 WHERE id= @Id", new { Id = id });
                //dbConnection.Execute("DELETE FROM TODOLIST WHERE Id=@Id", new { Id = id });
            }
        }
    }
}
