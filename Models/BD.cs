using Microsoft.Data.SqlClient;
using Dapper;
public class BD{
    int Login(string email, string contraseña){
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            int aux;
            string query = "SELECT * FROM Usuario WHERE Contraseña = pContraseña AND Email = pEmail";


        }
    }
}