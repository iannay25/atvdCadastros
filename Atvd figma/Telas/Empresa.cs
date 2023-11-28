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
    public partial class Empresa : Form
    {
        private List<ConsultarEmpresa> listaEmpresa = new List<ConsultarEmpresa>();
        public Empresa()
        {
            InitializeComponent();
            Consultar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            ConsultarEmpresa empresa = new ConsultarEmpresa();
            empresa.NomePropietario = tx_nomeEm.Text;
            empresa.RazaoSocial = tx_razaosocial.Text;
            empresa.NomeFantasia = tx_nomefantasia.Text;
            empresa.Telefone = mask_telefone.Text;
            empresa.Cnpj = mask_cpf.Text;
            empresa.Cpf = mask_cpf.Text;
            empresa.Data = mask_datainicio.Text;
            empresa.SituacaoCads = cb_situcaocadas.Text;
            empresa.RegimeTributario = RadioRegime();
            empresa.Endereco = cb_enderecocom.Text;
            empresa.Tipo = RadioTipo();
            empresa.PorteEmpresa = RadioPorte();
            empresa.NaturezaJur = cb_naturezajur.Text;
            empresa.Capital = double.Parse(tx_capital.Text);

            Inserir(empresa);
            Consultar();
            

        }
        public string RadioRegime()
        {
            string radio = "";
            foreach (Control ctrl in panelRegime.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }
            return radio;
        }
        public string RadioTipo()
        {
            string radio = "";
            foreach (Control ctrl in panelTipo.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }
            return radio;
        }
        public string RadioPorte()
        {
            string radio = "";
            foreach (Control ctrl in panelPorte.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
            }
            return radio;
        }
        private void Inserir(ConsultarEmpresa empresa)
        {
            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO Empresa (nome_emp, razao_social_emp, nome_fantasia_emp, telefone_emp, cnpj_emp, cpf_emp, data_emp, situacao_cadas_emp, regime_tributario_emp, tipo_emp, endereco_emp, porte_empresa_emp, natureza_juridica_emp, capital_social_emp) VALUES (@nome, @razao_social, @nome_fantasia, @telefone, @cnpj, @cpf, @data, @situacao_cadas, @regime_tributario, @tipo, @endereco, @porte_empresa, @natureza_juridica, @capital_social)");

                comando.Parameters.AddWithValue("@nome", empresa.NomePropietario);
                comando.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.NomeFantasia);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@cpf", empresa.Cpf);
                comando.Parameters.AddWithValue("@data", empresa.Data);
                comando.Parameters.AddWithValue("@situacao_cadas", empresa.SituacaoCads);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.RegimeTributario);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@endereco", empresa.Endereco);
                comando.Parameters.AddWithValue("@porte_empresa", empresa.PorteEmpresa);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.NaturezaJur);
                comando.Parameters.AddWithValue("@capital_social", empresa.Capital);

                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Empresa Cadastrada com sucesso!!", "OK", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Conexao();

                var comando = conexao.Comando("SELECT * FROM Empresa");

                var leitor = comando.ExecuteReader();

                string resultado = null;

                while (leitor.Read())
                {
                    ConsultarEmpresa empresa = new ConsultarEmpresa();
                    empresa.NomePropietario = DAOHelper.GetString(leitor, "nome_emp");
                    empresa.RazaoSocial = DAOHelper.GetString(leitor, "razao_social_emp");
                    empresa.NomeFantasia = DAOHelper.GetString(leitor, "nome_fantasia_emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.Cpf = DAOHelper.GetString(leitor, "cpf_emp");
                    empresa.Data = DAOHelper.GetString(leitor, "data_emp");
                    empresa.SituacaoCads = DAOHelper.GetString(leitor, "situacao_cadas_emp");
                    empresa.RegimeTributario = DAOHelper.GetString(leitor, "regime_tributario_emp");
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.Endereco = DAOHelper.GetString(leitor, "endereco_emp");
                    empresa.PorteEmpresa = DAOHelper.GetString(leitor, "porte_empresa_emp");
                    empresa.NaturezaJur = DAOHelper.GetString(leitor, "natureza_juridica_emp");
                    empresa.Capital = DAOHelper.GetDouble(leitor, "capital_social_emp");


                    listaEmpresa.Add(empresa);
                }
                dataGridViewEmpresa.DataSource = null;
                dataGridViewEmpresa.Refresh();
                dataGridViewEmpresa.DataSource = listaEmpresa;
            }

            catch
            {
                throw;
            }
        }
    
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_naturezajur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empresa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
