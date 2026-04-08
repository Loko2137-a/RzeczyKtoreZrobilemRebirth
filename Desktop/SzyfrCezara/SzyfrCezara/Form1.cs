using System.Windows.Forms.VisualStyles;
using System.IO;
namespace SzyfrCezara
{
    public partial class Form1 : Form
    {
        private int przesuniecie;
        private String tekstDoZaszyfrowania, tekstPoZaszyfrowaniu = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZaszyfruj_Click(object sender, EventArgs e)
        {
            tekstPoZaszyfrowaniu = "";
            try
            {
                przesuniecie = int.Parse(polePrzesuniecie.Text);
                tekstDoZaszyfrowania = polePrzedSzyfrem.Text;
            }
            catch
            {
                MessageBox.Show("Prosze wypełnić wszystkie pola!");
                return;
            }
            foreach (char Litera in tekstDoZaszyfrowania)
            {
                if (char.IsLetter(Litera))
                {
                    char przesunietaLitera = Litera;

                    if (char.IsUpper(Litera))
                    {
                        przesunietaLitera = (char)((((Litera - 'A') + przesuniecie) % 26) + 'A');
                    }
                    else
                    {
                        przesunietaLitera = (char)((((Litera - 'a') + przesuniecie) % 26) + 'a');
                    }
                    tekstPoZaszyfrowaniu += przesunietaLitera;
                }
                else
                {
                    tekstPoZaszyfrowaniu += Litera;
                }
            }
            poleZaszyfrowane.Text = tekstPoZaszyfrowaniu;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            String plik = "Szyfr.txt";
            using (StreamWriter sw = File.AppendText(plik))
            {
                sw.WriteLine(tekstPoZaszyfrowaniu);
            }
            MessageBox.Show("Zapisano do pliku!");
        }
    }
}
