namespace Atvd_figma
{
    partial class Funcio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_id = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.masked_data = new System.Windows.Forms.MaskedTextBox();
            this.masked_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.masked_cpf = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_funcao = new System.Windows.Forms.ComboBox();
            this.cb_estadocivil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.SystemColors.Info;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(72, 162);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(308, 28);
            this.tx_nome.TabIndex = 1;
            // 
            // tx_id
            // 
            this.tx_id.BackColor = System.Drawing.SystemColors.Info;
            this.tx_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_id.Location = new System.Drawing.Point(72, 94);
            this.tx_id.Name = "tx_id";
            this.tx_id.Size = new System.Drawing.Size(83, 22);
            this.tx_id.TabIndex = 2;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.SystemColors.Info;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.Location = new System.Drawing.Point(439, 92);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(193, 24);
            this.tx_email.TabIndex = 3;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.SystemColors.Info;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_endereco.Location = new System.Drawing.Point(439, 162);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(181, 24);
            this.tx_endereco.TabIndex = 6;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.BackColor = System.Drawing.Color.LimeGreen;
            this.button_cadastrar.Location = new System.Drawing.Point(78, 469);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(107, 20);
            this.button_cadastrar.TabIndex = 8;
            this.button_cadastrar.Text = "CADASTAR";
            this.button_cadastrar.UseVisualStyleBackColor = false;
            this.button_cadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // masked_data
            // 
            this.masked_data.BackColor = System.Drawing.SystemColors.Info;
            this.masked_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_data.Location = new System.Drawing.Point(72, 235);
            this.masked_data.Mask = "0000-00-00";
            this.masked_data.Name = "masked_data";
            this.masked_data.Size = new System.Drawing.Size(130, 24);
            this.masked_data.TabIndex = 9;
            this.masked_data.ValidatingType = typeof(System.DateTime);
            // 
            // masked_telefone
            // 
            this.masked_telefone.BackColor = System.Drawing.SystemColors.Info;
            this.masked_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_telefone.Location = new System.Drawing.Point(78, 385);
            this.masked_telefone.Mask = "(99) 00000-0000";
            this.masked_telefone.Name = "masked_telefone";
            this.masked_telefone.Size = new System.Drawing.Size(124, 22);
            this.masked_telefone.TabIndex = 10;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.SystemColors.Info;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_salario.Location = new System.Drawing.Point(439, 385);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(112, 22);
            this.tx_salario.TabIndex = 12;
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.SystemColors.Info;
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_rg.Location = new System.Drawing.Point(244, 317);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(71, 24);
            this.tx_rg.TabIndex = 13;
            // 
            // masked_cpf
            // 
            this.masked_cpf.BackColor = System.Drawing.SystemColors.Info;
            this.masked_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.masked_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masked_cpf.Location = new System.Drawing.Point(72, 317);
            this.masked_cpf.Mask = "000,000,000-00";
            this.masked_cpf.Name = "masked_cpf";
            this.masked_cpf.Size = new System.Drawing.Size(150, 22);
            this.masked_cpf.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(696, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 344);
            this.dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_funcao
            // 
            this.cb_funcao.FormattingEnabled = true;
            this.cb_funcao.Items.AddRange(new object[] {
            "Gerente de Hotel",
            "Gerente Geral",
            "Coordenador",
            "Chefe de Recepção",
            "Gerente de Contas",
            "Supervisor",
            "Recepcionista Bilíngue",
            "Atendente"});
            this.cb_funcao.Location = new System.Drawing.Point(439, 309);
            this.cb_funcao.Name = "cb_funcao";
            this.cb_funcao.Size = new System.Drawing.Size(121, 21);
            this.cb_funcao.TabIndex = 17;
            // 
            // cb_estadocivil
            // 
            this.cb_estadocivil.FormattingEnabled = true;
            this.cb_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cb_estadocivil.Location = new System.Drawing.Point(439, 235);
            this.cb_estadocivil.Name = "cb_estadocivil";
            this.cb_estadocivil.Size = new System.Drawing.Size(121, 21);
            this.cb_estadocivil.TabIndex = 18;
            // 
            // Funcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atvd_figma.Properties.Resources.Frame_11;
            this.ClientSize = new System.Drawing.Size(1200, 527);
            this.Controls.Add(this.cb_estadocivil);
            this.Controls.Add(this.cb_funcao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.masked_cpf);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.masked_telefone);
            this.Controls.Add(this.masked_data);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_id);
            this.Controls.Add(this.button_cadastrar);
            this.Name = "Funcio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_id;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.MaskedTextBox masked_data;
        private System.Windows.Forms.MaskedTextBox masked_telefone;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.MaskedTextBox masked_cpf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_funcao;
        private System.Windows.Forms.ComboBox cb_estadocivil;
    }
}

