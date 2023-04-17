using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Program
{
    public static void Main()
    {
        string connectionString = "Server=127.0.0.1;Database=projetoindicators;Uid=root;Pwd=123456789;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            // Criar a tabela 'usuarios'
            string query = "CREATE TABLE usuarios (id INT AUTO_INCREMENT PRIMARY KEY, nome VARCHAR(50), senha VARCHAR(50), setor VARCHAR(50))";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Tabela 'usuarios' criada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar a tabela 'usuarios': " + ex.Message);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
