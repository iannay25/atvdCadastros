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
        public Empresa()
        {
            InitializeComponent();
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
                empresa.RegimeTributario = panelRegime.Text;
                empresa.Endereco = cb_enderecocom.Text;
                empresa.Tipo = panelTipo.Text;
                empresa.PorteEmpresa = panelPorte.Text;
                empresa.NaturezaJur = cb_naturezajur.Text;
                empresa.Capital = double.Parse(tx_capital.Text);
             
            Inserir(empresa);

        }
        public string RadioRegime()
        {
            string radio = "";
            foreach(Control ctrl in panelRegime.Controls)
            {
                if(ctrl is RadioButton rb && rb.Checked)
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

                var comando = conexao.Comando("INSERT INTO Empresa (nome_emp, razao_social_emp, nome_fantasia_emp, telefone_emp, cnpj_emp, cpf_emp, data_emp, situacao_cadas_emp, regime_tributario_emp, endereco_emp, porte_empresa_emp, natureza_juridica_emp, capital_social_emp) VALUES (@nome, @razao_social, @nome_fantasia, @telefone, @cnpj, @cpf, @data, @situacao_cadas, @regime_tributario, @endereco, @porte_empresa, @natureza_juridica, @capital_social)");

                comando.Parameters.AddWithValue("@nome", empresa.NomePropietario);
                comando.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.NomeFantasia);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@cpf", empresa.Cpf);
                comando.Parameters.AddWithValue("@data", empresa.Data);
                comando.Parameters.AddWithValue("@situacao_cadas", empresa.SituacaoCads);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.RegimeTributario);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
