using System.Windows;
using Xceed.Wpf.Toolkit;

namespace Example04.UsingXceedRtbWithXamlFormatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RichTextBox.TextFormatter = new XamlFormatter();
        }
    }
}
