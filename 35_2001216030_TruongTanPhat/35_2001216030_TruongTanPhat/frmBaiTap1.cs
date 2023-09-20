using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_2001216030_TruongTanPhat
{
    public partial class frmBaiTap1 : Form
    {
        ErrorProvider errorprovider;
        public frmBaiTap1()
        {
            errorprovider = new ErrorProvider();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBaiTap1_Load(object sender, EventArgs e)
        {

        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "This is not valid number");
            else
                this.errorProvider1.Clear();
        }
        private void frmBT1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            else
                this.errorProvider1.Clear();
        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + txtYourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            txtYourName.Focus();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
