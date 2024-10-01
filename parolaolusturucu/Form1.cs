using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parolaolusturucu
{
    public partial class Form1 : Form
    {
        int currentPasswordLenght = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLength)
        {
            String allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghıjklmnopqrstuvwxyz!@#$^+%&=?";
            String randomPassword = "";

            for (int i = 0; i < passwordLength; i++)
            {
                int RandomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[RandomNum];
            }
           label1.Text = randomPassword;

        }
        public Form1()
        {
            InitializeComponent();
            passwordGenerator(20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passwordLengthSlider_Scroll(object sender, ScrollEventArgs e)
        {
            passwordLenghtText.Text = "Parola Uzunluğu : " + passwordLengthSlider.Value.ToString();
            currentPasswordLenght = passwordLengthSlider.Value;
            passwordGenerator(currentPasswordLenght);
        }

        private void passwordCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://favilances.com.tr");
        }
    }
}
