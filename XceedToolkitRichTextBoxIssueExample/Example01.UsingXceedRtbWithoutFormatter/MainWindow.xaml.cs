using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example01.UsingXceedRtbWithoutFormatter
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
