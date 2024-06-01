using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Assignment.Models;

namespace Third_Assignment.Repositories
{
    public class StudentRepository
    {
        public static Student GetStudent(string Username)
        {
            Student student = null;
            string sql = $"SELECT * FROM Student WHERE Username = '{Username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }

        public static Student GetStudent(int id)
        {
            Student student = null;
            string sql = $"SELECT * FROM Student WHERE StudentID = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                student = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return student;
        }

        private static Student CreateObject(SqlDataReader reader)
        {   
            int id = int.Parse(reader["StudentID"].ToString());
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            var student = new Student
            {
                StudentID = id,
                Username = username,
                Password = password
            };
            return student;
        }
    }
}
