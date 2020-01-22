using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje1._1
{
    public partial class WishList : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public static bool istek=false;
        public static bool eklendi = false;          
        public WishList()
        {
            InitializeComponent();
        }
        private void WishList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet8.dbt_istekler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_isteklerTableAdapter.Fill(this.libraryotoDataSet8.dbt_istekler);
           
        }
        private void bftxt_BookName_Enter(object sender, EventArgs e)
        {
            if (bftxt_BookName.Text=="Kitap Adı")
            {
                bftxt_BookName.Text = "";
            }
        }
        private void bftxt_BookName_Leave(object sender, EventArgs e)
        {
            if (bftxt_BookName.Text == "")
            {
                bftxt_BookName.Text = "Kitap Adı";
            }
        }

        private void bftxt_AuthorName_Enter(object sender, EventArgs e)
        {
            if (bftxt_AuthorName.Text=="Yazarı")
            {
                bftxt_AuthorName.Text = "";
            }
        }

        private void bftxt_AuthorName_Leave(object sender, EventArgs e)
        {
            if (bftxt_AuthorName.Text == "")
            {
                bftxt_AuthorName.Text = "Yazarı";
            }
        }

        private void bftxt_UserNumber_Enter(object sender, EventArgs e)
        {
            if (bftxt_UserNumber.Text=="Üye Numarası")
            {
                bftxt_UserNumber.Text = "";
            }
        }

        private void bftxt_UserNumber_Leave(object sender, EventArgs e)
        {
            if (bftxt_UserNumber.Text == "")
            {
                bftxt_UserNumber.Text = "Üye Numarası";
            }
        }

        void AddData()
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                string sorgu = "Insert into dbt_istekler (adı,yazarı,isteyenid) values (@name,@author,@userId)";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@name", bftxt_BookName.Text);
                command.Parameters.AddWithValue("@author", bftxt_AuthorName.Text);
                command.Parameters.AddWithValue("@userId", bftxt_UserNumber.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Öğrenci Numarası Hatalı");
            }
       
         
        }
        void Update()
        {
            try
            {
                string kitapid;
                if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                    kitapid = Convert.ToString(selectedRow.Cells["id"].Value);

                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "UPDATE  dbt_istekler Set adı=@name,yazarı=@author,isteyenid=@userid where id=@bookid";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@name", bftxt_BookName.Text);
                    command.Parameters.AddWithValue("@author", bftxt_AuthorName.Text);
                    command.Parameters.AddWithValue("@userid", bftxt_UserNumber.Text);
                    command.Parameters.AddWithValue("@bookid", Int32.Parse(kitapid));
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
   
        }
        void Clean()
        {
            bftxt_UserNumber.Text = "Üye Numarası";
            bftxt_BookName.Text = "Kitap Adı";
            bftxt_AuthorName.Text = "Yazzarı";
        }
        private void bffbtn_AddStaff_Click(object sender, EventArgs e)
        {
            AddData();
            Clean();
            WishList_Load(sender, e);
        }

        private void bfbtn_Update_Click(object sender, EventArgs e)
        {
            Update();
            Clean();
            WishList_Load(sender, e);
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                bftxt_AuthorName.Text = Convert.ToString(selectedRow.Cells["yazarı"].Value);
                bftxt_BookName.Text = Convert.ToString(selectedRow.Cells["adı"].Value);
                bftxt_UserNumber.Text = Convert.ToString(selectedRow.Cells["isteyenid"].Value);

            }
        }
        public  void AddLibrary()
        {
            try
            {
                string kitapid;
                if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                    kitapid = Convert.ToString(selectedRow.Cells["id"].Value);
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    command = new SqlCommand();
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "DELETE  FROM dbt_istekler where id=@bookid";
                    command.Parameters.AddWithValue("@bookid", Int32.Parse(kitapid));
                    command.ExecuteNonQuery();
                    connection.Close();
                    this.dbt_isteklerTableAdapter.Fill(this.libraryotoDataSet8.dbt_istekler);
                }
            }catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
      
        }
        private void bfbtn_CleanTextBox_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void bfbtn_Delete_Click(object sender, EventArgs e)
        {
            EditBooks eb = new EditBooks();
            eb.Owner = this;
            eb.Show();
            istek = true;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                WishList eb = new WishList();
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
