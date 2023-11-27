namespace CadastroFuncionario.Forms
{
    partial class Tela_inicial
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastra_empresa = new System.Windows.Forms.Button();
            this.btn_consultar_emp = new System.Windows.Forms.Button();
            this.btn_cadastrar_fun = new System.Windows.Forms.Button();
            this.btn_consultra_fun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "X2A";
            // 
            // btn_cadastra_empresa
            // 
            this.btn_cadastra_empresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cadastra_empresa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cadastra_empresa.Location = new System.Drawing.Point(110, 113);
            this.btn_cadastra_empresa.Name = "btn_cadastra_empresa";
            this.btn_cadastra_empresa.Size = new System.Drawing.Size(161, 23);
            this.btn_cadastra_empresa.TabIndex = 1;
            this.btn_cadastra_empresa.Text = "Cadastrar";
            this.btn_cadastra_empresa.UseVisualStyleBackColor = true;
            this.btn_cadastra_empresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultar_emp
            // 
            this.btn_consultar_emp.Location = new System.Drawing.Point(110, 142);
            this.btn_consultar_emp.Name = "btn_consultar_emp";
            this.btn_consultar_emp.Size = new System.Drawing.Size(161, 23);
            this.btn_consultar_emp.TabIndex = 2;
            this.btn_consultar_emp.Text = "Consultar";
            this.btn_consultar_emp.UseVisualStyleBackColor = true;
            this.btn_consultar_emp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cadastrar_fun
            // 
            this.btn_cadastrar_fun.Location = new System.Drawing.Point(110, 226);
            this.btn_cadastrar_fun.Name = "btn_cadastrar_fun";
            this.btn_cadastrar_fun.Size = new System.Drawing.Size(161, 23);
            this.btn_cadastrar_fun.TabIndex = 3;
            this.btn_cadastrar_fun.Text = "Cadastrar";
            this.btn_cadastrar_fun.UseVisualStyleBackColor = true;
            this.btn_cadastrar_fun.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_consultra_fun
            // 
            this.btn_consultra_fun.Location = new System.Drawing.Point(110, 255);
            this.btn_consultra_fun.Name = "btn_consultra_fun";
            this.btn_consultra_fun.Size = new System.Drawing.Size(161, 23);
            this.btn_consultra_fun.TabIndex = 4;
            this.btn_consultra_fun.Text = "Consultar";
            this.btn_consultra_fun.UseVisualStyleBackColor = true;
            this.btn_consultra_fun.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Funcionário";
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(368, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_consultra_fun);
            this.Controls.Add(this.btn_cadastrar_fun);
            this.Controls.Add(this.btn_consultar_emp);
            this.Controls.Add(this.btn_cadastra_empresa);
            this.Controls.Add(this.label1);
            this.Name = "Tela_inicial";
            this.Text = "Tela_inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastra_empresa;
        private System.Windows.Forms.Button btn_consultar_emp;
        private System.Windows.Forms.Button btn_cadastrar_fun;
        private System.Windows.Forms.Button btn_consultra_fun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}