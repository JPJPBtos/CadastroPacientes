using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pacientes
{
    public partial class frmLogin : Form
    {
        private MySqlConnection objcnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                objcnx.ConnectionString = "Server=localhost;Database=bdsispaciente;User=root;Pwd=etec-2018";
                objcnx.Open();
            }
            catch(Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Erro acesso a base de dados!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;

            try
            {
                string strSql = "SELECT * FROM USUARIO WHERE login = @login and senha = @senha";
                objCmd.Connection = objcnx;
                //adiciona parametros a consulta 
                objCmd.Parameters.AddWithValue("@login", login);
                objCmd.Parameters.AddWithValue("@senha", senha);
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                //verifição se teve algum retorno na consulta
                if(objDados.HasRows)
                {
                    MessageBox.Show("Login realizado", "Login efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!objDados.IsClosed) { objDados.Close(); }
                    frmCadastroPaciente objTela = new frmCadastroPaciente();
                    objTela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado ou dados invalidados! Realize o cadastro no botão cadastrar se necessario!!!", "Erro cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCadastrar.Visible = true;
                }
                if(!objDados.IsClosed) { objDados.Close(); }
            }
            catch(Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Erro Admnistrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;

            try
            {
                if (!objDados.IsClosed) { objDados.Close(); }
                string strSql = "INSERT INTO USUARIO(LOGIN, SENHA) VALUES (@LOGIN2, @SENHA2)";

                objCmd.Parameters.AddWithValue("@LOGIN2", login);
                objCmd.Parameters.AddWithValue("@SENHA2", senha);
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();

                MessageBox.Show("Cadastro realizado com sucesso!!!", "Cadastro realizado!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!objDados.IsClosed) { objDados.Close(); }
                frmCadastroPaciente objTela = new frmCadastroPaciente();
                objTela.ShowDialog();
            }
            catch(Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Erro Administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
