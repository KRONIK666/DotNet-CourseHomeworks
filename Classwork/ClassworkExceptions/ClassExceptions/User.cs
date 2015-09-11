using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptions
{
    class User
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (CheckEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new InvalidEmailException("Invalid e-mail!");
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (CheckPassword(value))
                {
                    this.password = value;
                }
                else
                {
                    throw new InvalidPasswordException("Invalid password!");
                }
            }
        }

        public User()
        {
        }

        public User(string email, string password)
        {
        }

        private bool CheckEmail(string email)
        {
            if (email.Length < 6)
            {
                return false;
            }
            if (email.Contains('@') == false || email.Contains('.') == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckPassword(string password)
        {
            if (password.Length >= 6)
            {
                foreach (char symbol in password)
                {
                    if (char.IsDigit(symbol))
                    {
                        return true;
                    }
                } return false;
            }
            else
            {
                return false;
            }
        }
    }
}