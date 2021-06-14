using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models.Database
{
    
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        
        public bool add(Student student)
        {
            string query = $"INSERT INTO Students VALUES ('{student.Name}', '{student.DOB}', {student.Credit}, '{student.CGPA}', '{student.Dept_Id}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            this.conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public bool edit(Student student)
        {
            string query = $"UPDATE Students SET Name='{student.Name}', DOB='{student.DOB}', Credit={student.Credit}, CGPA='{student.CGPA}', Dept_Id={student.Dept_Id} WHERE Id={student.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            this.conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public bool delete(int id)
        {
            string query = $"DELETE FROM Students WHERE Id = {id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            this.conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        public List<Student> getAll()
        {         
            List<Student> students = new List<Student>();
            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            this.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Student st = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    DOB = reader.GetString(reader.GetOrdinal("DOB")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetString(reader.GetOrdinal("CGPA")),
                    Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id"))
                };
                students.Add(st);
            }
            return students;
        }
        public Student get(int id)
        {
            Student student;
            string query = $"SELECT * FROM Students WHERE Id = {id}";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            this.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            student = new Student()
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                DOB = reader.GetString(reader.GetOrdinal("DOB")),
                Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                CGPA = reader.GetString(reader.GetOrdinal("CGPA")),
                Dept_Id = reader.GetInt32(reader.GetOrdinal("Dept_Id"))
            };

            return student;
        }
    }
}