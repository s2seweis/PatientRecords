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
        public MainWindow()
        {
            InitializeComponent();
        }

        // Doppelklick auf den Button, erstellt Event Handler
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string content = textBoxContent.Text;
            string filename = textBoxFileName.Text;
            string dirPath = @"Users\SWE\Desktop\test\";

            using (FileStream fs = File.Create(filename + ".txt"))
            {

                byte[] contentConvertedToBytes = Encoding.ASCII.GetBytes(content);
                fs.Write(contentConvertedToBytes, 0, contentConvertedToBytes.Length);   

            }

            MessageBox.Show("Date wurde angelegt.");
        }
    }
}
