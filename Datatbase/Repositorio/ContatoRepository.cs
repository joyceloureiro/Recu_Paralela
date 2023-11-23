using Datatbase.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao.Repository;
using Aplicacao.Repository.Entidades.Comum;

namespace Datatbase.Repositorio
{
    public class ContatoRepository : IContatoRepository
    {
        public bool Atualizar(Contato contato)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    string sql = @"UPDATE Contato
                                 SET  Nome = @Nome,
                                      DataNascimento = @DataDeNascimento,
                                      Cidade = @Cidade,
                                      Bairro = @Bairro,
                                      Rua = @Rua,
                                      Numero = @Numero,
                                      Email = @Email,
                                      Telefone = @Telefone,
                                      Cargo = @Cargo,
                                      Empresa = @Empresa,
                                      DataDoContato = @DataDoContato
                                 WHERE Id = @Id";


                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@nome", contato.Nome);
                    parametros.Add("@dataDeNascimento", contato.DataNascimento);
                    parametros.Add("@cidade", contato.Cidade);
                    parametros.Add("@bairro", contato.Bairro);
                    parametros.Add("@numero",contato.Numero);
                    parametros.Add("@uf", contato.Uf);
                    parametros.Add("@email", contato.Email);
                    parametros.Add("@telefone", contato.Telefone);
                    parametros.Add("@cargo", contato.Cargo);
                    parametros.Add("@empresa", contato.Empresa);
                    parametros.Add("@dataDoContato", contato.DataDoContato);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Deletar(Contato produto)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = @"DELETE FROM Contato WHERE Id = @id";

                    var parametros = new DynamicParameters();
                    parametros.Add("@id", produto.Id);

                    var linhasAfetadas = connection.Execute(sql, parametros);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Incluir(Contato produto)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    string sql = @"INSERT INTO Contato
                   (Nome, DataNascimento, Uf, Cidade, Bairro, Rua, Numero, Email, Telefone, Cargo, Empresa, DataDoContato)
                   VALUES
                   (@Nome, @DataDeNascimento, @Uf, @Cidade, @Bairro, @Rua, @Numero, @Email, @Telefone, @Cargo, @Empresa, @DataDoContato)";


                    var linhasAfetadas = connection.Execute(sql, produto);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                // Faça algo com a exceção, como logar ou lançar uma exceção personalizada com uma mensagem descritiva
                throw new Exception("Erro ao incluir Contato.", ex);
            }

        }

      

        public List<Contato> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = "SELECT * FROM Contato";

                    var cargos = connection.Query<Contato>(sql);

                    return cargos.ToList();

                }
            }
            catch (Exception ex)
            {
                // Faça algo com a exceção, como logar ou lançar uma exceção personalizada com uma mensagem descritiva
                throw new Exception("Erro ao obter clientes.", ex);
            }
        }
        public Contato ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {

                    //Comando Sql a ser executado no banco de dados use @ para criar espaços
                    //reservados de substituição
                    var sql = "SELECT * FROM Cargos WHERE Id = @id";

                    //Cria os parametros 
                    var parametros = new DynamicParameters();
                    parametros.Add("@id", id);

                    //Executa o comando no banco e substitui o @id pelo int id do parametro do Metodo
                    //E retorna uma única linha do banco QuerySingleOrDefault.
                    var cargos = connection.QuerySingleOrDefault<Contato>(sql, parametros);

                    return cargos;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

       

        public List<Contato> ObterTodosPorNome(int Nome)
        {
            throw new NotImplementedException();
        }

        public List<Contato> ObterTodosPorEmail(int Email)
        {
            throw new NotImplementedException();
        }

        public List<Contato> ObterTodosPorTelefone(int Telefone)
        {
            throw new NotImplementedException();
        }

        public object Deletar(int idContato)
        {
            throw new NotImplementedException();
        }
    }
}
