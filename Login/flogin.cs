using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void flogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void buton_exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

                e.Cancel = true;
              
            }
  

        }

        private void buton_Login_Click(object sender, EventArgs e)
        {
            fManager f = new fManager();
            this.Hide();
            f.ShowDialog();
            // this.Show();
            
        }
    }
}
