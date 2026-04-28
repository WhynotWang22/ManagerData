namespace ManagerData.Card
{
    partial class ProductCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            img_data = new PictureBox();
            txt_description_img = new Label();
            ((System.ComponentModel.ISupportInitialize)img_data).BeginInit();
            SuspendLayout();
            // 
            // img_data
            // 
            img_data.Location = new Point(35, 31);
            img_data.Name = "img_data";
            img_data.Size = new Size(181, 150);
            img_data.SizeMode = PictureBoxSizeMode.Zoom;
            img_data.TabIndex = 0;
            img_data.TabStop = false;
            // 
            // txt_description_img
            // 
            txt_description_img.AutoSize = true;
            txt_description_img.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_description_img.Location = new Point(35, 203);
            txt_description_img.Name = "txt_description_img";
            txt_description_img.Size = new Size(44, 23);
            txt_description_img.TabIndex = 1;
            txt_description_img.Text = "Anh";
            // 
            // ProductCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_description_img);
            Controls.Add(img_data);
            Name = "ProductCart";
            Size = new Size(267, 254);
            ((System.ComponentModel.ISupportInitialize)img_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_data;
        private Label txt_description_img;
    }
}
