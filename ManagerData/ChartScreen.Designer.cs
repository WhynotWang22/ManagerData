namespace ManagerData
{
    partial class ChartScreen
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
            flowPanel = new FlowLayoutPanel();
            close_chartScreen = new Label();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Controls.Add(close_chartScreen);
            flowPanel.Dock = DockStyle.Fill;
            flowPanel.Location = new Point(0, 0);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(897, 509);
            flowPanel.TabIndex = 0;
            // 
            // close_chartScreen
            // 
            close_chartScreen.AutoSize = true;
            close_chartScreen.BackColor = Color.Transparent;
            close_chartScreen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_chartScreen.Location = new Point(3, 0);
            close_chartScreen.Name = "close_chartScreen";
            close_chartScreen.Size = new Size(27, 25);
            close_chartScreen.TabIndex = 0;
            close_chartScreen.Text = "X";
            close_chartScreen.Click += close_chartScreen_Click;
            // 
            // ChartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(897, 509);
            Controls.Add(flowPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChartScreen";
            flowPanel.ResumeLayout(false);
            flowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Label close_chartScreen;
    }
}