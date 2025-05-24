namespace Birinci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bKapat_Click(object sender,EventArgs e)
        {
            this.Close();
        }
        private void bSelamla_Click(object sender, EventArgs e)
        {
            if (tbAd.Text == "")
                tbAd.Text = "Alper";
            MessageBox.Show("Merhaba," + tbAd.Text + "!");
        }

        private void bSelamla_MouseHover(object sender, EventArgs e)
        {
            bSelamla.Left -= 10;
            bSelamla.Width += 20;
        }

        private void bSelamla_MouseLeave(object sender, EventArgs e)
        {
            bSelamla.Left -= 10;
            bSelamla.Width += 20;
        }
    }
}
