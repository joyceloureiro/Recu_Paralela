﻿using System;
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
           
            
           
            if (gvContatos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gvContatos.SelectedRows[0];
                int idContato = Convert.ToInt32(row.Cells["Id"].Value);

                var resultado = _contatoRepository.

            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int idContato = Convert.ToInt32(row.Cells["Id"].Value);

                // Sua string de conexão com o banco de dados
                string connectionString = "Data Source=seu_servidor;Initial Catalog=sua_base_de_dados;Integrated Security=True";

                // Instancie o repositório de contato
                ContatoRepository contatoRepository = new ContatoRepository(connectionString);

                // Chame o método de exclusão
                contatoRepository.ExcluirContato(idContato);

                // Remova a linha do DataGridView
                dataGridView1.Rows.Remove(row);
                MessageBox.Show("Contato excluído com sucesso!");
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
