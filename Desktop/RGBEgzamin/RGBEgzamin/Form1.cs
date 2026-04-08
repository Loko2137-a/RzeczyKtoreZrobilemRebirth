namespace RGBEgzamin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ZmianaKoloru();
        }
        private void ZmianaKoloru()
        {
            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;
            panel1.BackColor = Color.FromArgb(r, g, b);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ZmianaKoloru();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ZmianaKoloru();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ZmianaKoloru();
        }

        private void ButtonPobierz_Click(object sender, EventArgs e)
        {
            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;
            label2.BackColor = Color.FromArgb(r, g, b);
            label2.Text = $"{r}, {g}, {b}";
        }
    }
}
