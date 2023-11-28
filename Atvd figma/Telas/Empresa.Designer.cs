namespace Atvd_figma
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nomefantasia = new System.Windows.Forms.TextBox();
            this.tx_razaosocial = new System.Windows.Forms.TextBox();
            this.tx_nomeEm = new System.Windows.Forms.TextBox();
            this.mask_datainicio = new System.Windows.Forms.MaskedTextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mask_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_naturezajur = new System.Windows.Forms.ComboBox();
            this.cb_situcaocadas = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panelRegime = new System.Windows.Forms.Panel();
            this.cb_enderecocom = new System.Windows.Forms.ComboBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panelTipo = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panelPorte = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tx_capital = new System.Windows.Forms.TextBox();
            this.cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelRegime.SuspendLayout();
            this.panelTipo.SuspendLayout();
            this.panelPorte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nomefantasia
            // 
            this.tx_nomefantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nomefantasia.Location = new System.Drawing.Point(12, 230);
            this.tx_nomefantasia.Name = "tx_nomefantasia";
            this.tx_nomefantasia.Size = new System.Drawing.Size(193, 24);
            this.tx_nomefantasia.TabIndex = 0;
            // 
            // tx_razaosocial
            // 
            this.tx_razaosocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_razaosocial.Location = new System.Drawing.Point(12, 171);
            this.tx_razaosocial.Name = "tx_razaosocial";
            this.tx_razaosocial.Size = new System.Drawing.Size(193, 24);
            this.tx_razaosocial.TabIndex = 1;
            // 
            // tx_nomeEm
            // 
            this.tx_nomeEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nomeEm.Location = new System.Drawing.Point(12, 106);
            this.tx_nomeEm.Name = "tx_nomeEm";
            this.tx_nomeEm.Size = new System.Drawing.Size(193, 24);
            this.tx_nomeEm.TabIndex = 2;
            // 
            // mask_datainicio
            // 
            this.mask_datainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_datainicio.Location = new System.Drawing.Point(31, 491);
            this.mask_datainicio.Mask = "0000-00-00";
            this.mask_datainicio.Name = "mask_datainicio";
            this.mask_datainicio.Size = new System.Drawing.Size(89, 24);
            this.mask_datainicio.TabIndex = 3;
            this.mask_datainicio.ValidatingType = typeof(System.DateTime);
            // 
            // mask_cpf
            // 
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(18, 423);
            this.mask_cpf.Mask = "000,000,000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(167, 24);
            this.mask_cpf.TabIndex = 4;
            // 
            // mask_cnpj
            // 
            this.mask_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cnpj.Location = new System.Drawing.Point(18, 360);
            this.mask_cnpj.Mask = "99,999,999/9999-99";
            this.mask_cnpj.Name = "mask_cnpj";
            this.mask_cnpj.Size = new System.Drawing.Size(167, 24);
            this.mask_cnpj.TabIndex = 5;
            // 
            // mask_telefone
            // 
            this.mask_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone.Location = new System.Drawing.Point(18, 301);
            this.mask_telefone.Mask = "(99) 00000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(167, 24);
            this.mask_telefone.TabIndex = 6;
            // 
            // cb_naturezajur
            // 
            this.cb_naturezajur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_naturezajur.FormattingEnabled = true;
            this.cb_naturezajur.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            " MEI – Microempreendedor Individual",
            " Sociedade Anônima",
            " Sociedade Simples Limitada",
            " Sociedade Limitada Unipessoal"});
            this.cb_naturezajur.Location = new System.Drawing.Point(244, 423);
            this.cb_naturezajur.Name = "cb_naturezajur";
            this.cb_naturezajur.Size = new System.Drawing.Size(202, 26);
            this.cb_naturezajur.TabIndex = 7;
            // 
            // cb_situcaocadas
            // 
            this.cb_situcaocadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_situcaocadas.FormattingEnabled = true;
            this.cb_situcaocadas.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.cb_situcaocadas.Location = new System.Drawing.Point(234, 106);
            this.cb_situcaocadas.Name = "cb_situcaocadas";
            this.cb_situcaocadas.Size = new System.Drawing.Size(212, 26);
            this.cb_situcaocadas.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(0, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Real";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(3, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Matriz";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(0, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Lucro Presumido";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton4.Location = new System.Drawing.Point(2, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(106, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Simples Nacional";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panelRegime
            // 
            this.panelRegime.BackColor = System.Drawing.Color.Transparent;
            this.panelRegime.Controls.Add(this.radioButton4);
            this.panelRegime.Controls.Add(this.radioButton3);
            this.panelRegime.Controls.Add(this.radioButton1);
            this.panelRegime.ForeColor = System.Drawing.Color.Transparent;
            this.panelRegime.Location = new System.Drawing.Point(244, 158);
            this.panelRegime.Name = "panelRegime";
            this.panelRegime.Size = new System.Drawing.Size(123, 54);
            this.panelRegime.TabIndex = 13;
            this.panelRegime.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_enderecocom
            // 
            this.cb_enderecocom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_enderecocom.FormattingEnabled = true;
            this.cb_enderecocom.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins",
            "Distrito Federal"});
            this.cb_enderecocom.Location = new System.Drawing.Point(241, 230);
            this.cb_enderecocom.Name = "cb_enderecocom";
            this.cb_enderecocom.Size = new System.Drawing.Size(205, 26);
            this.cb_enderecocom.TabIndex = 14;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton5.Location = new System.Drawing.Point(3, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 17);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Filial";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // panelTipo
            // 
            this.panelTipo.BackColor = System.Drawing.Color.Transparent;
            this.panelTipo.Controls.Add(this.radioButton2);
            this.panelTipo.Controls.Add(this.radioButton5);
            this.panelTipo.Location = new System.Drawing.Point(241, 287);
            this.panelTipo.Name = "panelTipo";
            this.panelTipo.Size = new System.Drawing.Size(62, 38);
            this.panelTipo.TabIndex = 16;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton6.Location = new System.Drawing.Point(3, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 17);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Grande";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton7.Location = new System.Drawing.Point(3, 14);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(54, 17);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Médio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButton8.Location = new System.Drawing.Point(3, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(68, 17);
            this.radioButton8.TabIndex = 19;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Pequeno";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // panelPorte
            // 
            this.panelPorte.BackColor = System.Drawing.Color.Transparent;
            this.panelPorte.Controls.Add(this.radioButton8);
            this.panelPorte.Controls.Add(this.radioButton6);
            this.panelPorte.Controls.Add(this.radioButton7);
            this.panelPorte.Location = new System.Drawing.Point(241, 346);
            this.panelPorte.Name = "panelPorte";
            this.panelPorte.Size = new System.Drawing.Size(107, 57);
            this.panelPorte.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 409);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tx_capital
            // 
            this.tx_capital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_capital.Location = new System.Drawing.Point(244, 500);
            this.tx_capital.Name = "tx_capital";
            this.tx_capital.Size = new System.Drawing.Size(147, 24);
            this.tx_capital.TabIndex = 22;
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cadastrar.Location = new System.Drawing.Point(42, 586);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(117, 23);
            this.cadastrar.TabIndex = 23;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(230, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 25);
            this.button2.TabIndex = 24;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atvd_figma.Properties.Resources.TelaCadastro;
            this.ClientSize = new System.Drawing.Size(933, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.tx_capital);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelPorte);
            this.Controls.Add(this.panelTipo);
            this.Controls.Add(this.cb_enderecocom);
            this.Controls.Add(this.panelRegime);
            this.Controls.Add(this.cb_situcaocadas);
            this.Controls.Add(this.cb_naturezajur);
            this.Controls.Add(this.mask_telefone);
            this.Controls.Add(this.mask_cnpj);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.mask_datainicio);
            this.Controls.Add(this.tx_nomeEm);
            this.Controls.Add(this.tx_razaosocial);
            this.Controls.Add(this.tx_nomefantasia);
            this.DoubleBuffered = true;
            this.Name = "Empresa";
            this.Text = "Empresa";
            this.panelRegime.ResumeLayout(false);
            this.panelRegime.PerformLayout();
            this.panelTipo.ResumeLayout(false);
            this.panelTipo.PerformLayout();
            this.panelPorte.ResumeLayout(false);
            this.panelPorte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nomefantasia;
        private System.Windows.Forms.TextBox tx_razaosocial;
        private System.Windows.Forms.TextBox tx_nomeEm;
        private System.Windows.Forms.MaskedTextBox mask_datainicio;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.MaskedTextBox mask_cnpj;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.ComboBox cb_naturezajur;
        private System.Windows.Forms.ComboBox cb_situcaocadas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panelRegime;
        private System.Windows.Forms.ComboBox cb_enderecocom;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel panelTipo;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panelPorte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tx_capital;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button2;
    }
}