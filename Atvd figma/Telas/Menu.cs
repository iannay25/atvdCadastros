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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void funcionario_Click(object sender, EventArgs e)
        {
            Funcio TF = new Funcio();
            TF.ShowDialog();
        }

        private void Telaempresa_Click(object sender, EventArgs e)
        {
            
            Empresa TE = new Empresa();
            TE.ShowDialog();


        }
    }
}
