namespace Atvd_figma
{
    partial class Menu
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
            this.Telaempresa = new System.Windows.Forms.Button();
            this.Telafuncionario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Telaempresa
            // 
            this.Telaempresa.Location = new System.Drawing.Point(115, 328);
            this.Telaempresa.Name = "Telaempresa";
            this.Telaempresa.Size = new System.Drawing.Size(205, 23);
            this.Telaempresa.TabIndex = 0;
            this.Telaempresa.Text = "CONSULTAR EMPRESA";
            this.Telaempresa.UseVisualStyleBackColor = true;
            this.Telaempresa.Click += new System.EventHandler(this.Telaempresa_Click);
            // 
            // Telafuncionario
            // 
            this.Telafuncionario.Location = new System.Drawing.Point(115, 198);
            this.Telafuncionario.Name = "Telafuncionario";
            this.Telafuncionario.Size = new System.Drawing.Size(205, 23);
            this.Telafuncionario.TabIndex = 1;
            this.Telafuncionario.Text = "CADASTRO FUNCIONÁRIO";
            this.Telafuncionario.UseVisualStyleBackColor = true;
            this.Telafuncionario.Click += new System.EventHandler(this.funcionario_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atvd_figma.Properties.Resources.Frame_1__5_;
            this.ClientSize = new System.Drawing.Size(418, 540);
            this.Controls.Add(this.Telafuncionario);
            this.Controls.Add(this.Telaempresa);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Telaempresa;
        private System.Windows.Forms.Button Telafuncionario;
    }
}