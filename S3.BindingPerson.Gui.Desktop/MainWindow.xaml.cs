using S3.BindingPerson.DataAcess;
using S3.BindingPerson.Entities;
using S3.BindingPerson.Gui.Desktop.ViewModels;
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

namespace S3.BindingPerson.Gui.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PersonsViewModel personViewModel;
        public MainWindow()
        {
            InitializeComponent();
            personViewModel = new PersonsViewModel();
            DataContext = personViewModel;
        }

        private void PersonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            personViewModel.SelectedPerson = PersonList.SelectedItem as Person;
        }
    }
}
