using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proje1._1
{



    public partial class Eav : Form
    {
       
        public Eav()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        SqlCommand command1;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Author aut = new Author();
            aut.Show();
        }
        public string Uzerimdekiler(string a)//Üyenin üzerinde izin verilenden fazla kitap bulunuramaması gerek
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                string sorgu = "Select count(ogrencino) from dbt_uzerimdekiler where ogrencino='" + a + "'";
                command = new SqlCommand(sorgu, connection);
                connection.Open();
                object sonuc = command.ExecuteScalar();
                int count;
                if (sonuc != null)
                {
                    count = Convert.ToInt32(sonuc);
                }
                else
                {
                    count = 0;
                }
                connection.Close();
                return count.ToString();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
                return "0";
            }
            
           
        }
        int kitapsayisi;
        int gün;
        public bool control(string s)
        {
            try
            {
                if (Int32.Parse(MemberType(s)) == 1)
                {
                    kitapsayisi = 3;
                    gün = 15;
                }
                else if (Int32.Parse(MemberType(s)) == 2)
                {
                    kitapsayisi = 5;
                    gün = 30;
                }
                else if (Int32.Parse(MemberType(s)) == 3)
                {
                    kitapsayisi = 10;
                    gün = 90;
                }
            }
            catch
            {
                MessageBox.Show("Hatalı Kullanıcı Numarası ya da Kullanıcı Kayıdı Eksik");
            }
            try
            {
                MessageBox.Show(BookStatus(bftxt_Id.Text));
                if (Int32.Parse(Uzerimdekiler(s)) >= kitapsayisi)
                {
                    return false;
                }
                else if (Int32.Parse(BookStatus(bftxt_Id.Text)) == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Hatalı Kitap Numarası");
                return false;
            }
           

        }
        public string BookStatus(string a)
        {
            try
            {
                connection.Open();
                string sorgu = "Select durum from dbt_kitaplar where kitapid='" + a + "'";
                command = new SqlCommand(sorgu, connection);
                string s = "";
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {

                    s = read["durum"].ToString();

                }
                connection.Close();
                return s;
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
                return "";
            }
            
        }
        public  string  MemberType(string a)
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                connection.Open();
                string sorgu = "Select uyetipi from dbt_ogrenciler where ogrencino='" + a + "'";
                command = new SqlCommand(sorgu, connection);
                string s = "";
                SqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {

                    s = read["uyetipi"].ToString();

                }
                connection.Close();
                return s;
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
                return "";
            }
        }


           
        
        public DateTime Accestime(string t)
        {
            
            DateTime dt = DateTime.Today;
            if (Int32.Parse(t) == 1)
            {
                dt=dt = dt.AddDays(15);
            }
            else if (Int32.Parse(t) == 2)
            {
                dt=dt.AddDays(30);
            }
            else if(Int32.Parse(t) == 3)
            {
                dt=dt.AddDays(90);
              
            }

            return dt;
        }
        void Addata()
        {
            try
            {
                DateTime dt1 = Accestime(MemberType(bftxt_UserNumber.Text));
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                string sorgu = "insert into dbt_uzerimdekiler(ogrencino,kitapid,erisim) values(@memberno,@bookid,@accesdate)";
                command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@memberno", bftxt_UserNumber.Text);
                command.Parameters.AddWithValue("@bookid", bftxt_Id.Text);
                command.Parameters.AddWithValue("@accesdate", dt1);
                string sorgu1 = "update dbt_kitaplar set erisim=@acces where kitapid=@bookid";
                command1 = new SqlCommand(sorgu1, connection);
                command1.Parameters.AddWithValue("@bookid", bftxt_Id.Text);
                command1.Parameters.AddWithValue("@acces", dt1);
                connection.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                connection.Close();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
          
        }
        int flag = 1;
        int durum;
        int Update(int a)
        {
            string bıd,kıd;


            try
            {
                if (a == 0)
                {
                    durum = 0;
                    bıd = bftxt_Id.Text;
                    kıd = bftxt_UserNumber.Text;
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "UPDATE  dbt_kitaplar Set durum=@status where kitapid=@kitapid";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@kitapid", Convert.ToInt32(bıd));
                    command.Parameters.AddWithValue("@status", durum);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    durum = 1;
                    bıd = bftxt_Iade_Kıtap_Id.Text;
                    kıd = bftxt_Iade_Kullanıcı_No.Text;
                    DateTime dt = DateTime.Today;
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu1 = "update dbt_kitaplar set erisim=@acces,durum=@status where kitapid=@bookid";
                    command1 = new SqlCommand(sorgu1, connection);
                    command1.Parameters.AddWithValue("@bookid", bıd);
                    command1.Parameters.AddWithValue("@acces", dt);
                    command1.Parameters.AddWithValue("@status", durum);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hatalı Giriş" + Environment.NewLine + exp.ToString());
            }
            return a;
        }
        void Clear()
        {
            bftxt_Iade_Kullanıcı_No.Text = "Kullanıcı No";
            bftxt_Iade_Kıtap_Id.Text = "Kitap Id";
            bftxt_UserNumber.Text = "Kullanıcı No";
            bftxt_Id.Text = "Kitap Id";
        }
        void Give()
        {
            if (control(bftxt_UserNumber.Text))
            {
                Addata();
                Update(0);
                

            }
            else
            {
                MessageBox.Show("Üye Daha Fazla Kitap Alamaz ya da Kitap Müsait Değil");
            }
        }
        void Delete()
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE  FROM dbt_uzerimdekiler where kitapid='" + bftxt_Iade_Kıtap_Id.Text + "' and ogrencino='" + bftxt_Iade_Kullanıcı_No.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                flag = -1;
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());

            }
        }
        void Get()
        {
            Delete();
            Update(1);
        }


        private void bffbtn_AddStaff_Click(object sender, EventArgs e)
        {
            Give();
            Clear();
            Eav_Load(sender, e);
          
        }

        private void bfbtn_Delete_Click(object sender, EventArgs e)
        {
            Get();
            Clear();
            Eav_Load(sender, e);
        }

        private void Eav_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet6.dbt_uzerimdekiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_uzerimdekilerTableAdapter1.Fill(this.libraryotoDataSet6.dbt_uzerimdekiler);
            // TODO: Bu kod satırı 'libraryotoDataSet5.dbt_uzerimdekiler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_uzerimdekilerTableAdapter.Fill(this.libraryotoDataSet5.dbt_uzerimdekiler);
            bunifuCustomDataGrid1.Columns[0].Width = bunifuCustomDataGrid1.Width / 3;
            bunifuCustomDataGrid1.Columns[1].Width = bunifuCustomDataGrid1.Width / 3;
            bunifuCustomDataGrid1.Columns[2].Width = bunifuCustomDataGrid1.Width / 3;
            if (LogIn.status == true)
            {
                bunifuImageButton5.Visible = false;
            }
        }

        private void bftxt_Id_Enter(object sender, EventArgs e)
        {
            if (bftxt_Id.Text=="Kitap Id")
            {
                bftxt_Id.Text = "";
            }
        }

        private void bftxt_Id_Leave(object sender, EventArgs e)
        {
            if (bftxt_Id.Text == "")
            {
                bftxt_Id.Text = "Kitap Id";
            }
        }

        private void bftxt_UserNumber_Enter(object sender, EventArgs e)
        {
            if (bftxt_UserNumber.Text=="Kullanıcı No")
            {
                bftxt_UserNumber.Text = "";
            }
        }

        private void bftxt_UserNumber_Leave(object sender, EventArgs e)
        {

            if (bftxt_UserNumber.Text == "")
            {
                bftxt_UserNumber.Text = "Kullanıcı No";
            }
        }

        private void bftxt_Iade_Kullanıcı_No_Enter(object sender, EventArgs e)
        {
            if (bftxt_Iade_Kullanıcı_No.Text=="Kullanıcı No")
            {
                bftxt_Iade_Kullanıcı_No.Text = "";
            }
        }

        private void bftxt_Iade_Kullanıcı_No_Leave(object sender, EventArgs e)
        {
            if (bftxt_Iade_Kullanıcı_No.Text == "")
            {
                bftxt_Iade_Kullanıcı_No.Text = "Kullanıcı No";
            }
        }

        private void bftxt_Iade_Kıtap_Id_Enter(object sender, EventArgs e)
        {
            if (bftxt_Iade_Kıtap_Id.Text=="Kitap Id")
            {
                bftxt_Iade_Kıtap_Id.Text = "";
            }
        }

        private void bftxt_Iade_Kıtap_Id_Leave(object sender, EventArgs e)
        {
            if (bftxt_Iade_Kıtap_Id.Text == "")
            {
                bftxt_Iade_Kıtap_Id.Text = "Kitap Id";
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                bftxt_Iade_Kullanıcı_No.Text = Convert.ToString(selectedRow.Cells["ogrencino"].Value);
                bftxt_Iade_Kıtap_Id.Text = Convert.ToString(selectedRow.Cells["kitapid"].Value);
              
               

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Eav eb = new Eav();
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
