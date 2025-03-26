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
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server = localHost; port = 5432; Database = todoListDB; userID = postgres; password = password");
        GirisFormu girisFormu = new GirisFormu();
        private void LoadCombobox()
        {
            cb_priorty.Items.Add("Düşük");
            cb_priorty.Items.Add("Orta");
            cb_priorty.Items.Add("Yüksek");
            cb_priorty.SelectedIndex = 0;
        }
        private void LoadDataGrid()
        {
            connection.Open();
            string sqlSorgusu = "SELECT task_id AS \"TASK ID\", task_name AS \"GÖREV ADI\", task_date AS \"GÖREV ZAMANI\",task_priority AS \"ÖNCELİK DURUMU\",task_description AS \"GÖREV AÇIKLAMASI\", task_complated AS \"GÖREV DURUMU\" FROM tasks\r\n WHERE task_date = @p1 AND user_id = @p2 ORDER BY task_id";
            NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgusu, connection);
            npgsqlCommand.Parameters.AddWithValue("@p1", dateTimePicker1.Value.Date);
            npgsqlCommand.Parameters.AddWithValue("@p2", Convert.ToInt32(label7.Text));
            DataSet dataSet = new DataSet();
            NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(npgsqlCommand);
            npgsqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[0].Visible = false;
            connection.Close();
        }
        private void AddTasks()
        {
            if (tb_gorevAd.Text == "")
            {
                errorProvider1.SetError(tb_gorevAd, "GÖREV ADI BOŞ GEÇİLEMEZ");
            }
            else
            {
                connection.Open();
                string sqlSorgum = "INSERT INTO tasks (task_name,task_date,task_priority,task_description,user_id) VALUES(@p1,@p2,@p3,@p4,@p5)";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", tb_gorevAd.Text);
                npgsqlCommand.Parameters.AddWithValue("@p2", dateTimePicker2.Value.Date);
                npgsqlCommand.Parameters.AddWithValue("@p3", cb_priorty.SelectedItem.ToString());
                npgsqlCommand.Parameters.AddWithValue("@p4", tb_acıklama.Text);
                npgsqlCommand.Parameters.AddWithValue("@p5", Convert.ToInt32(label7.Text));
                npgsqlCommand.ExecuteNonQuery();
                connection.Close();
                TextBoxClear();
                LoadDataGrid();
                MessageBox.Show("YENİ GÖREV BAŞARILI BİR ŞEKİLDE EKLENDİ", "YENİ GÖREV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditTasks()
        {
            if (tb_gorevAd.Text == "")
            {
                errorProvider1.SetError(tb_gorevAd, "GÖREV ADI BOŞ GEÇİLEMEZ");
            }
            else
            {
                connection.Open();
                string sqlSorgum = "UPDATE tasks SET task_name = @p1, task_date = @p6, task_priority = @p2, task_description = @p3 WHERE user_id = @p4 AND task_id = @p5";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", tb_gorevAd.Text);
                npgsqlCommand.Parameters.AddWithValue("@p2", cb_priorty.SelectedItem.ToString());
                npgsqlCommand.Parameters.AddWithValue("@p3", tb_acıklama.Text);
                npgsqlCommand.Parameters.AddWithValue("@p4", Convert.ToInt32(label7.Text));
                npgsqlCommand.Parameters.AddWithValue("@p5", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                npgsqlCommand.Parameters.AddWithValue("@p6", dateTimePicker2.Value.Date);
                npgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("GÖREV BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ", "GÖREV GÜNCELLENDİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                TextBoxClear();
                LoadDataGrid();
            }
        }

        private void DeleteTasks()
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("GÖREVİ SİLMEK İSTEDİĞİNİZDEN EMİNMİSİNİZ?", "GÖREV SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                string sqlSorgum = "DELETE FROM tasks WHERE task_id = @p1";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                npgsqlCommand.ExecuteNonQuery();
                MessageBox.Show("SİLME İŞLEMİ TAMAMLANDI", "GÖREV SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                TextBoxClear();
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("SİLME İŞLEMİ İPTAL EDİLDİ", "GÖREV SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TextBoxClear()
        {
            tb_gorevAd.Text = string.Empty;
            tb_acıklama.Text = string.Empty;
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {

            LoadCombobox();
            LoadDataGrid();
        }

        private void btn_gorevEkle_Click(object sender, EventArgs e)
        {
            AddTasks();
            LoadDataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void btn_görevTamam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                connection.Open();
                int taskid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string sqlSorgum = "UPDATE tasks SET task_complated = TRUE WHERE task_id = @p1";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", taskid);
                npgsqlCommand.ExecuteNonQuery();
                connection.Close();
                LoadDataGrid();
                var sortColumn = dataGridView1.SortedColumn;
                var sortOrder = dataGridView1.SortOrder;
                if (sortColumn != null)
                {
                    dataGridView1.Sort(sortColumn, sortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending);
                }

            }
            else
            {
                MessageBox.Show("GÖREV SEÇMEDEN BU İŞLEMİ YAPAMAZSINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_gorevBitmedi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                connection.Open();
                int taskid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string sqlSorgum = "UPDATE tasks SET task_complated = FALSE WHERE task_id = @p1";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sqlSorgum, connection);
                npgsqlCommand.Parameters.AddWithValue("@p1", taskid);
                npgsqlCommand.ExecuteNonQuery();
                connection.Close();
                LoadDataGrid();
                var sortColumn = dataGridView1.SortedColumn;
                var sortOrder = dataGridView1.SortOrder;
                if (sortColumn != null)
                {
                    dataGridView1.Sort(sortColumn, sortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending);
                }

            }
            else
            {
                MessageBox.Show("GÖREV SEÇMEDEN BU İŞLEMİ YAPAMAZSINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return; // Sütun başlıklarına tıklandığında hiçbir işlem yapma
            }
            tb_gorevAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            cb_priorty.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_acıklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_gorevDuzenle_Click(object sender, EventArgs e)
        {
            EditTasks();
        }

        private void btn_gorevSil_Click(object sender, EventArgs e)
        {
            DeleteTasks();
        }

        private void btn_cıkısYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
