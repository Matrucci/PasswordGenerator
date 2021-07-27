﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class PasswordValidationModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int strength;

        public int Strength
        {
            get { return this.strength; }
            set
            {
                if (this.strength != value)
                {
                    this.strength = value;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("PasswordStrength"));
                    }
                }
            }
        }

        public void CheckPassword(string password)
        {
            int flag = 0;
            string temp = password.Replace("-", "");
            if (temp.Length < 5 || temp == null)
            {
                Strength = 0;
                return;
            }
            if (temp.Any(char.IsDigit))
            {
                flag++;
            }
            if (temp.Any(char.IsUpper))
            {
                flag++;
            }
            if (temp.Any(c => !char.IsLetterOrDigit(c)))
            {
                flag++;
            }
            Strength = flag;
        }
    }
}