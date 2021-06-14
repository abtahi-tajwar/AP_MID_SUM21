using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models.Database
{    
    public class Database
    {
        public SqlConnection conn;
        Admins admins { get; set; }
        Students students { get; set; }
        Departments departments { get; set; }
        public Database()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\University\ATP.Net\MID\Works\June14ClassPerformance\June14ClassPerformance\App_Data\Database1.mdf;Integrated Security=True");
            this.admins = new Admins(conn);
            this.students = new Students(conn);
            this.departments = new Departments(conn);
        }
        public bool verifyAdmin(Admin admin)
        {
            return admin.verifyAdmin(this.admins);
        }
        public List<Student> getAllStudents()
        {
            return students.getAll();
        }
        public bool addStudent(Student student)
        {
            return students.add(student);
        }
        public bool editStudent(Student student)
        {
            return students.edit(student);
        }
        public bool deleteStudent(int id)
        {
            return students.delete(id);
        }
        public Student getStudent(int id)
        {
            return students.get(id);
        }
        
    }
}