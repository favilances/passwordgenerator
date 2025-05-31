using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string generatedPassword = PasswordGenerator.GeneratePassword('4');
            label1.Text = generatedPassword;

        }



        private void cuiCircleKnob1_ValueChanged(object sender, EventArgs e)
        {
            int length = (int)Math.Round(cuiCircleKnob1.Value);
            string generatedPassword = PasswordGenerator.GeneratePassword(length);
            label1.Text = generatedPassword;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            MessageBox.Show("copied!");
        }
    }

    public class PasswordGenerator
    {
        private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DigitChars = "0123456789";
        private const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:',.<>/?";

        public static string GeneratePassword(int length)
        {
            return GeneratePassword(length, true, true, true, true);
        }

        public static string GeneratePassword(int length, bool includeLowercase, bool includeUppercase, bool includeDigits, bool includeSpecials)
        {
            if (length <= 0)
            {
                throw new ArgumentException("The password length must be a positive value.", nameof(length));
            }

            if (!includeLowercase && !includeUppercase && !includeDigits && !includeSpecials)
            {
                throw new ArgumentException("At least one character type must be selected.");
            }

            StringBuilder charSet = new StringBuilder();
            if (includeLowercase)
            {
                charSet.Append(LowercaseChars);
            }
            if (includeUppercase)
            {
                charSet.Append(UppercaseChars);
            }
            if (includeDigits)
            {
                charSet.Append(DigitChars);
            }
            if (includeSpecials)
            {
                charSet.Append(SpecialChars);
            }

            if (charSet.Length == 0)
            {
                throw new InvalidOperationException("The character set to be used cannot be empty.");
            }

            StringBuilder password = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (password.Length < length)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    password.Append(charSet[(int)(num % (uint)charSet.Length)]);
                }
            }
            return password.ToString();
        }

    
    }
}
