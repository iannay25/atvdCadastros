using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd_figma
{
    internal class Conexao
    {
        private string _servidor = "localhost";
        private string _porta = "3360";
        private string _usuario = "root";
        private string _senha = "root";
        private string _bancoDadosNome = "Empressa_bd";
        private MySqlConnection connection;
        private MySqlCommand command;

        public Conexao()
        {
          try

            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};part={_porta};user={_usuario};password={_senha}");
            }
            catch ( Exception e )
            {
                throw e;
            }
        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = comando;
                return command;
            }
            catch ( Exception e ) 
            {
                throw e; 
            }
        }

    }
}
