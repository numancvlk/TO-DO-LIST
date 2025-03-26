using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace To_Do_List.Formlar
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = todoListDB; userID = postgres; password = password");
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (tb_mail.Text == "")
            {
                errorProvider1.SetError(tb_mail, "MAİL ALANI BOŞ GEÇİLEMEZ");
            }
            else if (tb_sifre.Text == "")
            {
                errorProvider1.SetError(tb_sifre, "ŞİFRE ALANI BOŞ GEÇİLEMEZ");
            }
            else
            {
                connection.Open();
                string sqlSorgum = "SELECT * FROM users WHERE user_mail = @p1 AND user_password = @p2";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", tb_mail.Text);
                npgsqlCommand.Parameters.AddWithValue("@p2", tb_sifre.Text);
                NpgsqlDataReader npgsqlDataReader = npgsqlCommand.ExecuteReader();

                if (npgsqlDataReader.Read())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI HOŞGELDİNİZ", "HOŞGELDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ToDoList toDoList = new ToDoList();
                    toDoList.label7.Text = npgsqlDataReader["user_id"].ToString();
                    toDoList.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("GİRİŞ BAŞARISIZ TEKRAR DENEYİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }

        private void ll_hesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HesapOluşturmaFormu hesapOluşturmaFormu = new HesapOluşturmaFormu();
            hesapOluşturmaFormu.Show();
            this.Hide();
        }

        private void GirisFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
