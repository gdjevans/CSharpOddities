namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webView21.CoreWebView2.Navigate(toolStripComboBox1.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(toolStripComboBox1.Text);
            }
        }
    }
}
