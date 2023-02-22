using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDemo
{
    class StudentDal
    {
        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;initial catalog=ETrade; integrated security=true");

        public List<Student> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Student",_connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirsName = reader["FirsName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Number = Convert.ToInt32(reader["Number"])
                };
                students.Add(student);
            }
          
            _connection.Close();
            return students;

        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Student student)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Student values(@FirsName,@LastName,@Number)",_connection);
            command.Parameters.AddWithValue("@FirsName", student.FirsName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Number", student.Number);
            command.ExecuteNonQuery();
        }

        public void Update(Student student)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Student set FirsName=@FirsName,LastName=@LastName,Number=@Number Where Id=@id",_connection);
            command.Parameters.AddWithValue("@FirsName", student.FirsName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Number", student.Number);
            command.Parameters.AddWithValue("@Id", student.Id);
            command.ExecuteNonQuery();
        }
    }
}
