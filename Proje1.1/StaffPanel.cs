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
    public partial class StaffPanel : Form
    {
        public StaffPanel()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
     

        private void StaffPanel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet.dbt_admin' tablosuna veri yükler. 
            this.dbt_adminTableAdapter.Fill(this.libraryotoDataSet.dbt_admin);

        }


        //Textboc placeholder events
        private void bftxt_UserNumber_Enter(object sender, EventArgs e)
        {

            if (bftxt_UserNumber.Text == "Kullanıcı No")
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

        private void bftxt_Surname_Enter(object sender, EventArgs e)
        {
            if (bftxt_Surname.Text == "Soyadı")
            {
                bftxt_Surname.Text = "";
            }
        }

        private void bftxt_Surname_Leave(object sender, EventArgs e)
        {
            if (bftxt_Surname.Text == "")
            {
                bftxt_Surname.Text = "Soyadı";
            }
        }

        private void bftxt_Status_Enter(object sender, EventArgs e)
        {
            if (bftxt_Status.Text == "Statü")
            {
                bftxt_Status.Text = "";
            }
        }

        private void bftxt_Status_Leave(object sender, EventArgs e)
        {

            if (bftxt_Status.Text == "")
            {
                bftxt_Status.Text = "Statü";
            }
        }

        private void bftxt_Password_Enter(object sender, EventArgs e)
        {
            if (bftxt_Password.Text == "Şifre")
            {
                bftxt_Password.Text = "";
            }
        }

        private void bftxt_Password_Leave(object sender, EventArgs e)
        {
            if (bftxt_Password.Text == "")
            {
                bftxt_Password.Text = "Şifre";
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                bftxt_Name.Text= Convert.ToString(selectedRow.Cells["name"].Value);
                bftxt_UserNumber.Text = Convert.ToString(selectedRow.Cells["usernumber"].Value);
                bftxt_Surname.Text = Convert.ToString(selectedRow.Cells["surname"].Value);
                bftxt_Password.Text = Convert.ToString(selectedRow.Cells["password"].Value);
                bftxt_Status.Text = Convert.ToString(selectedRow.Cells["status"].Value);
                
            }
        }

        void Clean()
        {
            bftxt_Name.Text = "Adı";
            bftxt_UserNumber.Text = "Kullanıcı No";
            bftxt_Surname.Text = "Soyadı";
            bftxt_Password.Text = "Şifre";
            bftxt_Status.Text = "Statü";
        }
        private void bfbtn_CleanTextBox_Click(object sender, EventArgs e)
        {
            Clean();
        }
        
        private void bfbtn_Delete_Click(object sender, EventArgs e)
        {
            try {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                command = new SqlCommand();
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE  FROM dbt_admin where kullanicino='" + bftxt_UserNumber.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                Clean();
                StaffPanel_Load(sender, e);
            }catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
            
        }
        public bool TextControl()
        {
            if(bftxt_Status.Text=="1"||bftxt_Status.Text=="2"||bftxt_Status.Text=="3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void bffbtn_AddStaff_Click(object sender, EventArgs e)
        {
            if (TextControl() == true)
            {
                try
                {
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "Insert into dbt_admin (kullanicino,adi,soyadi,statu,sifre) values (@usernumber,@name,@surname,@status,@password)";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@usernumber", Convert.ToInt32(bftxt_UserNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@surname", bftxt_Surname.Text);
                    command.Parameters.AddWithValue("@status", bftxt_Status.Text);
                    command.Parameters.AddWithValue("@password", bftxt_Password.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    Clean();
                    StaffPanel_Load(sender, e);
                }
                catch(SqlException exp)
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız"+ Environment.NewLine + exp.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Statüsü Hatalı");
            }
           

        }

        private void bfbtn_Update_Click(object sender, EventArgs e)
        {
            if(TextControl()==true)
            {
                try
                {
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "UPDATE  dbt_admin Set kullanicino=@usernumber,adi=@name,soyadi=@surname,statu=@status,sifre=@password where kullanicino=@usernumber";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@usernumber", Convert.ToInt32(bftxt_UserNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@surname", bftxt_Surname.Text);
                    command.Parameters.AddWithValue("@status", bftxt_Status.Text);
                    command.Parameters.AddWithValue("@password", bftxt_Password.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Güncellendi");
                    Clean();
                    StaffPanel_Load(sender, e);
                }
                catch(SqlException exp)
                {
                    MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Statüsü Hatalı Girildi");
                    
            }
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                StaffPanel eb = new StaffPanel();
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
            MainWindow lp = new MainWindow();
            lp.Show();
        }
    }
}

