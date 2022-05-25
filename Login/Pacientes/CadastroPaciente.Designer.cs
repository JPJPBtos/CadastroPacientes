namespace Pacientes
{
    partial class frmCadastroPaciente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCadastroPaciente = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.ckbObito = new System.Windows.Forms.CheckBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPacientesCadastrados = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.clm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbCadastroPaciente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbPacientesCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCadastroPaciente);
            this.tabControl1.Controls.Add(this.tbPacientesCadastrados);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCadastroPaciente
            // 
            this.tbCadastroPaciente.Controls.Add(this.btnLimpar);
            this.tbCadastroPaciente.Controls.Add(this.btnExcluir);
            this.tbCadastroPaciente.Controls.Add(this.btnAtualizar);
            this.tbCadastroPaciente.Controls.Add(this.btnCadastrar);
            this.tbCadastroPaciente.Controls.Add(this.ckbObito);
            this.tbCadastroPaciente.Controls.Add(this.txtEndereco);
            this.tbCadastroPaciente.Controls.Add(this.label5);
            this.tbCadastroPaciente.Controls.Add(this.cmbCor);
            this.tbCadastroPaciente.Controls.Add(this.label4);
            this.tbCadastroPaciente.Controls.Add(this.groupBox1);
            this.tbCadastroPaciente.Controls.Add(this.txtEmail);
            this.tbCadastroPaciente.Controls.Add(this.txtNome);
            this.tbCadastroPaciente.Controls.Add(this.txtCodigo);
            this.tbCadastroPaciente.Controls.Add(this.label1);
            this.tbCadastroPaciente.Controls.Add(this.label2);
            this.tbCadastroPaciente.Controls.Add(this.label3);
            this.tbCadastroPaciente.Location = new System.Drawing.Point(4, 22);
            this.tbCadastroPaciente.Name = "tbCadastroPaciente";
            this.tbCadastroPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroPaciente.Size = new System.Drawing.Size(752, 400);
            this.tbCadastroPaciente.TabIndex = 0;
            this.tbCadastroPaciente.Text = " Cadastro de Pacientes";
            this.tbCadastroPaciente.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(381, 260);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(290, 260);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(200, 260);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(103, 260);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // ckbObito
            // 
            this.ckbObito.AutoSize = true;
            this.ckbObito.Location = new System.Drawing.Point(103, 219);
            this.ckbObito.Name = "ckbObito";
            this.ckbObito.Size = new System.Drawing.Size(51, 17);
            this.ckbObito.TabIndex = 12;
            this.ckbObito.Text = "Óbito";
            this.ckbObito.UseVisualStyleBackColor = true;
            this.ckbObito.CheckedChanged += new System.EventHandler(this.ckbObito_CheckedChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(103, 193);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(362, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço";
            // 
            // cmbCor
            // 
            this.cmbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Items.AddRange(new object[] {
            "Branco",
            "Negro",
            "Pardo"});
            this.cmbCor.Location = new System.Drawing.Point(298, 125);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(167, 21);
            this.cmbCor.TabIndex = 9;
            this.cmbCor.SelectedIndexChanged += new System.EventHandler(this.cmbCor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Location = new System.Drawing.Point(103, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(79, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 1;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Checked = true;
            this.rdbFeminino.Location = new System.Drawing.Point(6, 19);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 0;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // tbPacientesCadastrados
            // 
            this.tbPacientesCadastrados.Controls.Add(this.btnConsultar);
            this.tbPacientesCadastrados.Controls.Add(this.btnLimpar2);
            this.tbPacientesCadastrados.Controls.Add(this.dgvPacientes);
            this.tbPacientesCadastrados.Location = new System.Drawing.Point(4, 22);
            this.tbPacientesCadastrados.Name = "tbPacientesCadastrados";
            this.tbPacientesCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tbPacientesCadastrados.Size = new System.Drawing.Size(752, 400);
            this.tbPacientesCadastrados.TabIndex = 1;
            this.tbPacientesCadastrados.Text = "Pacientes Cadastrados";
            this.tbPacientesCadastrados.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(624, 323);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 71);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Location = new System.Drawing.Point(511, 323);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(107, 71);
            this.btnLimpar2.TabIndex = 1;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm1,
            this.clmNome,
            this.clmEmail,
            this.clmSexo,
            this.clmCor,
            this.clmEndereco,
            this.clmObito});
            this.dgvPacientes.Location = new System.Drawing.Point(0, 0);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(749, 317);
            this.dgvPacientes.TabIndex = 0;
            // 
            // clm1
            // 
            this.clm1.HeaderText = "ID";
            this.clm1.Name = "clm1";
            // 
            // clmNome
            // 
            this.clmNome.HeaderText = "NOME";
            this.clmNome.Name = "clmNome";
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "EMAIL";
            this.clmEmail.Name = "clmEmail";
            // 
            // clmSexo
            // 
            this.clmSexo.HeaderText = "SEXO";
            this.clmSexo.Name = "clmSexo";
            // 
            // clmCor
            // 
            this.clmCor.HeaderText = "COR";
            this.clmCor.Name = "clmCor";
            // 
            // clmEndereco
            // 
            this.clmEndereco.HeaderText = "ENDEREÇO";
            this.clmEndereco.Name = "clmEndereco";
            // 
            // clmObito
            // 
            this.clmObito.HeaderText = "OBITO";
            this.clmObito.Name = "clmObito";
            // 
            // frmCadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCadastroPaciente";
            this.Text = "CadastroPaciente";
            this.Load += new System.EventHandler(this.frmCadastroPaciente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbCadastroPaciente.ResumeLayout(false);
            this.tbCadastroPaciente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbPacientesCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCadastroPaciente;
        private System.Windows.Forms.TabPage tbPacientesCadastrados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox ckbObito;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObito;
    }
}