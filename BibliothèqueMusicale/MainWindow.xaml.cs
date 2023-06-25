using System;
using System.Collections.Generic;
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

namespace BibliothèqueMusicale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _mv;

        public MainWindow()
        {
            InitializeComponent();
            MainViewModel _mv = new MainViewModel();
            this.DataContext = _mv;

        }

        //private void ClickHandler(object sender, MouseButtonEventArgs e)
        //{
        //    if (DataContext is MainViewModel m && _lb.SelectedItem is AlbumViewModel elt)
        //    {
        //        m.DoubleClick(elt);
        //    }

        //}

        private void SelectAlbum(object sender, SelectionChangedEventArgs args)
        {
            if (DataContext is MainViewModel m && _lb.SelectedItem is AlbumViewModel elt)
            {
                m.DoubleClick(elt);
            }

        }

        private void Button_MouseDown(object sender, RoutedEventArgs e)
        {
            RightPanelOnly rightPanelOnly = new RightPanelOnly();
            rightPanelOnly.DataContext = this.DataContext;
            rightPanelOnly.Show();
        }
    }
}
