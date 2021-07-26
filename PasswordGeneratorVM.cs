using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class PasswordGeneratorVM : INotifyPropertyChanged
    {
        private string userPassword;

        private string generatedPassword;

        public event PropertyChangedEventHandler PropertyChanged;

        private MainWindow mainView;
        private PasswordGeneratorModel model;

        public PasswordGeneratorVM(MainWindow mainWindow)
        {
            this.mainView = mainWindow;
            this.model = new PasswordGeneratorModel();
            this.model.PropertyChanged += OnPropertyChanged;
        }

        public void GeneratePasswordClicked(int length, bool allowUpperCase, bool allowNumbers, bool allowSymbols)
        {
            this.model.GeneratePassword(length, allowUpperCase, allowNumbers, allowSymbols);
        }

        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("GeneratedPassword"))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs("GeneratedPassword"));
            }
        }

        public string UserPassword
        {
            get;
            set;
        }

        public bool AllowUpperCase
        {
            get;
            set;
        }

        public bool AllowNumbers
        {
            get;
            set;
        }

        public bool AllowSymbols
        {
            get;
            set;
        }

        public string GeneratedPassword
        {
            get
            {
                return this.model.Password;
            }
        }
 
    }
}
