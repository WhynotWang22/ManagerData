namespace ManagerData
{
    partial class DataScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataScreen));
            label1 = new Label();
            LB_Close = new Label();
            txt_deviceID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_temperature = new TextBox();
            txt_preas = new Label();
            txt_pressure = new TextBox();
            a = new Label();
            txt_outputrate = new TextBox();
            ab = new Label();
            txt_errorcount = new TextBox();
            ah = new Label();
            txt_status = new TextBox();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_clear_data = new Button();
            listd_data = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)listd_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            label1.Location = new Point(1484, 8);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // LB_Close
            // 
            LB_Close.AutoSize = true;
            LB_Close.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            LB_Close.Location = new Point(1236, 9);
            LB_Close.Name = "LB_Close";
            LB_Close.Size = new Size(36, 35);
            LB_Close.TabIndex = 1;
            LB_Close.Text = "X";
            LB_Close.Click += LB_Close_Click;
            // 
            // txt_deviceID
            // 
            txt_deviceID.Location = new Point(201, 81);
            txt_deviceID.Name = "txt_deviceID";
            txt_deviceID.Size = new Size(125, 25);
            txt_deviceID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 49);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 3;
            label2.Text = "Device ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 49);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 5;
            label3.Text = "Temperatura";
            // 
            // txt_temperature
            // 
            txt_temperature.Location = new Point(353, 81);
            txt_temperature.Name = "txt_temperature";
            txt_temperature.Size = new Size(125, 25);
            txt_temperature.TabIndex = 4;
            // 
            // txt_preas
            // 
            txt_preas.AutoSize = true;
            txt_preas.Location = new Point(504, 49);
            txt_preas.Name = "txt_preas";
            txt_preas.Size = new Size(67, 17);
            txt_preas.TabIndex = 7;
            txt_preas.Text = "Pressure";
            // 
            // txt_pressure
            // 
            txt_pressure.Location = new Point(504, 81);
            txt_pressure.Name = "txt_pressure";
            txt_pressure.Size = new Size(125, 25);
            txt_pressure.TabIndex = 6;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(656, 49);
            a.Name = "a";
            a.Size = new Size(85, 17);
            a.TabIndex = 9;
            a.Text = "OutputRate";
            // 
            // txt_outputrate
            // 
            txt_outputrate.Location = new Point(656, 81);
            txt_outputrate.Name = "txt_outputrate";
            txt_outputrate.Size = new Size(125, 25);
            txt_outputrate.TabIndex = 8;
            // 
            // ab
            // 
            ab.AutoSize = true;
            ab.Location = new Point(809, 49);
            ab.Name = "ab";
            ab.Size = new Size(84, 17);
            ab.TabIndex = 11;
            ab.Text = "ErrorCount";
            // 
            // txt_errorcount
            // 
            txt_errorcount.Location = new Point(809, 81);
            txt_errorcount.Name = "txt_errorcount";
            txt_errorcount.Size = new Size(125, 25);
            txt_errorcount.TabIndex = 10;
            // 
            // ah
            // 
            ah.AutoSize = true;
            ah.Location = new Point(974, 49);
            ah.Name = "ah";
            ah.Size = new Size(48, 17);
            ah.TabIndex = 13;
            ah.Text = "Status";
            // 
            // txt_status
            // 
            txt_status.Location = new Point(974, 81);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(125, 25);
            txt_status.TabIndex = 12;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(401, 188);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(94, 29);
            btn_insert.TabIndex = 16;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click_1;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(532, 188);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click_1;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(684, 188);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // btn_clear_data
            // 
            btn_clear_data.Location = new Point(826, 188);
            btn_clear_data.Name = "btn_clear_data";
            btn_clear_data.Size = new Size(94, 29);
            btn_clear_data.TabIndex = 19;
            btn_clear_data.Text = "Clear";
            btn_clear_data.UseVisualStyleBackColor = true;
            btn_clear_data.Click += btn_clear_data_Click;
            // 
            // listd_data
            // 
            listd_data.BackgroundColor = Color.White;
            listd_data.BorderStyle = BorderStyle.None;
            listd_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listd_data.Location = new Point(201, 266);
            listd_data.Name = "listd_data";
            listd_data.RowHeadersWidth = 51;
            listd_data.Size = new Size(898, 188);
            listd_data.TabIndex = 20;
            listd_data.CellClick += listd_data_CellClick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 300);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 22;
            label4.Text = "DataScreen";
            label4.DoubleClick += label4_DoubleClick;
            // 
            // DataScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 539);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(listd_data);
            Controls.Add(btn_clear_data);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_insert);
            Controls.Add(ah);
            Controls.Add(txt_status);
            Controls.Add(ab);
            Controls.Add(txt_errorcount);
            Controls.Add(a);
            Controls.Add(txt_outputrate);
            Controls.Add(txt_preas);
            Controls.Add(txt_pressure);
            Controls.Add(label3);
            Controls.Add(txt_temperature);
            Controls.Add(label2);
            Controls.Add(txt_deviceID);
            Controls.Add(LB_Close);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataScreen";
            ((System.ComponentModel.ISupportInitialize)listd_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LB_Close;
        private TextBox txt_deviceID;
        private Label label2;
        private Label label3;
        private TextBox txt_temperature;
        private Label txt_preas;
        private TextBox txt_pressure;
        private Label a;
        private TextBox txt_outputrate;
        private Label ab;
        private TextBox txt_errorcount;
        private Label ah;
        private TextBox txt_status;
        private Button btn_insert;
        private Label label8;
        private TextBox textBox7;
        private Button button1;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_clear_data;
        private DataGridView listd_data;
        private PictureBox pictureBox1;
        private Label label4;
    }
}