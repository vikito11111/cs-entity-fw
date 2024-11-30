using Microsoft.Data.SqlClient;

string connectionString = "Server=.;Database=SoftUni;Integrated Security=true;TrustServerCertificate=True";

using (SqlConnection sqlConnection = new SqlConnection(connectionString))
{
    sqlConnection.Open();

    string command = "SELECT COUNT(*) FROM [Employees]";
    string secondCommand = "SELECT [FirstName], [LastName] FROM [Employees] WHERE FirstName LIKE 'N%'";
    string thirdCommand = "UPDATE Employees SET Salary = Salary * 1.10";

    var sqlCommand = new SqlCommand(command, sqlConnection);

    var result = sqlCommand.ExecuteScalar();   // returns an object

    Console.WriteLine(result);

    var secondSqlCommand = new SqlCommand(secondCommand, sqlConnection);

    using (SqlDataReader reader = secondSqlCommand.ExecuteReader())   // returns a special type of SqlDataReader which returns object
    {
        while (reader.Read())
        {
            string firstName = (string)reader[0];   // reader["FirstName"]
            string lastName = (string)reader["LastName"];

            Console.WriteLine(firstName + " " + lastName);
        }
    }

    var thirdSqlCommand = new SqlCommand(thirdCommand, sqlConnection);

    int updatedRows = thirdSqlCommand.ExecuteNonQuery();

    Console.WriteLine($"Salary updated for {updatedRows} employee's salary");
}