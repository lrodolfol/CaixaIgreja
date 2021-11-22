namespace CaixaCEO.View.Cadastros
{
    partial class viewCadCargo
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarCargo = new System.Windows.Forms.Button();
            this.txtNomeCargo = new System.Windows.Forms.TextBox();
            this.txtDerscricaoCargo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCargo = new System.Windows.Forms.TextBox();
            this.lblMensagemCargos = new System.Windows.Forms.Label();
            this.groupBoxCargos = new System.Windows.Forms.GroupBox();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.groupBoxCargos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // btnSalvarCargo
            // 
            this.btnSalvarCargo.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCargo.Location = new System.Drawing.Point(156, 262);
            this.btnSalvarCargo.Name = "btnSalvarCargo";
            this.btnSalvarCargo.Size = new System.Drawing.Size(92, 35);
            this.btnSalvarCargo.TabIndex = 2;
            this.btnSalvarCargo.Text = "Salvar";
            this.btnSalvarCargo.UseVisualStyleBackColor = false;
            this.btnSalvarCargo.Click += new System.EventHandler(this.btnSalvarCargo_Click);
            // 
            // txtNomeCargo
            // 
            this.txtNomeCargo.Location = new System.Drawing.Point(6, 92);
            this.txtNomeCargo.Name = "txtNomeCargo";
            this.txtNomeCargo.Size = new System.Drawing.Size(239, 20);
            this.txtNomeCargo.TabIndex = 3;
            // 
            // txtDerscricaoCargo
            // 
            this.txtDerscricaoCargo.Location = new System.Drawing.Point(6, 144);
            this.txtDerscricaoCargo.Name = "txtDerscricaoCargo";
            this.txtDerscricaoCargo.Size = new System.Drawing.Size(242, 96);
            this.txtDerscricaoCargo.TabIndex = 4;
            this.txtDerscricaoCargo.Text = "";
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
            // txtIdCargo
            // 
            this.txtIdCargo.Enabled = false;
            this.txtIdCargo.Location = new System.Drawing.Point(6, 37);
            this.txtIdCargo.Name = "txtIdCargo";
            this.txtIdCargo.ReadOnly = true;
            this.txtIdCargo.Size = new System.Drawing.Size(100, 20);
            this.txtIdCargo.TabIndex = 6;
            // 
            // lblMensagemCargos
            // 
            this.lblMensagemCargos.AutoSize = true;
            this.lblMensagemCargos.Location = new System.Drawing.Point(6, 318);
            this.lblMensagemCargos.Name = "lblMensagemCargos";
            this.lblMensagemCargos.Size = new System.Drawing.Size(0, 13);
            this.lblMensagemCargos.TabIndex = 7;
            // 
            // groupBoxCargos
            // 
            this.groupBoxCargos.Controls.Add(this.btnSalvarCargo);
            this.groupBoxCargos.Controls.Add(this.lblMensagemCargos);
            this.groupBoxCargos.Controls.Add(this.label1);
            this.groupBoxCargos.Controls.Add(this.txtIdCargo);
            this.groupBoxCargos.Controls.Add(this.label2);
            this.groupBoxCargos.Controls.Add(this.label3);
            this.groupBoxCargos.Controls.Add(this.txtNomeCargo);
            this.groupBoxCargos.Controls.Add(this.txtDerscricaoCargo);
            this.groupBoxCargos.Location = new System.Drawing.Point(4, 31);
            this.groupBoxCargos.Name = "groupBoxCargos";
            this.groupBoxCargos.Size = new System.Drawing.Size(260, 347);
            this.groupBoxCargos.TabIndex = 8;
            this.groupBoxCargos.TabStop = false;
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(4, 4);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(169, 21);
            this.cmbCargos.TabIndex = 8;
            this.cmbCargos.SelectedIndexChanged += new System.EventHandler(this.cmbCargos_SelectedIndexChanged);
            // 
            // viewCadCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 383);
            this.Controls.Add(this.cmbCargos);
            this.Controls.Add(this.groupBoxCargos);
            this.Name = "viewCadCargo";
            this.Text = "Cadastro de cargos";
            this.Load += new System.EventHandler(this.viewCadCargo_Load);
            this.groupBoxCargos.ResumeLayout(false);
            this.groupBoxCargos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarCargo;
        private System.Windows.Forms.TextBox txtNomeCargo;
        private System.Windows.Forms.RichTextBox txtDerscricaoCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdCargo;
        private System.Windows.Forms.Label lblMensagemCargos;
        private System.Windows.Forms.GroupBox groupBoxCargos;
        private System.Windows.Forms.ComboBox cmbCargos;
    }
}