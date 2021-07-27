using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Password_Generator
{
    class PasswordGeneratorVM : INotifyPropertyChanged
    {
        private string userPassword;
        private string generatedPassword;
        private bool isWeak;
        private bool isNormal;
        private bool isModerate;
        private bool isStrong;

        public event PropertyChangedEventHandler PropertyChanged;

        private MainWindow mainView;
        private PasswordGeneratorModel passwordGeneratorModel;
        private PasswordValidationModel passwordValidationModel;

        public PasswordGeneratorVM(MainWindow mainWindow)
        {
            this.mainView = mainWindow;
            this.passwordGeneratorModel = new PasswordGeneratorModel();
            this.passwordGeneratorModel.PropertyChanged += OnPropertyChanged;
            this.passwordValidationModel = new PasswordValidationModel();
            this.passwordValidationModel.PropertyChanged += OnPropertyChanged;
        }

        public void GeneratePasswordClicked(int length, bool allowUpperCase, bool allowNumbers, bool allowSymbols)
        {
            this.passwordGeneratorModel.GeneratePassword(length, allowUpperCase, allowNumbers, allowSymbols);
        }

        public void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("GeneratedPassword"))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs("GeneratedPassword"));
            }
            else if (e.PropertyName.Equals("PasswordStrength"))
            {
                if (this.passwordValidationModel.Strength == 0)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsWeak"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsNormal"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsModerate"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsStrong"));
                }
                if (this.passwordValidationModel.Strength == 1)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsNormal"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsModerate"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsStrong"));
                }
                if (this.passwordValidationModel.Strength == 2)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsModerate"));
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsStrong"));
                }
                if (this.passwordValidationModel.Strength == 3)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("IsStrong"));
                }
\            }
        }

        public string UserPassword
        {
            get
            {
                return this.userPassword;
            }
            set
            {
                if (this.userPassword != value)
                {
                    this.userPassword = value;
                    this.passwordValidationModel.CheckPassword(value);
                }
            }
        }

        public string GeneratedPassword
        {
            get
            {
                return this.passwordGeneratorModel.Password;
            }
        }

        public Visibility IsWeak
        {
            get 
            { 
                if (this.passwordValidationModel.Strength >= 0)
                {
                    return Visibility.Visible;
                }
                return Visibility.Hidden;
            }
            set
            {
               
            }
        }

        public Visibility IsNormal
        {
            get
            {
                if (this.passwordValidationModel.Strength >= 1)
                {
                    return Visibility.Visible;
                }
                return Visibility.Hidden;
            }
            set { }
        }

        public Visibility IsModerate
        {
            get
            {
                if (this.passwordValidationModel.Strength >= 2)
                {
                    return Visibility.Visible;
                }
                return Visibility.Hidden;
            }
            set { }
        }
        public Visibility IsStrong
        {
            get
            {
                if (this.passwordValidationModel.Strength >= 3)
                {
                    return Visibility.Visible;
                }
                return Visibility.Hidden;
            }
            set { }
        }

    }
}
