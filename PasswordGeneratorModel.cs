using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class PasswordGeneratorModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string password;

        public PasswordGeneratorModel()
        {

        }

        public string Password
        {
            get { return this.password; }
            set
            {
                if (this.password != value)
                {
                    this.password = value;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("GeneratedPassword"));
                    }
                }
            }
        }

        public void GeneratePassword(int length, bool allowUpperCase, bool allowNumbers, bool allowSymbols)
        {
            string valid = "abcdefghijklmnopqrstuvwxyz";
            if (allowNumbers)
            {
                valid += "0123456789";
            }
            if (allowUpperCase)
            {
                valid += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (allowSymbols)
            {
                valid += "!@#$%^&*";
            }

            StringBuilder pass = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pass.Append(valid[rnd.Next(valid.Length)]);
                }
                pass.Append("-");
            }
            pass.Remove(pass.Length - 1, 1);
            Password = pass.ToString();
        }
    }
}
