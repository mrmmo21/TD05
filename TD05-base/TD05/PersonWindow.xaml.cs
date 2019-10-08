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
using System.Windows.Shapes;

namespace TD05
{
    /// <summary>
    /// Logique d'interaction pour EditePersonne.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow(Person p)
        {
            InitializeComponent();
            DataContext = new PersonHMI(p);
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
