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

namespace TD05
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Directory a = new Directory();

        public MainWindow()
        {
            InitializeComponent();
            a.Add(new Person() { LastName = "Dickinson", FirstName = "Bruce", Gender = Gender.MALE });
            a.Add(new Person() { LastName = "Jansen", FirstName = "Floor", Gender = Gender.FEMALE });
            PrintList();
        }

        private void PrintList()
        {
            contacts.Items.Clear();
            foreach(Person p in a.ListAll())
            {
                PersonHMI pHMI = new PersonHMI(p);
                contacts.Items.Add(pHMI);
            }
        }
        private void ImageLighter(object sender, MouseEventArgs e)
        {
            if(sender is Image img)
            {
                img.Opacity = 0.7;
            }
        }

        private void ImageNormal(object sender, MouseEventArgs e)
        {
            if (sender is Image img)
            {
                img.Opacity = 1;
            }
        }

        private void Add(object sender, MouseButtonEventArgs e)
        {
            // ajoute une personne
            Person p = new Person();
            PersonWindow dialog = new PersonWindow(p);
            if(dialog.ShowDialog()==true)
            {
                a.Add(p);
                PrintList();
            }
        }

        private void Remove(object sender, MouseButtonEventArgs e)
        {
            // retire une personne
            if(contacts.SelectedItem is PersonHMI p)
            {
                a.Remove(p.P);
                PrintList();
            }
        }

        private void Edit(object sender, MouseButtonEventArgs e)
        {
            // modifie la personne
            if(contacts.SelectedItem is PersonHMI p)
            {
                Person temp = p.P.Clone() as Person;
                PersonWindow dialog = new PersonWindow(temp);
                if(dialog.ShowDialog()==true)
                {
                    p.Copy(temp);
                    PrintList();
                }
            }
        }

    }
}
