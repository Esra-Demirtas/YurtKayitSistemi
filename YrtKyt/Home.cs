using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YrtKyt
{
    public partial class Home : Form
    {
        private Form activeForm;

        public Home(string user_role)
        {
            InitializeComponent();

            if (user_role == "False")
            {
                /* car_edit.Visible = false;
                 customer_edit.Visible = false;
                 reservation_edit.Visible = false;
                 invoice_edit.Visible = false;
                */
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            //ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rooms()); 
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
             System.Windows.Forms.Application.Exit();
        }
    }
}
