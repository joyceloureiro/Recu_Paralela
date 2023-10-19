using Aplicacao.Entidades.Comum;

namespace Datatbase.Repositorio
{
    internal class SqlConnection : IDisposable
    {
        private string conexao;

        public SqlConnection(string conexao)
        {
            this.conexao = conexao;
        }

        internal int Execute(string sql, Contato produto)
        {
            throw new NotImplementedException();
        }

        internal int Execute(string sql, DynamicParameters parametros)
        {
            throw new NotImplementedException();
        }

        internal Contato QuerySingleOrDefault<T>(string sql, DynamicParameters parametros)
        {
            throw new NotImplementedException();
        }
    }
}