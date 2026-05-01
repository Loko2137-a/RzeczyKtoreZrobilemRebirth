using Accessibility;
using egzaminsprawdzianedesktop.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace egzaminsprawdzianedesktop
{
    public partial class Form1 : Form
    {
        private string[] dane = File.ReadAllLines(Path.Combine(Application.StartupPath, "Data.txt"));
        private int i = 0;
        private string wykonawca, tytul;
        private int iloscUtworow, rokWydania, iloscPobran;
        public Form1()
        {
            InitializeComponent();
            PobierzDane();
            Aktualizuj();

        }
        private void Aktualizuj()
        {
            labelWykonawca.Text = wykonawca;
            labelTytul.Text = tytul;
            labelIlosc.Text = "Ilosc utworow: " + iloscUtworow.ToString();
            labelrokWydania.Text = rokWydania.ToString();
            labelPobrania.Text = iloscPobran.ToString();
        }
        private void PobierzDane()
        {
            wykonawca = dane[i];
            tytul = dane[i + 1];
            iloscUtworow = int.Parse(dane[i + 2]);
            rokWydania = int.Parse(dane[i + 3]);
            iloscPobran = int.Parse(dane[i + 4]);
        }
        private void przyciskprzod_Click(object sender, EventArgs e)
        {
            i += 5;
            if (i >= dane.Length)
            {
                i = 0;
            }
            PobierzDane();;
            Aktualizuj();
        }

        private void przycisktyl_Click(object sender, EventArgs e)
        {
            i -= 5;
            if (i < 0)
            {
                i = dane.Length - 5;
            }
            PobierzDane();
            Aktualizuj();
        }

        private void przyciskPobierz_Click(object sender, EventArgs e)
        {
            iloscPobran++;
            labelPobrania.Text = iloscPobran.ToString();
            Aktualizuj();
        }
    }
}
