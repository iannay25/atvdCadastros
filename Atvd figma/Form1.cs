using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atvd_figma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inserir();
            Consultar();
        }

        void Inserir()
        {
            var nomeFunc = "Iannay Luiza da Silva";
            var cpfFunc = "040.107.302-35";

            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO funcionario (nome_func, cpf_func) VALUES (@nome, @cpf)");

                comando.Parameters.AddWithValue("@nome", nomeFunc);
                comando.Parameters.AddWithValue("@cpf", cpfFunc);

                var resultado = comando.ExecuteNonQuery();

                if(resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM funcionario");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while(leitor.Read())
                {
                    resultado += "\n" + leitor.GetString("nome_func");
                }
                MessageBox.Show(resultado);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Funcionario funcionario = new Funcionario();
            string id = tx_id.Text;
            string nome = tx_nome.Text;
            DateTime datanasc = DateTime.Now;
            string cpf = masked_cpf.Text;
            string rg = tx_rg.Text;
            string telefone = masked_telefone.Text;
            string estadocivil = cb_estadocivil.Text;
            string funcao = cb_funcao.Text;
            string email = tx_email.Text;
            string endereco = tx_endereco.Text;
            double salario = double.Parse(tx_salario.Text);

            Cpf.ValidaCPF(masked_cpf.Text);
            MessageBox.Show(Cpf.ValidaCPF(masked_cpf.Text).ToString());
            Cpf.ValidaCPF(tx_email.Text);
            MessageBox.Show(Cpf.ValidaCPF(tx_email.Text).ToString());
    
        }

        private void tx_funcao_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_estadocivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {

            tx_id.Clear();
            tx_nome.Clear();
            masked_cpf.Clear();
            masked_cpf.Clear();
            masked_data.Clear();
            tx_rg.Clear();
            masked_telefone.Clear();
            tx_email.Clear();
            tx_endereco.Clear();
            cb_estadocivil.Text = " ";
            cb_funcao.Text = " ";
            tx_salario.Clear();

        }
    }
}
