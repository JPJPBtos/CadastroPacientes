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
    public partial class frmCadastroPaciente : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmCadastroPaciente()
        {
            InitializeComponent();
        }

        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;Database=bdsispaciente;User=root;Pwd=etec-2018";
                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "Erro acesso a base de dados!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string sexo;
        string cor;
        string obito;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "SELECT * FROM PESSOA WHERE id = " + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strsql;
                objDados = objCmd.ExecuteReader();
                if (objDados.HasRows)
                {
                    MessageBox.Show("Código existente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbCadastroPaciente.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strsql = "INSERT INTO PESSOA (id, nome, email, sexo, cor, endereco, obito) values(";
                    strsql += txtCodigo.Text + ",";
                    strsql += "'" + txtNome.Text + "',";
                    strsql += "'" + txtEmail.Text + "',";
                    strsql += "'" + sexo + "',";
                    strsql += "'" + cor + "',";
                    strsql += "'" + txtEndereco.Text + "',";
                    strsql += "'" + obito + "')";

                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strsql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluido com sucesso!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro >" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "SELECT * FROM PESSOA WHERE ID =" + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strSql;
                objDados = objCmd.ExecuteReader();
                if(!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Focus();
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }
                    strSql = "UPDATE PESSOA SET ";
                    strSql += "nome = '" + txtNome.Text + "', ";
                    strSql += "email = '" + txtEmail.Text + "', ";
                    strSql += "sexo = '" + sexo + "', ";
                    strSql += "cor = '" + cor + "', ";
                    strSql += "endereco = '" + txtEndereco.Text + "', ";
                    strSql += "obito = '" + obito + "' ";
                    strSql += "WHERE ID = " + txtCodigo.Text;

                    // v_sexo = "Masculino";
                    // objCmd.Parameters.AddWithValue("@sexo", v_sexo);
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro alterado com sucesso!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch(Exception Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "SELECT * FROM PESSOA WHERE id = " + txtCodigo.Text;
                objCmd.Connection = objCnx;
                objCmd.CommandText = strsql;
                objDados = objCmd.ExecuteReader();
                if (!objDados.HasRows)
                {
                    MessageBox.Show("Codigo inexistente !", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!objDados.IsClosed) { objDados.Close(); }

                    if (MessageBox.Show("Deseja excluir?", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == (DialogResult.Yes))
                    {
                        strsql = "DELETE FROM PESSOA WHERE id = " + txtCodigo.Text;
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strsql;
                        objCmd.ExecuteNonQuery();

                        txtCodigo.Text = "";
                        txtNome.Text = "";
                        txtEmail.Text = "";
                        ckbObito.Checked = false;
                        rdbFeminino.Checked = true;
                        txtEndereco.Text = "";
                        cmbCor.SelectedIndex = -1;
                        txtCodigo.Focus();
                        MessageBox.Show("Registro eliminado com sucesso!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!objDados.IsClosed) { objDados.Close(); }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            ckbObito.Checked = false;
            txtEndereco.Text = "";
            cmbCor.SelectedIndex = -1;
            rdbFeminino.Checked = true;
            txtCodigo.Focus();
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void cmbCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCor.SelectedIndex == 0)
            {
                cor = "Branco";
            }
            if(cmbCor.SelectedIndex == 1)
            {
                cor = "Negro";
            }
            if(cmbCor.SelectedIndex == 2)
            {
                cor = "Pardo";
            }
        }

        private void ckbObito_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbObito.Checked == true)
            {
                obito = "S";
            }
            if(ckbObito.Checked == false)
            {
                obito = "N";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql = "SELECT * FROM PESSOA ORDER BY id";
                objCmd.Connection = objCnx;
                objCmd.CommandText = strsql;
                objDados = objCmd.ExecuteReader();

                if (!objDados.HasRows)
                {
                    MessageBox.Show("Código inexistente!!!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Focus();
                }
                else
                {
                    while (objDados.Read())
                    {
                        dgvPacientes.Rows.Add(objDados["id"].ToString(), objDados["nome"].ToString(),
                            objDados["email"].ToString(), objDados["sexo"].ToString(),
                            objDados["cor"].ToString(), objDados["endereco"].ToString(),
                            objDados["obito"].ToString());
                    }
                }
                objDados.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            dgvPacientes.Rows.Clear();
        }
    }
}
