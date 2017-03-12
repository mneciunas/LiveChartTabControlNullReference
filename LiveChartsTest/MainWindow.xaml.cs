using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace LiveChartsTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TabItem> Tabs { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Tabs = new ObservableCollection<TabItem>
            {
                new TabItem(new UserControl(), "Empty"),
                new TabItem(new ChartsView(), "Charts"),
                new TabItem(new UserControl(), "Empty"),
            };

            DataContext = this;
        }

        public class TabItem
        {
            public TabItem(ContentControl content, string header)
            {
                Content = content;
                Header = header;
            }

            public string Header { get; set; }
            public ContentControl Content { get; set; }
        }
    }
}
