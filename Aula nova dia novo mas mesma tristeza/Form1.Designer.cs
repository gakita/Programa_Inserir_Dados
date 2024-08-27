namespace Aula_nova_dia_novo_mas_mesma_tristeza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSair = new Button();
            lbNome = new Label();
            lbEmail = new Label();
            lbTelefone = new Label();
            tbxNome = new TextBox();
            tbxEmail = new TextBox();
            tbxTelefone = new TextBox();
            btnConsultarNome = new Button();
            bntConsultarEmail = new Button();
            btnConsultarTel = new Button();
            lbxCadastros = new ListBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackgroundImage = Properties.Resources.OIP__2_;
            btnSair.BackgroundImageLayout = ImageLayout.Stretch;
            btnSair.Location = new Point(12, 411);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(503, 27);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = Color.Salmon;
            lbNome.Location = new Point(19, 19);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome:";
            lbNome.Click += lbNome_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.LightGray;
            lbEmail.Location = new Point(19, 79);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email:";
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.White;
            lbTelefone.ForeColor = Color.Indigo;
            lbTelefone.Location = new Point(19, 142);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(54, 15);
            lbTelefone.TabIndex = 3;
            lbTelefone.Text = "Telefone:";
            // 
            // tbxNome
            // 
            tbxNome.Location = new Point(104, 19);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(287, 23);
            tbxNome.TabIndex = 4;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(104, 76);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(287, 23);
            tbxEmail.TabIndex = 5;
            // 
            // tbxTelefone
            // 
            tbxTelefone.Location = new Point(104, 134);
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.Size = new Size(287, 23);
            tbxTelefone.TabIndex = 6;
            // 
            // btnConsultarNome
            // 
            btnConsultarNome.BackgroundImage = Properties.Resources.OIP1;
            btnConsultarNome.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsultarNome.Location = new Point(518, 5);
            btnConsultarNome.Name = "btnConsultarNome";
            btnConsultarNome.Size = new Size(105, 42);
            btnConsultarNome.TabIndex = 7;
            btnConsultarNome.Text = "Consultar Nome";
            btnConsultarNome.UseVisualStyleBackColor = true;
            btnConsultarNome.Click += btnConsultarNome_Click;
            // 
            // bntConsultarEmail
            // 
            bntConsultarEmail.BackgroundImage = Properties.Resources.OIP1;
            bntConsultarEmail.BackgroundImageLayout = ImageLayout.Stretch;
            bntConsultarEmail.Location = new Point(518, 65);
            bntConsultarEmail.Name = "bntConsultarEmail";
            bntConsultarEmail.Size = new Size(105, 42);
            bntConsultarEmail.TabIndex = 8;
            bntConsultarEmail.Text = "Consultar Email";
            bntConsultarEmail.UseVisualStyleBackColor = true;
            bntConsultarEmail.Click += bntConsultarEmail_Click;
            // 
            // btnConsultarTel
            // 
            btnConsultarTel.BackgroundImage = Properties.Resources.OIP1;
            btnConsultarTel.BackgroundImageLayout = ImageLayout.Stretch;
            btnConsultarTel.Location = new Point(518, 123);
            btnConsultarTel.Name = "btnConsultarTel";
            btnConsultarTel.Size = new Size(105, 42);
            btnConsultarTel.TabIndex = 9;
            btnConsultarTel.Text = "Consultar Telefone";
            btnConsultarTel.UseVisualStyleBackColor = true;
            btnConsultarTel.Click += btnConsultarTel_Click;
            // 
            // lbxCadastros
            // 
            lbxCadastros.BackColor = SystemColors.HotTrack;
            lbxCadastros.ForeColor = SystemColors.Window;
            lbxCadastros.FormattingEnabled = true;
            lbxCadastros.ItemHeight = 15;
            lbxCadastros.Location = new Point(19, 179);
            lbxCadastros.Name = "lbxCadastros";
            lbxCadastros.Size = new Size(496, 214);
            lbxCadastros.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackgroundImage = Properties.Resources.OIP__1_;
            btnCadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrar.Location = new Point(397, 123);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(104, 42);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cool;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(736, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(lbxCadastros);
            Controls.Add(btnConsultarTel);
            Controls.Add(bntConsultarEmail);
            Controls.Add(btnConsultarNome);
            Controls.Add(tbxTelefone);
            Controls.Add(tbxEmail);
            Controls.Add(tbxNome);
            Controls.Add(lbTelefone);
            Controls.Add(lbEmail);
            Controls.Add(lbNome);
            Controls.Add(btnSair);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Label lbNome;
        private Label lbEmail;
        private Label lbTelefone;
        private TextBox tbxNome;
        private TextBox tbxEmail;
        private TextBox tbxTelefone;
        private Button btnConsultarNome;
        private Button bntConsultarEmail;
        private Button btnConsultarTel;
        private ListBox lbxCadastros;
        private Button btnCadastrar;
    }
}