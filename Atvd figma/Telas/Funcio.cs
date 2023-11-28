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
    public partial class Funcio : Form
    {
        private List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public Funcio()
        {
            InitializeComponent();
            /* Inserir();*/
            Consultar();
        }

        public void Inserir()
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

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM funcionario");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    Funcionario fun = new Funcionario();
                    fun.Id = DAOHelper.GetString(leitor,"id_fun");
                    fun.Nome = DAOHelper.GetString(leitor, "nome_fun" );
                    fun.Datanasc = DAOHelper.GetString(leitor, "data_nasc_fun");
                    fun.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    fun.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    fun.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    fun.Email = DAOHelper.GetString(leitor, "email_fun");
                    fun.Endereco = DAOHelper.GetString(leitor, "endereco_fun");
                    fun.EstadoCivil = DAOHelper.GetString(leitor, "estado_civil_fun");
                    fun.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    fun.Salario = DAOHelper.GetDouble(leitor, "salario_fun");

                    listaFuncionarios.Add(fun); 
                }
                dataGridViewFuncio.DataSource = null;
                dataGridViewFuncio.Refresh();
                dataGridViewFuncio.DataSource = listaFuncionarios;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = tx_id.Text;
            funcionario.Nome = tx_nome.Text;
            funcionario.Datanasc = masked_data.Text;
            funcionario.Cpf = masked_cpf.Text;
            funcionario.Rg = tx_rg.Text;
            funcionario.Telefone = masked_telefone.Text;
            funcionario.EstadoCivil = cb_estadocivil.Text;
            funcionario.Funcao = cb_funcao.Text;
            funcionario.Email = tx_email.Text;
            funcionario.Endereco = tx_endereco.Text;
            funcionario.Salario = double.Parse(tx_salario.Text);

            Cpf.ValidaCPF(masked_cpf.Text);
            MessageBox.Show(Cpf.ValidaCPF(masked_cpf.Text).ToString());
            Cpf.ValidaCPF(tx_email.Text);
            MessageBox.Show(Cpf.ValidaCPF(tx_email.Text).ToString());

            Inserir(funcionario);


        }
        private void Inserir(Funcionario funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Funcionario (nome_fun, data_nasc_fun, cpf_fun, rg_fun, telefone_fun, email_fun, endereco_fun, estado_civil_fun, funcao_fun, salario_fun) VALUES (@nome, @data_nasc, @cpf, @rg, @telefone, @email, @endereco, @estado_civil, @funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@data_nasc", funcionario.Datanasc);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", funcionario.Email);
                comando.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@estado_civil", funcionario.EstadoCivil);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário Cadastrado com sucesso!!", "OK", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }


       

       
    }

