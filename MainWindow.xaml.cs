using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Password_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PasswordGeneratorVM passwordVM;
        public MainWindow()
        {
            InitializeComponent();
            this.passwordVM = new PasswordGeneratorVM(this);
            passwordVM.PropertyChanged += OnPropertyChanged;
            DataContext = this.passwordVM;
        }

        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

        }

        private void generatePassword_Click(object sender, RoutedEventArgs e)
        {
            int length = Convert.ToInt32(Math.Pow(2, 3 + this.passwordLength.SelectedIndex));
            bool allowUpperCase = this.allowUpperCase.IsChecked.Value;
            bool allowNumbers = this.allowNumbers.IsChecked.Value;
            bool allowSymbols = this.allowSymbols.IsChecked.Value;
            this.passwordVM.GeneratePasswordClicked(length, allowUpperCase, allowNumbers, allowSymbols);
        }
    }
}
