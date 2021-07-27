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

        /*********************
         * Password property.
         ********************/
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

        /*****************************************************************
         * Generating a new password according to the given preferences.
         *****************************************************************/
        public void GeneratePassword(int length, bool allowUpperCase, bool allowNumbers, bool allowSymbols)
        {
            //Setting up the valid characters.
            StringBuilder validBuilder = new StringBuilder();
            validBuilder.Append("abcdefghijklmnopqrstuvwxyz");
            if (allowNumbers)
            {
                validBuilder.Append("0123456789");
            }
            if (allowUpperCase)
            {
                validBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }
            if (allowSymbols)
            {
                validBuilder.Append("!@#$%^&*");
            }
            string valid = validBuilder.ToString();

            StringBuilder pass = new StringBuilder();
            Random rnd = new Random();

            //Generating a randomized password separated by "-" every 4 characters.
            for (int i = 0; i < length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    pass.Append(valid[rnd.Next(valid.Length)]);
                }
                pass.Append("-");
            }
            pass.Remove(pass.Length - 1, 1);
            //Updating the generated password.
            Password = pass.ToString();
        }
    }
}
