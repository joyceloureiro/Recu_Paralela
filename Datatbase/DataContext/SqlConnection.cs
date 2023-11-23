using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatbase.DataContext
{
    internal static class SqlServerConnection
    {
        /// <summary>
        /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
        /// </summary>
        internal static string Conexao => "Data Source=.\\SQLEXPRESS;Initial Catalog=AdvocaciaABC;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";
        Data Source =.\SQLEXPRESS;Initial Catalog = AdvocaciaABC; User ID = sa; Password=***********
        
    }
}
