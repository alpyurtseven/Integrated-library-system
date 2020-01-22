using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proje1._1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void bftbtn_GoToLibPanel_Click(object sender, EventArgs e)
        {
            LibPanel lp = new LibPanel();
            lp.Show();
            this.Hide();

        }

        private void bftbtn_GoToPersonelManagement_Click(object sender, EventArgs e)
        {

            StaffPanel sp = new StaffPanel();
            sp.Show();
            this.Hide();


        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainWindow eb = new MainWindow();
                this.Close();
                Application.Exit();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
