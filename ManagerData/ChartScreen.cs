using ManagerData.Card;
using ManagerData.model;
using Newtonsoft.Json;

namespace ManagerData
{
    public partial class ChartScreen : Form
    {
        public ChartScreen()
        {
            InitializeComponent();
            LoadProducts();

        }
        private static readonly HttpClient httpClient = new HttpClient();

        private async Task LoadProducts()
        {
            try
            {
                string url = "https://whynotwang22.github.io/ApiTest/APiBanner.json";
                string json = await httpClient.GetStringAsync(url);
                var products = JsonConvert.DeserializeObject<List<ProductModel>>(json);

                flowPanel.Controls.Clear();

                foreach (var product in products)
                {
                    ProductCart card = new ProductCart();
                    card.SetData(product);
                    //card.Margin = new Padding(-100);
                    flowPanel.Controls.Add(card);
                    flowPanel.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void close_chartScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
