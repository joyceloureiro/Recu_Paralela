using Aplicacao.Repository.Entidades.Comum;
using Datatbase.Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Recu_Paralela
{
    public partial class Form2 : Form
    {
        private readonly IContatoRepository _ContatoRepository;
        public Form2()
        {
            InitializeComponent();
            
        }
        private void CarregarProdutos()
        {
            var _contatoRepository = new ContatoRepository();
            gvContatos.DataSource = _contatoRepository.ObterTodos();
        }

        private void btnRegarregar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = mkbTelefone.Text;
            string email = txtEmail.Text;
            string dataNascimento = dtpDtNascimento.Text;
            string uf = txtUf.Text;
            string cidade = txtCidade.Text;
            string numero = txtNumero.Text;
            string bairro = txtbairro.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;
            string datacontato = mtbDataContato.Text;

            var novoContato = new Contato( nome, telefone, email, dataNascimento, uf, cidade, numero, empresa, bairro, cargo);   
            var contato = new ContatoRepository();

            Button? button = sender as Button;


            switch (button.Text)
            {
                case "Atualizar":
                    {
                        contato.Atualizar(novoContato);

                        var resultado = contato.Atualizar(novoContato);

                        if (resultado)
                        {
                            MessageBox.Show("Cargo cadastrado com sucesso!!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel gravar o cargo!!");
                        }
                        //cadastar
                        break;
                    }
                case "Salvar":
                    {
                        contato.Incluir(novoContato);
                        MessageBox.Show("Cargo alterado com sucesso!!");
                        //cadastar
                        break;
                    }
                default:
                    break;
            }
            
          
        }

        private void gvContatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var contatoRepository = new ContatoRepository();
            DataGridViewRow row = gvContatos.Rows[e.RowIndex];

            if (gvContatos.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = contatoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                    MessageBox.Show("Registro deletado com sucesso!!");
                };
                return;
            }
            if (e.RowIndex >= 0)
            {
                gvContatos.Show();
                btnSalvar.Text = "Atualizar";
                txtCargo.Text = row.Cells[2].Value.ToString();
                
            }

            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }

        }
    }

    internal interface IContatoRepository
    {
    }
}
