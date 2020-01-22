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
    public partial class LibPanel : Form
    {
        public LibPanel()
        {
            InitializeComponent();
        }

        private void bnfbtn_EditMembers_Click(object sender, EventArgs e)
        {
            Members mbr = new Members();
            mbr.Show();
            this.Hide();
        }

        private void bfbtn_EditBooks_Click(object sender, EventArgs e)
        {
            EditBooks eb = new EditBooks();
            eb.Show();
            this.Hide();
        }

        private void bfbtn_Eav_Click(object sender, EventArgs e)
        {
            Eav eav = new Eav();
            eav.Show();
            this.Hide();
        }

        private void bfbtn_listbooks_Click(object sender, EventArgs e)
        {
            BookList bl = new BookList();
            bl.Show();
            this.Hide();
        }

        private void bfbtn_WishList_Click(object sender, EventArgs e)
        {
            WishList wl = new WishList();
            wl.Show();
            this.Hide();
        }
    }
}
