using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryPassword
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
    }

        public class PasswordChecker
        {
            public static bool validatePassword(string password)
            {
            if (password.Length < 8 || password.Length > 20)
                return false;

            if (!password.Any(Char.IsLower))
                return false;

            if (!password.Any(Char.IsUpper))
                return false;

            if (!password.Any(Char.IsDigit))
                return false;

            if (password.Intersect("!@#$%^&*()").Count() == 0)
                return false;


            return true;
            }
        

        }

}
