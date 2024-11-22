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

namespace Test;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        #if DEBUG
        Resources.MergedDictionaries.Add( new ResourceDictionary{ Source = new Uri("/Fusion;component/Themes/Cloud.xaml", UriKind.Relative) });
        #endif
    }
}