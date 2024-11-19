using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // . -> 127.0.0.1
            // localhost -> 127.0.0.1
            // 127.0.0.1
            // DEKSTOP-... -> 127.0.0.1
            // \\SQLEXPRESS
            // User Id=Nikolay;Password=12345

            string connectionString = "Server=.;Database=SoftUni_2;Integrated Security=true";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string command1 = "SELECT COUNT(*) FROM [Employees]";
                SqlCommand sqlCommand1 = new SqlCommand(command1, sqlConnection);
                int result = (int)sqlCommand1.ExecuteScalar();
                Console.WriteLine(result);

                string command2 = "SELECT [FirstName], [LastName], [Salary] FROM [Employees] WHERE FirstName LIKE 'N%'";
                SqlCommand sqlCommand2 = new SqlCommand(command2, sqlConnection);
                using (SqlDataReader reader = sqlCommand2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //string firstName = (string)reader[0];
                        string firstName = (string)reader["FirstName"];
                        //string lastName = (string)reader[1];
                        string lastName = (string)reader["LastName"];
                        decimal salary = (decimal)reader["Salary"];

                        Console.WriteLine(firstName + " " + lastName + " => " + salary);
                    }
                }
                
                SqlCommand updateSalaryCommand = new SqlCommand("UPDATE Employees SET Salary = Salary * 1.10", sqlConnection);
                int updatedRows = updateSalaryCommand.ExecuteNonQuery();

                Console.WriteLine($"Salary updated for {updatedRows} employees");

                var reader2 = sqlCommand2.ExecuteReader();
                using (reader2)
                {
                    while (reader2.Read())
                    {
                        string firstName = (string)reader2["FirstName"];
                        string lastName = (string)reader2["LastName"];
                        decimal salary = (decimal)reader2["Salary"];

                        Console.WriteLine(firstName + " " + lastName + " => " + salary);
                    }
                }

                //For security and anti-hacking

                /*Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM [Users] WHERE Username = '@Username' AND Password = '@Password'");
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);*/

                sqlConnection.Dispose();
            }

            Console.ReadLine();
        }
    }
}