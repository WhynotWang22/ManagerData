using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ManagerData
{
    public partial class DataScreen : Form
    {
        public DataScreen()
        {
            InitializeComponent();
            this.Load += DataScreen_Load;
        }

        SqlConnection dataConnect = new SqlConnection(
            @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\Users\quang\Documents\IGShop.mdf;Integrated Security=True;TrustServerCertificate=True;"
        );

        private void DataScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using var conn = new SqlConnection(dataConnect.ConnectionString);
                conn.Open();

                string query = "SELECT * FROM MachineData";
                using var adapter = new SqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);

                listd_data.DataSource = table;
                listd_data.Columns["DataID"].HeaderText = "STT";
                listd_data.Columns["DeviceID"].HeaderText = "Mã thiết bị";
                listd_data.Columns["Temperature"].HeaderText = "Nhiệt độ (°C)";
                listd_data.Columns["Pressure"].HeaderText = "Áp suất (bar)";
                listd_data.Columns["OutputRate"].HeaderText = "Năng suất";
                listd_data.Columns["ErrorCount"].HeaderText = "Số lỗi";
                listd_data.Columns["Status"].HeaderText = "Trạng thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void listd_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = listd_data.Rows[e.RowIndex];
            txt_deviceID.Text = row.Cells[1].Value?.ToString();
            txt_temperature.Text = row.Cells[2].Value?.ToString();
            txt_pressure.Text = row.Cells[3].Value?.ToString();
            txt_outputrate.Text = row.Cells[4].Value?.ToString();
            txt_errorcount.Text = row.Cells[5].Value?.ToString();
            txt_status.Text = row.Cells[6].Value?.ToString();
        }


        private void btn_insert_Click_1(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(dataConnect.ConnectionString);
                conn.Open();

                string query = @"INSERT INTO MachineData 
                                (DeviceID, Temperature, Pressure, OutputRate, ErrorCount, Status)
                                VALUES 
                                (@DeviceID, @Temperature, @Pressure, @OutputRate, @ErrorCount, @Status)";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeviceID", int.Parse(txt_deviceID.Text));
                cmd.Parameters.AddWithValue("@Temperature", float.Parse(txt_temperature.Text));
                cmd.Parameters.AddWithValue("@Pressure", float.Parse(txt_pressure.Text));
                cmd.Parameters.AddWithValue("@OutputRate", int.Parse(txt_outputrate.Text));
                cmd.Parameters.AddWithValue("@ErrorCount", int.Parse(txt_errorcount.Text));
                cmd.Parameters.AddWithValue("@Status", txt_status.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(dataConnect.ConnectionString);
                conn.Open();

                string query = @"UPDATE MachineData SET
                                Temperature = @Temperature,
                                Pressure    = @Pressure,
                                OutputRate  = @OutputRate,
                                ErrorCount  = @ErrorCount,
                                Status      = @Status
                                WHERE DeviceID = @DeviceID";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeviceID", int.Parse(txt_deviceID.Text));
                cmd.Parameters.AddWithValue("@Temperature", float.Parse(txt_temperature.Text));
                cmd.Parameters.AddWithValue("@Pressure", float.Parse(txt_pressure.Text));
                cmd.Parameters.AddWithValue("@OutputRate", int.Parse(txt_outputrate.Text));
                cmd.Parameters.AddWithValue("@ErrorCount", int.Parse(txt_errorcount.Text));
                cmd.Parameters.AddWithValue("@Status", txt_status.Text);

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Sửa thành công!" : "Không tìm thấy DeviceID!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_deviceID.Text))
            {
                MessageBox.Show("Chọn thiết bị cần xóa!");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new SqlConnection(dataConnect.ConnectionString);
                conn.Open();

                string query = "DELETE FROM MachineData WHERE DeviceID = @DeviceID";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeviceID", int.Parse(txt_deviceID.Text));

                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Không tìm thấy!");
                ClearFields();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btn_clear_data_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txt_deviceID.Clear();
            txt_temperature.Clear();
            txt_pressure.Clear();
            txt_outputrate.Clear();
            txt_errorcount.Clear();
            txt_status.Clear();
            txt_deviceID.Focus();
        }


        private void LB_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listd_data_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            listd_data.CellClick += listd_data_CellClick;
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            ChartScreen chartScreen = new ChartScreen();
            chartScreen.Show();
            this.Hide();
        }
    }
}