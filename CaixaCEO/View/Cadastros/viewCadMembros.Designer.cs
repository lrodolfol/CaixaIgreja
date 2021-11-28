namespace CaixaCEO.View.Cadastros
{
    partial class viewCadMembros
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
            this.txtNomeMembro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMembro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarMembro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpMembros = new System.Windows.Forms.GroupBox();
            this.btnAcessarCargos = new System.Windows.Forms.Button();
            this.cmbMembros = new System.Windows.Forms.ComboBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.grpMembros.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeMembro
            // 
            this.txtNomeMembro.Location = new System.Drawing.Point(6, 84);
            this.txtNomeMembro.Name = "txtNomeMembro";
            this.txtNomeMembro.Size = new System.Drawing.Size(254, 20);
            this.txtNomeMembro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // txtIdMembro
            // 
            this.txtIdMembro.Enabled = false;
            this.txtIdMembro.Location = new System.Drawing.Point(6, 37);
            this.txtIdMembro.Name = "txtIdMembro";
            this.txtIdMembro.ReadOnly = true;
            this.txtIdMembro.Size = new System.Drawing.Size(100, 20);
            this.txtIdMembro.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnSalvarMembro
            // 
            this.btnSalvarMembro.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMembro.Location = new System.Drawing.Point(78, 281);
            this.btnSalvarMembro.Name = "btnSalvarMembro";
            this.btnSalvarMembro.Size = new System.Drawing.Size(92, 35);
            this.btnSalvarMembro.TabIndex = 2;
            this.btnSalvarMembro.Text = "Salvar";
            this.btnSalvarMembro.UseVisualStyleBackColor = false;
            this.btnSalvarMembro.Click += new System.EventHandler(this.btnSalvarMembro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(179, 281);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 35);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(6, 132);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(76, 20);
            this.txtDataNascimento.TabIndex = 10;
            this.txtDataNascimento.Text = "__/__/____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Nasc.";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(88, 134);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(11, 15);
            this.lblIdade.TabIndex = 11;
            this.lblIdade.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cargo:";
            // 
            // grpMembros
            // 
            this.grpMembros.Controls.Add(this.lblMensagem);
            this.grpMembros.Controls.Add(this.cmbCargos);
            this.grpMembros.Controls.Add(this.btnAcessarCargos);
            this.grpMembros.Controls.Add(this.label5);
            this.grpMembros.Controls.Add(this.lblIdade);
            this.grpMembros.Controls.Add(this.label4);
            this.grpMembros.Controls.Add(this.txtDataNascimento);
            this.grpMembros.Controls.Add(this.btnExcluir);
            this.grpMembros.Controls.Add(this.btnSalvarMembro);
            this.grpMembros.Controls.Add(this.label1);
            this.grpMembros.Controls.Add(this.txtIdMembro);
            this.grpMembros.Controls.Add(this.label3);
            this.grpMembros.Controls.Add(this.txtNomeMembro);
            this.grpMembros.Location = new System.Drawing.Point(5, 36);
            this.grpMembros.Name = "grpMembros";
            this.grpMembros.Size = new System.Drawing.Size(279, 357);
            this.grpMembros.TabIndex = 9;
            this.grpMembros.TabStop = false;
            // 
            // btnAcessarCargos
            // 
            this.btnAcessarCargos.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarCargos.Location = new System.Drawing.Point(225, 188);
            this.btnAcessarCargos.Name = "btnAcessarCargos";
            this.btnAcessarCargos.Size = new System.Drawing.Size(35, 20);
            this.btnAcessarCargos.TabIndex = 14;
            this.btnAcessarCargos.Text = "GO";
            this.btnAcessarCargos.UseVisualStyleBackColor = false;
            // 
            // cmbMembros
            // 
            this.cmbMembros.FormattingEnabled = true;
            this.cmbMembros.Location = new System.Drawing.Point(6, 9);
            this.cmbMembros.Name = "cmbMembros";
            this.cmbMembros.Size = new System.Drawing.Size(169, 21);
            this.cmbMembros.TabIndex = 15;
            this.cmbMembros.SelectedIndexChanged += new System.EventHandler(this.cmbMembros_SelectedIndexChanged);
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(6, 187);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(213, 21);
            this.cmbCargos.TabIndex = 16;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(8, 337);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 17;
            this.lblMensagem.Text = "label2";
            // 
            // viewCadMembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 398);
            this.Controls.Add(this.cmbMembros);
            this.Controls.Add(this.grpMembros);
            this.Name = "viewCadMembros";
            this.Text = "Cadastro de Membros";
            this.Load += new System.EventHandler(this.viewCadMembros_Load);
            this.grpMembros.ResumeLayout(false);
            this.grpMembros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeMembro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMembro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarMembro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpMembros;
        private System.Windows.Forms.Button btnAcessarCargos;
        private System.Windows.Forms.ComboBox cmbMembros;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.Label lblMensagem;
    }
}