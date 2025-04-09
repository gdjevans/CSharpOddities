namespace CurrencyConverter
{
    public partial class currencyConvert : Form
    {
        public currencyConvert()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Navigate("https://www.xe.com/en-gb/currencyconverter/");
        }
    }
}
