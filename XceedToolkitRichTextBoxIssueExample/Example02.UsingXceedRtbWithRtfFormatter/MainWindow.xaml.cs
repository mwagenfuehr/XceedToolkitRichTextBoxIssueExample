using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace Example02.UsingXceedRtbWithRtfFormatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonGetRtf_Click(object sender, RoutedEventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                var txtRange = new TextRange(RichTextBox.Document.ContentStart,
                    RichTextBox.Document.ContentEnd);

                txtRange.Save(ms, DataFormats.Rtf);
                ms.Seek(0, SeekOrigin.Begin);

                using (var sr = new StreamReader(ms))
                {
                    MessageBox.Show(sr.ReadToEnd());
                }
            }
        }
    }
}
