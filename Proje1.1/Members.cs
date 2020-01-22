using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Proje1._1
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlCommand command;
        
        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'libraryotoDataSet4.dbt_ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.dbt_ogrencilerTableAdapter1.Fill(this.libraryotoDataSet4.dbt_ogrenciler);
            bfgp_Payments.Visible = false;
            pictureBox2.Visible = false;
            comboBox1.SelectedIndex = 0;
            bfbtn_Book.Enabled = false;
            bfbtn_Cash.Enabled = false;
            bftxt_Debt.Enabled = false;
      
        }

        //Database Methods

        void Clean()
        {
            bftxt_Name.Text = "Adı";
            bftxt_UserNumber.Text = "Kullanıcı No";
            bunifuMaterialTextbox2.Text = "Soyadı";
            bftxt_PhoneNumber.Text = "Telefon Numarası";
            bftxt_Department.Text = "Bölüm";
            bftxt_Eposta.Text = "E Posta";
            bftxt_Faculty.Text = "Fakülte";
           
        }
        public static bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool TextControl()
        {

            bool tel = IsPhoneNumber(bftxt_PhoneNumber.Text);
            bool email = IsEmail(bftxt_Eposta.Text);
            bool id;
            if (bftxt_UserNumber.Text.Length==9)
            {
                id = true;
            }
            else
            {
                id = false;
            }
            if (tel == false)
            {
                MessageBox.Show("Telefon Numarası Hatalı");
            }
            if (email == false)
            {
                MessageBox.Show("E posta adresi Hatalı");
            }
            if (id == false)
            {
                MessageBox.Show("Id Hatalı");
            }
            if (tel && email && id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        void AddData()
        {
            if (TextControl() == true)
            {
                try
                {
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "Insert into dbt_ogrenciler (ogrencino,adi,soyadi,bolum,tel,eposta,fakulte,borc) values (@usernumber,@name,@surname,@department,@phone,@mail,@faculty,0)";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@usernumber", Convert.ToInt32(bftxt_UserNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@surname", bunifuMaterialTextbox2.Text);
                    command.Parameters.AddWithValue("@department", bftxt_Department.Text);
                    command.Parameters.AddWithValue("@phone", bftxt_PhoneNumber.Text);
                    command.Parameters.AddWithValue("@mail", bftxt_Eposta.Text);
                    command.Parameters.AddWithValue("@faculty", bftxt_Faculty.Text);
                    //command.Parameters.AddWithValue("@debts", bftxt_Debt.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException Ex)
                {
                    if (Ex.Number == 2627)
                    {
                        MessageBox.Show("Aynı Üye Kayıtlarda Mevcut");
                    }
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
                command.CommandText = "DELETE  FROM dbt_ogrenciler where ogrencino='" + bftxt_UserNumber.Text + "'";
                command.ExecuteNonQuery();
                connection.Close();
                Clean();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }
         
        }

        void DataUpdate()
        {
            if (TextControl() == true)
            {


                try
                {
                    connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                    string sorgu = "UPDATE  dbt_ogrenciler Set ogrencino=@usernumber,adi=@name,soyadi=@surname,bolum=@department,tel=@phone,eposta=@mail,fakulte=@faculty where ogrencino=@usernumber";
                    command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@usernumber", Convert.ToInt32(bftxt_UserNumber.Text));
                    command.Parameters.AddWithValue("@name", bftxt_Name.Text);
                    command.Parameters.AddWithValue("@surname", bunifuMaterialTextbox2.Text);
                    command.Parameters.AddWithValue("@department", bftxt_Department.Text);
                    command.Parameters.AddWithValue("@phone", bftxt_PhoneNumber.Text);
                    command.Parameters.AddWithValue("@mail", bftxt_Eposta.Text);
                    command.Parameters.AddWithValue("@faculty", bftxt_Faculty.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
                }

            }
           
         
         
        }
        //UI Methods
        private bool IsPhoneNumber(string Parametre)
        {
            string desen = @"^(05(\d{9}))$";
            Match match = Regex.Match(Parametre, desen, RegexOptions.IgnoreCase);

            return match.Success;
        }

        void PaymentMethod()
        {
           
            if(comboBox1.SelectedIndex ==1)
            {
                bfbtn_Cash.Enabled = true;
                bfbtn_Book.Enabled = false;
            }
            else if(comboBox1.SelectedIndex ==2)
            {
                bfbtn_Book.Enabled = true;
                bfbtn_Cash.Enabled = false;
            }
        }
        private void bftxt_UserNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        bool flag = true;

        private void bfgp_ScrollPayment_Click(object sender, EventArgs e)
        {
            if (flag)
            {

                flag = false;
                bfgp_Payments.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

            }
            else
            {

                flag = true;
                bfgp_Payments.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentMethod();
        }

        private void bftxt_Payment_Enter(object sender, EventArgs e)
        {
            if(bftxt_Payment.Text=="Ödenen Tutar'ı Giriniz")
            {
                bftxt_Payment.Text ="";
            }
        }

        private void bftxt_Payment_Leave(object sender, EventArgs e)
        {
            if (bftxt_Payment.Text == "")
            {
                bftxt_Payment.Text = "Ödenen Tutar'ı Giriniz";
            }
        }

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

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Soyadı")
            {
               bunifuMaterialTextbox2.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "Soyadı";
            }
        }

        private void bftxt_Faculty_Enter(object sender, EventArgs e)
        {
            if (bftxt_Faculty.Text == "Fakülte")
            {
                bftxt_Faculty.Text = "";
            }
        }

        private void bftxt_Faculty_Leave(object sender, EventArgs e)
        {
            if (bftxt_Faculty.Text == "")
            {
                bftxt_Faculty.Text = "Fakülte";
            }
        }

        private void bftxt_Department_Enter(object sender, EventArgs e)
        {
            if (bftxt_Department.Text == "Bölüm")
            {
                bftxt_Department.Text = "";
            }
        }

        private void bftxt_Department_Leave(object sender, EventArgs e)
        {
            if (bftxt_Department.Text == "")
            {
                bftxt_Department.Text = "Bölüm";
            }
        }

        private void bftxt_PhoneNumber_Enter(object sender, EventArgs e)
        {
            if (bftxt_PhoneNumber.Text == "Telefon Numarası")
            {
                bftxt_PhoneNumber.Text = "";
            }
        }

        private void bftxt_PhoneNumber_Leave(object sender, EventArgs e)
        {
            if (bftxt_PhoneNumber.Text == "")
            {
                bftxt_PhoneNumber.Text = "Telefon Numarası";
            }
        }

        private void bftxt_Eposta_Enter(object sender, EventArgs e)
        {
            
            if (bftxt_Eposta.Text == "E Posta")
            {
                bftxt_Eposta.Text = "";
               
            }
        }

        private void bftxt_Eposta_Leave(object sender, EventArgs e)
        {
            if (bftxt_Eposta.Text == "")
            {
                bftxt_Eposta.Text = "E Posta";
            }
        }

        private void bftxt_Eposta_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bfgp_Payments.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            bfgp_Payments.Visible =false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void bffbtn_AddStaff_Click(object sender, EventArgs e)
        {
            AddData();
            Members_Load(sender, e);
            Clean();
        }

        private void bfbtn_Delete_Click(object sender, EventArgs e)
        {
            DeleteData();
            Members_Load(sender, e);
            Clean();
        }

        private void bfbtn_Update_Click(object sender, EventArgs e)
        {
            DataUpdate();
            Members_Load(sender, e);
            Clean();
        }

        private void bfbtn_CleanTextBox_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                bftxt_Name.Text = Convert.ToString(selectedRow.Cells["adi"].Value);
                bftxt_UserNumber.Text = Convert.ToString(selectedRow.Cells["ogrencino"].Value);
                bunifuMaterialTextbox2.Text = Convert.ToString(selectedRow.Cells["soyadi"].Value);
                bftxt_Department.Text = Convert.ToString(selectedRow.Cells["bolum"].Value);
                bftxt_Faculty.Text = Convert.ToString(selectedRow.Cells["fakulte"].Value);
                bftxt_Eposta.Text = Convert.ToString(selectedRow.Cells["eposta"].Value);
                bftxt_PhoneNumber.Text = Convert.ToString(selectedRow.Cells["tel"].Value);
                bftxt_Debt.Text = Convert.ToString(selectedRow.Cells["borc"].Value);
            }

        }

        private void bfbtn_Cash_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("server=DESKTOP-RLBGONE\\SQLEXPRESS; Initial Catalog=libraryoto;Integrated Security=SSPI");
                string sorgu = "UPDATE  dbt_ogrenciler Set borc=@debt where ogrencino=@usernumber";
                command = new SqlCommand(sorgu, connection);
                float pay = float.Parse(bftxt_Debt.Text) - float.Parse(bftxt_Payment.Text);
                command.Parameters.AddWithValue("@debt", pay);
                command.Parameters.AddWithValue("@usernumber", bftxt_UserNumber.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Members_Load(sender, e);
                Clean();
            }
            catch(SqlException exp)
            {
                MessageBox.Show("Hata Oluştu" + Environment.NewLine + exp.ToString());
            }

           
        }

        private void bfbtn_Book_Click(object sender, EventArgs e)
        {
            EditBooks eb = new EditBooks();
            eb.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Program Tamamen Kapatılacaktır", "Emin Misiniz ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Members eb = new Members();
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
