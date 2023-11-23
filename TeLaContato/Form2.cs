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
            _ContatoRepository = new ContatoRepository();
        }
        private void CarregarProdutos()
        {
            _ContatoRepository = new ContatoRepository();
            gvContatos.DataSource = _contatoRepository.ObterTodos();
        }

        private void btnRegarregar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;

            Button? button = sender as Button;

            var novoContato = new Contato(nome);

            var cargoRepository = new ContatoRepository();

            switch (button.Text)
            {
                case "Cadastrar":
                    {
                        var resultado = ContatoRepository.Inserir(novoContato);

                        if (resultado)
                        {
                            MessageBox.Show(" Cadastrado com Sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Verifique e Tente Novamente.");
                        }
                        break;
                    }
                case "Atualizar":
                    {
                        var resultado = ContatoRepository.Atualizar(novoContato, id);
                        if (resultado)
                        {
                            MessageBox.Show(" Atualizado com Sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Verifique e Tente Novamente.");
                        }
                        break;
                    }
                default:
                    break;
            }
            var resultado = ContatoRepository.Inserir(novoContato);

            if (resultado)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar o contato");
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
