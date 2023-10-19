using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Recu_Paralela
{
    public partial class Form2 : Form
    {
        ContatoRepository _contatoRepository;
        public Form2()
        {
            InitializeComponent();
        }
        private void CarregarProdutos()
        {
            _contatoRepository = new ContatoRepository();
            dtgContatos.DataSource = _contatoRepository.ObterTodos();
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
    }
}
