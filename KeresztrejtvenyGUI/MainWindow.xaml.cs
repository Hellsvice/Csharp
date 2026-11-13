using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeresztrejtvenyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int letrehozottOszlopokSzama;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 6; i <= 15; i++)
            {
                sorSzamComboxBox.Items.Add(i);
                oszlopSzamComboxBox.Items.Add(i);
            }
            sorSzamComboxBox.SelectedItem = 15;
            oszlopSzamComboxBox.SelectedItem = 15;

            for (int i = 1; i <= 10; i++)
            {
                mentesIndexComboBox.Items.Add(i);
            }
            mentesIndexComboBox.SelectedItem = 3;
        }

        private void letrehozButton_Click(object sender, RoutedEventArgs e)
        {
            // Régi TextBox törlése
            // Ha van a Canvasnak gyerekeleme
            if (KeresztrejtvenyCanvas.Children.Count > 0)
            {
                // Bejárjuk a gyerekelemeket
                for (int i = 0; i < KeresztrejtvenyCanvas.Children.Count;)
                {
                    // Ha az aktuális gyerekelem TextBox -> EBBEN AZ ESETBEN NEM NÖVELJÜK AZ i-T
                    if (KeresztrejtvenyCanvas.Children[i] is TextBox)
                    {
                        KeresztrejtvenyCanvas.Children.Remove(KeresztrejtvenyCanvas.Children[i] as TextBox);
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            // Új TextBox-ok létrehozása
            int sorokSzama = int.Parse(sorSzamComboxBox.SelectedItem.ToString());
            int oszlopokSzama = (int)oszlopSzamComboxBox.SelectedItem;
            letrehozottOszlopokSzama = oszlopokSzama;

            for (int rowIdx = 0; rowIdx < sorokSzama; rowIdx++)
            {
                for (int columnIdx = 0; columnIdx < oszlopokSzama; columnIdx++)
                {
                    TextBox aktualisTextBox = new TextBox();
                    aktualisTextBox.Width = 25;

                    // MAXIMUM EGY KARAKTER íRHATÓ BE
                    aktualisTextBox.MaxLength = 1;

                    aktualisTextBox.Text = "-";
                    aktualisTextBox.TextAlignment = TextAlignment.Center;

                    // Feliratkozunk a dupla kattintás eseményre
                    aktualisTextBox.MouseDoubleClick += AktualisTextBox_MouseDoubleClick;

                    aktualisTextBox.Margin = new Thickness(30 + columnIdx * 25, 190 + rowIdx * 20, 0, 0);
                    KeresztrejtvenyCanvas.Children.Add(aktualisTextBox);
                }
            }
        }

        private void AktualisTextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox aktualisTextBox = (TextBox)sender;
                if (aktualisTextBox.Text == "-")
                {
                    aktualisTextBox.Text = "#";
                }
                else
                {
                    aktualisTextBox.Text = "-";
                }
            }
            else
            {
                MessageBox.Show("Hiba történt. Nem TextBox ra történt a dupla kattintás -> BAJ VAN AZ ESEMÉNYKLEZELÉSSEL");
            }

        }

        private void mentesButton_Click(object sender, RoutedEventArgs e)
        {
            if (letrehozottOszlopokSzama == 0)
            {
                MessageBox.Show("Előbb hozz létre egy keresztrejtvényt.");
                return;
            }

            List<string> kiirandoSorok = new List<string>();
            int oszlopIndex = 0;
           
            int oszlopokSzama = letrehozottOszlopokSzama;
            int allomanyIndex = int.Parse(mentesIndexComboBox.SelectedItem.ToString());

            string aktualisSor = "";

            foreach (var item in KeresztrejtvenyCanvas.Children)
            {
                if (item is TextBox)
                {
                    TextBox aktTextBox = (TextBox)item;
                    aktualisSor += string.IsNullOrEmpty(aktTextBox.Text) ? "-" : aktTextBox.Text;
                    oszlopIndex++;
                }

                // Ha a sor végére értünk (vagyis az utolsó oszlopnál vagyunk) -> Új sort kell kezdeni
                if (oszlopIndex == oszlopokSzama)
                {
                    oszlopIndex = 0;
                    kiirandoSorok.Add(aktualisSor);
                    aktualisSor = "";
                }
            }

            try
            {
                string path = $"kr{allomanyIndex}.txt";
                File.WriteAllLines(path, kiirandoSorok);
                MessageBox.Show("A keresztrejtvény mentése sikeres!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}