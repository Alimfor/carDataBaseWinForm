using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable GetData(int id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand($"getAllCar {id}", connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    return dt;
                }
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            dgv.DataSource = GetData(-1);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show("Вы не ввели данные или машина младше 1900 года", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    $"insertCar '{makeCB.Text}','{modelCB.Text}','{colorCB.Text}','{cityCB.Text}'," +
                    $"{mileageNUD.Value},{yearNUD.Value},{volumeNUD.Value},{priceNUD.Value}", connection)
                    )
                {
                    var result = command.ExecuteScalar();

                    MessageBox.Show(result.ToString() == "1" ? "Saccessful" : "This data is already exists");
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (IsEmptyId())
            {
                MessageBox.Show("Вы не ввели id", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            dgv.DataSource = GetData((int)idNUD.Value);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (IsEmptyId())
            {
                MessageBox.Show("Вы не ввели id", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Удалить выделенную машину?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (confirm != DialogResult.OK)
            {
                MessageBox.Show("Отменено пользователем", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    $"PstudentDel {idNUD.Value}", connection)
                    )
                {
                    var result = command.ExecuteScalar();
                    MessageBox.Show(result.ToString() == "1" ? "Saccessful" : "This data is not exists");
                }
            }
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show("Вы не ввели данные или машина младше 1900 года", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    $"updateCar {idNUD.Value},'{makeCB.Text}','{modelCB.Text}','{colorCB.Text}','{cityCB.Text}'," +
                    $"{mileageNUD.Value},{yearNUD.Value},{volumeNUD.Value},{priceNUD.Value}", connection)
                    )
                {
                    var result = command.ExecuteScalar();
                    MessageBox.Show(result.ToString() == "1" ? "Saccessful" : "This data is not exists");
                }
            }
            dgv.DataSource = GetData(-1);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            mileageNUD.Value =
            yearNUD.Value =
            volumeNUD.Value =
            priceNUD.Value =
            idNUD.Value = 0;

            makeCB.Text = "Марка";
            modelCB.Text = "Модель";
            colorCB.Text = "Цвет";
            cityCB.Text = "Город";
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Проверка, что строка была выбрана (исключает клики на заголовке столбца)
            {
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                idNUD.Value = Convert.ToInt32(selectedRow.Cells["id"].Value);
                makeCB.Text = selectedRow.Cells["stamp"].Value?.ToString();
                modelCB.Text = selectedRow.Cells["model"].Value?.ToString();
                colorCB.Text = selectedRow.Cells["color"].Value?.ToString();
                cityCB.Text = selectedRow.Cells["city"].Value?.ToString();
                mileageNUD.Value = Convert.ToInt32(selectedRow.Cells["mileage"].Value);
                yearNUD.Value = Convert.ToInt32(selectedRow.Cells["year"].Value);
                volumeNUD.Value = Convert.ToInt32(selectedRow.Cells["volume"].Value);
                priceNUD.Value = Convert.ToInt32(selectedRow.Cells["price"].Value);
            }
        }
        private bool IsEmptyField()
        {
            return makeCB.Text == "Марка" ||
                modelCB.Text == "Модель" ||
                colorCB.Text == "Цвет" ||
                cityCB.Text == "Город" ||
                mileageNUD.Value == 0 ||
                volumeNUD.Value == 0 ||
                priceNUD.Value == 0 ||
                yearNUD.Value < 1900;
        }

        private bool IsEmptyId()
        {
            return idNUD.Value == 0 ||
                idNUD.Value == null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand($"carReport_getCarById {idNUD.Value}", connection))
                {
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine("id;stamp;model;color;city;mileage;year;volume;price");
                    foreach (DataRow item in dt.Rows)
                    {
                        stringBuilder.AppendLine(
                            item[0].ToString() + ";" +
                            item[1].ToString() + ";" +
                            item[2].ToString() + ";" +
                            item[3].ToString() + ";" +
                            item[4].ToString() + ";" +
                            item[5].ToString() + ";" +
                            item[6].ToString() + ";" +
                            item[7].ToString() + ";" +
                            item[8].ToString() + ";"
                            );
                    }
                    System.IO.File.WriteAllText(DateTime.Now.ToString("yyyy-MM-dd") + ".csv", stringBuilder.ToString());
                }
            }
        }

        private void makeCB_Click(object sender, EventArgs e)
        {
            fillComboBox("stamp", makeCB);
        }
        private void modelCB_Click(object sender, EventArgs e)
        {
            fillComboBox("model", modelCB);
        }
        private void colorCB_Click(object sender, EventArgs e)
        {
            fillComboBox("color", colorCB);
        }
        private void cityCB_Click(object sender, EventArgs e)
        {
            fillComboBox("city", cityCB);
        }

        private void fillComboBox(string column, ComboBox comboBox)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    $"SELECT {column} FROM car", connection)
                    )
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox.Items.Clear();

                        while (reader.Read())
                        {
                            string item = reader.GetString(0);
                            comboBox.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
