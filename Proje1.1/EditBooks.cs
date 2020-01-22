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
    
    public partial class EditBooks : Form
    {
        public static bool closed = false;
        public EditBooks()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        private void EditBooks_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet9.dbt_kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_kitaplarTableAdapter3.Fill(this.libraryotoDataSet9.dbt_kitaplar);
        
            bunifuCustomDataGrid1.Enabled = true;
            bftxt_Status.Enabled = false;
            for (int i = 0; i <11; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Width = bunifuCustomDataGrid1.Width / 11;
            }


        }
        public bool TextControl()
        {
            bool attr;
            if(bftxt_attr.Text=="0" || bftxt_attr.Text == "1")
            {
                attr = true;
                return true;
            }
            else
            {
                MessageBox.Show("Kitap Niteliği Hatalı Girildi");
                return false;
            }
        }
        void Clean()
        {
            bftxt_Name.Text = "Adı";
            bftxt_authorNumber.Text = "Yazar No";
            bftxt_volume.Text = "Cilt Numarası";
            bftxt_Status.Text = "Durum";
            bftxt_AccesDate.Text = "Erişim Tarihi";
            bftxt_PageNumber.Text = "Sayfa Sayısı";
            bftxt_language.Text = "Dil";
            bftxt_attr.Text = "Nitelik";
            bftxt_Id.Visible = false;
            bftxt_Id.Text = "";
            bftxt_Edition.Text = "Baskı No";
        }
        void AddData()
        {
            if (TextControl() == true)
            {
                try
                {
                    string status = "1";
                    DateTime dt = DateTime.Today;
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "INSERT INTO dbt_kitaplar(yazarno,adı,cilt,durum,sayfasayisi,dil,nitleik,baskino,erisim,yer) values(@authornumber,@name,@volume,@status,@pagenumber,@language,@attr,@edition,@accestime,@yer)";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@authornumber", Convert.ToInt32(bftxt_authorNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@volume", bftxt_volume.Text);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@pagenumber", bftxt_PageNumber.Text);
                    command.Parameters.AddWithValue("@language", bftxt_language.Text);
                    command.Parameters.AddWithValue("@attr", bftxt_attr.Text);
                    command.Parameters.AddWithValue("@edition", bftxt_Edition.Text);
                    command.Parameters.AddWithValue("@accestime",dt);
                    command.Parameters.AddWithValue("@yer", bftxt_Location.Text);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    if (WishList.istek == true)
                    {

                        ((WishList)this.Owner).AddLibrary();

                    }
                }
                catch (SqlException Ex)
                {
                   
                        MessageBox.Show("Yazar Numarası Hatalı Girildi");
                    
                }
            }
            
        }
        void DeleteData()
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE  FROM dbt_kitaplar where kitapid='" + bftxt_Id.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                Clean();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
        }
        void UpdateData()
        {
            if (TextControl() == true)
            {

                try
                {
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "UPDATE dbt_kitaplar set adı=@name,cilt=@volume,durum=@status,sayfasayisi=@pagenumber,dil=@language,nitleik=@attr,baskino=@edition where yazarno=@authornumber";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@authornumber", Convert.ToInt32(bftxt_authorNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@volume", bftxt_volume.Text);
                    command.Parameters.AddWithValue("@status", bftxt_Status.Text);
                    command.Parameters.AddWithValue("@pagenumber", bftxt_PageNumber.Text);
                    command.Parameters.AddWithValue("@language", bftxt_language.Text);
                    command.Parameters.AddWithValue("@attr", bftxt_attr.Text);
                    command.Parameters.AddWithValue("@edition", bftxt_Edition.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(SqlException exp)
                {
                    MessageBox.Show("Hata Oluştu" + " " + "Yazar Numarasından Kaynaklı Olabilir" + Environment.NewLine + exp.ToString());
                }
                
            }
        }
        private void bfbtn_CleanTextBox_Click(object sender, EventArgs e)
        {
            Clean();
        }


        // Textbox focus events
        private void bftxt_authorNumber_Enter(object sender, EventArgs e)
        {
            if(bftxt_authorNumber.Text=="Yazar No")
            {
                bftxt_authorNumber.Text = "";
            }
           
        }

        private void bftxt_authorNumber_Leave(object sender, EventArgs e)
        {
            if (bftxt_authorNumber.Text == "")
            {
                bftxt_authorNumber.Text = "Yazar No";
            }
        }

        private void bftxt_Name_Enter(object sender, EventArgs e)
        {
            if (bftxt_Name.Text == "Adı")
            {
                bftxt_Name.Text = "";
            }
        }

        private void bftxt_Name_Leave(object sender, EventArgs e)
        {
            if (bftxt_Name.Text == "")
            {
                bftxt_Name.Text = "Adı";
            }
        }

        private void bftxt_volume_Enter(object sender, EventArgs e)
        {

            if (bftxt_volume.Text == "Cilt Numarası")
            {
                bftxt_volume.Text = "";
            }
        }

        private void bftxt_volume_Leave(object sender, EventArgs e)
        {
            if (bftxt_volume.Text == "")
            {
                bftxt_volume.Text = "Cilt Numarası";
            }
        }

        private void bftxt_Status_Enter(object sender, EventArgs e)
        {
            if (bftxt_Status.Text=="Durum")
            {
                bftxt_Status.Text = "";    
            }
        }

        private void bftxt_Status_Leave(object sender, EventArgs e)
        {
            if (bftxt_Status.Text == "")
            {
                bftxt_Status.Text = "Durum";
            }
        }

        private void bftxt_AccesDate_Enter(object sender, EventArgs e)
        {
            if (bftxt_AccesDate.Text=="Erişim Tarihi")
            {
                bftxt_AccesDate.Text = "";
            }
        }

        private void bftxt_AccesDate_Leave(object sender, EventArgs e)
        {
            if (bftxt_AccesDate.Text == "")
            {
                bftxt_AccesDate.Text = "Erişim Tarihi";
            }
        }

        private void bftxt_PageNumber_Enter(object sender, EventArgs e)
        {
            if (bftxt_PageNumber.Text=="Sayfa Sayısı")
            {
                bftxt_PageNumber.Text = "";    
            }
        }

        private void bftxt_PageNumber_Leave(object sender, EventArgs e)
        {
            if (bftxt_PageNumber.Text == "")
            {
                bftxt_PageNumber.Text = "Sayfa Sayısı";
            }
        }

        private void bftxt_language_Enter(object sender, EventArgs e)
        {
            if (bftxt_language.Text == "Dil")
            {
                bftxt_language.Text = "";
            }
        }

        private void bftxt_language_Leave(object sender, EventArgs e)
        {
            if (bftxt_language.Text == "")
            {
                bftxt_language.Text = "Dil";
            }
        }

        private void bftxt_attr_Enter(object sender, EventArgs e)
        {
            if (bftxt_attr.Text=="Nitelik")
            {
                bftxt_attr.Text = "";
            }
        }

        private void bftxt_attr_Leave(object sender, EventArgs e)
        {
            if (bftxt_attr.Text == "")
            {
                bftxt_attr.Text = "Nitelik";
            }
        }

        private void bffbtn_AddStaff_Click(object sender, EventArgs e)
        {
            AddData();
            EditBooks_Load(sender, e);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Author aut = new Author();
            aut.Show();
        }

        private void bfbtn_Update_Click(object sender, EventArgs e)
        {
            UpdateData();
            EditBooks_Load(sender, e);
            Clean();
        }

        private void bfbtn_Delete_Click(object sender, EventArgs e)
        {
            DeleteData();
            EditBooks_Load(sender, e);
            Clean();
        }
       
 
       
        
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                bftxt_Name.Text = Convert.ToString(selectedRow.Cells["adı"].Value);
                bftxt_authorNumber.Text = Convert.ToString(selectedRow.Cells["yazarno"].Value);
                bftxt_volume.Text = Convert.ToString(selectedRow.Cells["cilt"].Value);
                bftxt_Status.Text = Convert.ToString(selectedRow.Cells["durum"].Value);
                bftxt_AccesDate.Text = Convert.ToString(selectedRow.Cells["erisim"].Value);
                bftxt_PageNumber.Text = Convert.ToString(selectedRow.Cells["sayfasayisi"].Value);
                bftxt_language.Text = Convert.ToString(selectedRow.Cells["dil"].Value);
                bftxt_attr.Text = Convert.ToString(selectedRow.Cells["nitleik"].Value);
                bftxt_Edition.Text = Convert.ToString(selectedRow.Cells["baskino"].Value);
                bftxt_Id.Text = Convert.ToString(selectedRow.Cells["kitapid"].Value);
                bftxt_Id.Visible = true;
                bftxt_Location.Text = Convert.ToString(selectedRow.Cells["yer"].Value);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                EditBooks eb = new EditBooks();
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
            if (WishList.istek == true)
            {
                this.Close();
                WishList.istek = false;
            }
            else
            {
                this.Close();
                LibPanel lp = new LibPanel();
                lp.Show();
            }
         
        }

        private void bftxt_Edition_Enter(object sender, EventArgs e)
        {
            if (bftxt_Edition.Text=="Baskı No")

            {
                bftxt_Edition.Text = "";
            }
        }

        private void bftxt_Edition_Leave(object sender, EventArgs e)
        {
            if (bftxt_Edition.Text == "")

            {
                bftxt_Edition.Text = "Baskı No";
            }
        }

        private void txtPanel_Enter(object sender, EventArgs e)
        {

        }

        private void bftxt_Location_Enter(object sender, EventArgs e)
        {
            if (bftxt_Location.Text=="Yer")
            {
                bftxt_Location.Text = "";
            }
        }

        private void bftxt_Location_Leave(object sender, EventArgs e)
        {
            if (bftxt_Location.Text == "")
            {
                bftxt_Location.Text = "Yer";
            }
        }
    }
}
