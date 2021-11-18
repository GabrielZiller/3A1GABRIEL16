using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3A1GABRIEL16
{
    public partial class Frm_tipo : Form
    {
        public Frm_tipo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipo obj = new Tipo();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtTipo.Text;
            obj.tipo = txtNome.Text;
            obj.Cadastrar();
            MessageBox.Show("Cadastro Efetuado!");
            txtId.Clear();
            txtTipo.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Tipo obj = new Tipo();
            obj.id = (int)Convert.ToInt64(txtId.Text);
            obj.nome = txtTipo.Text;
            obj.tipo = txtNome.Text;
            obj.Alterar();
            MessageBox.Show("Alteração Efetuada!");
            txtId.Clear();
            txtTipo.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tipo obj = new Tipo();
            obj.id = int.Parse(txtId.Text);
            obj.Excluir();
            MessageBox.Show("Excluído com Sucesso!");
            txtId.Clear();
            txtTipo.Clear();
            txtNome.Clear();
            dataGridView1.DataSource = obj.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Tipo obj = new Tipo();
            dataGridView1.DataSource = obj.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_produtos Frm_produtos = new Frm_produtos();
            Frm_produtos.ShowDialog();
        }
    }
}
