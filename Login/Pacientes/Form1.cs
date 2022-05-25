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
                objcnx.ConnectionString = "Server=localhost;Database=bdsispaciente;User=root;Pwd=etec-2018",
                objcnx.Open();
            }
        }
    }
}
