using System.Windows;
using System.IO;
using System.Text; // Input/Output

namespace Patientenkartei
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Großschreibung zeigt an das es eine Konsatnte ist
        // Statische Konstante, kann in Laufzeit nicht verändert werden
        // Konstante definiert im öffentlichen Scope der Klasse
        public const string DIR_PATH = @"C:\Users\SWE\Desktop\test\";
        // Test folder is not build automatically
        public const string FILE_EXT = ".txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        // Doppelklick auf den Button, erstellt Event Handler
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string content = textBoxContent.Text;
            string filename = textBoxFileName.Text;

            using (FileStream fs = File.Create(DIR_PATH + filename + FILE_EXT))
            {

                byte[] contentConvertedToBytes = Encoding.ASCII.GetBytes(content);
                fs.Write(contentConvertedToBytes, 0, contentConvertedToBytes.Length);   

            }

            MessageBox.Show("Datei wurde angelegt.");
        }


        // #######################################################


        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            string filename = textBoxFileName.Text;

            using (FileStream fs = File.OpenRead(DIR_PATH + filename + FILE_EXT))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    textBoxContent.Text = content;
                }
            }
        }


        // #######################################################


    }
}
