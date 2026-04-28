using ManagerData.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagerData.Card
{
    public partial class ProductCart : UserControl
    {
        public ProductCart()
        {
            InitializeComponent();
        }
        private static readonly HttpClient httpClient = new HttpClient();

        public void SetData(ProductModel product)
        {
            txt_description_img.Text = product.description;
            txt_description_img.ForeColor = Color.White;
             //txt_description_img.ForeColor = Color.FromArgb(77, 184, 232);

            //img_data.BackColor = Color.FromArgb(30, 40, 60);
            LoadImage(product.anh);
        }
        private async void LoadImage(string url)
        {
            try
            {
                byte[] data = await httpClient.GetByteArrayAsync(url);
                using var ms = new MemoryStream(data);
                img_data.Image = Image.FromStream(ms);
            }
            catch
            {
                img_data.BackColor = Color.FromArgb(40, 50, 70);
            }
        }
    }
}
