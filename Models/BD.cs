using Microsoft.Data.SqlClient;
using Dapper;
public static class BD{
    private static string _connectionString = @"Server=localhost; DataBase=Presentacion; Integrated Security=True; TrustServerCertificate=True;";
    public static int Login(string email, string contrasena){
        int aux = -1;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Usuario WHERE Contrasena = @contrasena AND Email = @email";
            aux = connection.QueryFirstOrDefault<int>(query, new {contrasena, email});

        }
        return aux;
    }

    public static Usuario GetUsuario(int id){
        Usuario aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM Usuario WHERE Id = @id";
            aux = connection.QueryFirstOrDefault<Usuario>(query, new {id});

        }
        return aux;
    }

    public static List<DatoFamiliar> GetDatoFamiliar(int id){
        List<DatoFamiliar> aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM DatoFamiliar WHERE Id = @id";
            aux = connection.Query<DatoFamiliar>(query, new {id}).ToList();

        }
        return aux;
    }
        public static List<DatoInteres> GetDatoInteres(int id) {
            List<DatoInteres> aux;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            
            string query = "SELECT * FROM DatoFamiliar WHERE Id = @id";
            aux = connection.Query<DatoInteres>(query, new {id}).ToList();

        }
        return aux;
        }

}