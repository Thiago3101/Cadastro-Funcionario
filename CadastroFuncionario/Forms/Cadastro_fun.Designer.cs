﻿namespace CadastroFuncionario
{
    partial class Cadastro_fun
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.data_nas = new System.Windows.Forms.DateTimePicker();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.tx_tel = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_est_civil = new System.Windows.Forms.TextBox();
            this.tx_salario = new System.Windows.Forms.TextBox();
            this.mtx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tx_estado = new System.Windows.Forms.ComboBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(47, 633);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(157, 42);
            this.btn_cancelar.TabIndex = 0;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Lime;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(295, 633);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(157, 42);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data nascimento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Estado civil:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Função:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Salário:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(103, 27);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(349, 20);
            this.tx_nome.TabIndex = 12;
            // 
            // data_nas
            // 
            this.data_nas.Location = new System.Drawing.Point(173, 66);
            this.data_nas.Name = "data_nas";
            this.data_nas.Size = new System.Drawing.Size(228, 20);
            this.data_nas.TabIndex = 13;
            // 
            // tx_rg
            // 
            this.tx_rg.Location = new System.Drawing.Point(88, 162);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(364, 20);
            this.tx_rg.TabIndex = 15;
            // 
            // tx_tel
            // 
            this.tx_tel.Location = new System.Drawing.Point(122, 216);
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(330, 20);
            this.tx_tel.TabIndex = 16;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(97, 271);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(355, 20);
            this.tx_email.TabIndex = 17;
            // 
            // tx_endereco
            // 
            this.tx_endereco.Location = new System.Drawing.Point(124, 324);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(328, 20);
            this.tx_endereco.TabIndex = 18;
            // 
            // tx_est_civil
            // 
            this.tx_est_civil.Location = new System.Drawing.Point(135, 376);
            this.tx_est_civil.Name = "tx_est_civil";
            this.tx_est_civil.Size = new System.Drawing.Size(317, 20);
            this.tx_est_civil.TabIndex = 19;
            // 
            // tx_salario
            // 
            this.tx_salario.Location = new System.Drawing.Point(105, 476);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(347, 20);
            this.tx_salario.TabIndex = 21;
            // 
            // mtx_cpf
            // 
            this.mtx_cpf.Location = new System.Drawing.Point(88, 112);
            this.mtx_cpf.Mask = "000,000,000-00";
            this.mtx_cpf.Name = "mtx_cpf";
            this.mtx_cpf.Size = new System.Drawing.Size(89, 20);
            this.mtx_cpf.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Estado:";
            // 
            // tx_estado
            // 
            this.tx_estado.FormattingEnabled = true;
            this.tx_estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.tx_estado.Location = new System.Drawing.Point(105, 529);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(62, 21);
            this.tx_estado.TabIndex = 24;
            // 
            // tx_cidade
            // 
            this.tx_cidade.Location = new System.Drawing.Point(247, 529);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(205, 20);
            this.tx_cidade.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 529);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Cidade:";
            // 
            // tx_funcao
            // 
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Desenvolvedor de Software",
            "Enfermeiro(a)",
            "Professor(a)",
            "Analista de Dados",
            "Designer Gráfico",
            "Engenheiro(a) Civil",
            "Consultor(a) de Recursos Humanos",
            "Chef de Cozinha",
            "Jornalista",
            "Analista Financeiro(a)",
            "Piloto de Drone",
            "Terapeuta Holístico(a)",
            "Especialista em Experiência do Usuário (UX)",
            "Consultor(a) de Sustentabilidade",
            "Curador(a) de Conteúdo Digital",
            "Designer de Realidade Virtual",
            "Estrategista de Mídia Social",
            "Especialista em Bem-Estar Corporativo",
            "Engenheiro(a) de Robótica",
            "Coordenador(a) de Eventos Virtuais",
            "Instrutor(a) de Ioga",
            "Gerente de Projetos de Energias Renováveis",
            "Cientista de Dados em Saúde",
            "Especialista em Cibersegurança",
            "Escritor(a) de Roteiros",
            "Arquiteto(a) de Paisagens Urbanas",
            "Terapeuta de Arteterapia",
            "Especialista em Desenvolvimento de Jogos Educativos",
            "Consultor(a) de Viagens Espaciais",
            "Designer de Moda Sustentável"});
            this.tx_funcao.Location = new System.Drawing.Point(111, 429);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(176, 21);
            this.tx_funcao.TabIndex = 27;
            // 
            // Cadastro_fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 712);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtx_cpf);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_est_civil);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_tel);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.data_nas);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cadastro_fun";
            this.Text = "Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.DateTimePicker data_nas;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.TextBox tx_tel;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_est_civil;
        private System.Windows.Forms.TextBox tx_salario;
        private System.Windows.Forms.MaskedTextBox mtx_cpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox tx_estado;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tx_funcao;
    }
}
