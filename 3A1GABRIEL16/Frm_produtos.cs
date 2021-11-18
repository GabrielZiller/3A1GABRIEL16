using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A1GABRIEL16
{
    public partial class Frm_produtos : Form
    {
        public Frm_produtos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.modelo = txtModelo.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.modelo = txtModelo.Text;
            obj.preco = Convert.ToDouble(txtPreco.Text);
            obj.Alterar();
            MessageBox.Show("Alterado com Sucesso!");
            txtId.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtModelo.Clear();
            txtPreco.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_tipo Frm_tipo = new Frm_tipo();
            Frm_tipo.ShowDialog();
        }
    }
}
