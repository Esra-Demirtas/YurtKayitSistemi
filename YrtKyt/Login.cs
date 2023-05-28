using Microsoft.Win32;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace YrtKyt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OracleConnection cnn;
        OracleCommand cmd;
        OracleDataReader dr;

        string connetionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = orcl))); User ID = USER1; Password=8181;";
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {

           // connetionString = "Data Source=localhost;User Id=USER1;Password=8181;";
            cnn = new OracleConnection(connetionString);

            if (!string.IsNullOrEmpty(username_textbox.Text) && !string.IsNullOrEmpty(password_textbox.Text))
            {
                //Session = username_textbox.Text;
                cnn.Open();

                cmd = new OracleCommand("SELECT * FROM users WHERE user_name = :username AND password = :password", cnn);
                cmd.Parameters.Add(new OracleParameter("username", username_textbox.Text));
                cmd.Parameters.Add(new OracleParameter("password", password_textbox.Text));

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();

                    cmd = new OracleCommand("SELECT user_role FROM users WHERE user_name = :username", cnn);
                    cmd.Parameters.Add(new OracleParameter("username", username_textbox.Text));

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        bool user_role = dr.GetBoolean(0);

                        Home home = new Home(user_role.ToString());
                        home.ShowDialog();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Hatalı şifre veya kullanıcı adı girdiniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cnn.Close();
            }
            else
            {
                MessageBox.Show("Lütfen hem şifrenizi hem kullanıcı adınızı giriniz ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
