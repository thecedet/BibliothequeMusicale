﻿using System;
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
    /// Logique d'interaction pour RightPanel.xaml
    /// </summary>
    public partial class RightPanel : UserControl
    {
        public RightPanel()
        {
            InitializeComponent();
        }

        private void SelectPiste(object sender, SelectionChangedEventArgs args)
        {
            if (DataContext is MainViewModel m && _pisteLb.SelectedItem is Piste elt)
            {
                m.DoubleClickPiste(elt);
            }

        }
    }
}
