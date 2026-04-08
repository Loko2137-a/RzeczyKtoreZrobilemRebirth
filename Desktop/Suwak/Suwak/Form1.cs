namespace Suwak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZmienKolor();
        }
        private void ZmienKolor()
        {
            int r = SuawkR.Value;
            int g = SuwakG.Value;
            int b = SuwakB.Value;
            Paleta.BackColor = Color.FromArgb(r, g, b);
            labelR.Text = r.ToString();
            labelG.Text = g.ToString();
            labelB.Text = b.ToString();
            LabelWartosci.Text = $"RGB({r}, {g}, {b})";
        }

        private void SuawkR_Scroll(object sender, EventArgs e)
        {
            ZmienKolor();
        }

        private void SuwakG_Scroll(object sender, EventArgs e)
        {
            ZmienKolor();
        }

        private void SuwakB_Scroll(object sender, EventArgs e)
        {
            ZmienKolor();
        }
    }
}
