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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet7.dbt_kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_kitaplarTableAdapter.Fill(this.libraryotoDataSet7.dbt_kitaplar);
      
      
            for (int i = 0; i < bfDG_Books.RowCount ; i++)
            {
                
                string s = bfDG_Books.Rows[i].Cells[4].Value.ToString();
                if (Int32.Parse(s)==0)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        bfDG_Books.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                   
                }
                else
                {

                }
            }  
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BookList eb = new BookList();
                this.Close();
                Application.Exit();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            LibPanel lp = new LibPanel();
            lp.Show();
        }
    }
}
